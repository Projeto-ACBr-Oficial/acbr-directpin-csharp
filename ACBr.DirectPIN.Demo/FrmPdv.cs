using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACBr.DirectPIN.Demo.Helpers;
using ACBr.DirectPIN.Demo.Models;
using ACBr.DirectPIN.Demo.Services;
using Lib.DirectPIN.Classes.Request;
using Lib.DirectPIN.Classes.Response;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Exceptions;
using Lib.FormsAuxiliares;

namespace ACBr.DirectPIN.Demo
{
    public partial class FrmPdv : Form
    {
        private readonly DirectPINDemoService _service = new DirectPINDemoService();
        private readonly DemoPosPrinterService _impressora = new DemoPosPrinterService();
        private readonly BindingList<DadosTransacaoGrid> _transacoes = new BindingList<DadosTransacaoGrid>();
        private readonly BindingList<ItemTransacaoGrid> _consultaTransacoes = new BindingList<ItemTransacaoGrid>();

        private int _itemContador;
        private decimal _valorTotalOperacao;
        private decimal _valorPago;
        private bool _vendaFinalizada;
        private bool _transacaoPendente;

        public FrmPdv()
        {
            InitializeComponent();
        }

        private void FrmPdv_Load(object sender, EventArgs e)
        {
            AppIconHelper.AplicarIconePadrao(this);
            AcbrNativeThread.RegistrarControleUi(this);
            ConfigurarColunasGrid();
            gridTransacoes.DataSource = _transacoes;

            ConfigurarColunasGridConsulta();
            gridConsultaTransacoes.DataSource = _consultaTransacoes;

            _service.OnLog += (s, mensagem) => AppendLog(mensagem);

            cboColetaTipoEntrada.Items.AddRange(new object[] { "TEXT", "NUMERIC", "NUMERIC_PASSWORD", "PASSWORD", "EMAIL" });
            cboColetaTipoEntrada.SelectedIndex = 0;

            cboMensagemTipo.Items.AddRange(new object[] { "TEXT", "QR_CODE" });
            cboMensagemTipo.SelectedIndex = 0;

            cboPesquisaTipo.Items.AddRange(new object[] { "NPS", "CSAT", "CES", "GENERIC" });
            cboPesquisaTipo.SelectedIndex = 0;

            cboFiltroStatus.Items.AddRange(Enum.GetNames(typeof(StatusTransacao)));
            cboFiltroStatus.SelectedIndex = 0;
            cboFiltroStatus.Enabled = false;
            chkFiltroStatus.CheckedChanged += (s, ev) => cboFiltroStatus.Enabled = chkFiltroStatus.Checked;

            cboFiltroTipo.Items.AddRange(Enum.GetNames(typeof(TipoTransacao)));
            cboFiltroTipo.SelectedIndex = 0;
            cboFiltroTipo.Enabled = false;
            chkFiltroTipo.CheckedChanged += (s, ev) => cboFiltroTipo.Enabled = chkFiltroTipo.Checked;

            tabOperacao.Enabled = false;
            AtualizarTotais();
            DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
        }

        private async void FrmPdv_Shown(object sender, EventArgs e)
        {
            await InicializarDirectPINAsync();
        }

        private async Task InicializarDirectPINAsync()
        {
            try
            {
                var config = DirectPINConfigService.Carregar();
                await Task.Run(() => _service.Inicializar(config)).ConfigureAwait(true);
                tabOperacao.Enabled = true;
                DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
            }
            catch (DirectPINException ex)
            {
                tabOperacao.Enabled = false;
                DefinirStatusCaixa("DIRECTPIN INDISPONÍVEL", Color.DarkRed);
                MessageBox.Show(this, ex.Message, "DirectPIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnConfiguracao_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmConfiguracao())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    await InicializarDirectPINAsync();
            }
        }

        private void btnGerarDocumento_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = _service.GerarDocumento();
        }

        private async void btnEfetuarPagamento_Click(object sender, EventArgs e)
        {
            using (var frmTipo = new FrmMenuOpcoes())
            {
                frmTipo.Titulo = "Forma de pagamento";
                frmTipo.DefinirOpcoes("Débito", "Crédito", "PIX");

                if (frmTipo.ShowDialog(this) != DialogResult.OK)
                    return;

                switch (frmTipo.OpcaoSelecionada)
                {
                    case "Débito":
                        await ExecutarPagamentoAsync(TipoTransacao.DEBIT, "Débito").ConfigureAwait(true);
                        return;

                    case "PIX":
                        await ExecutarPagamentoAsync(TipoTransacao.PIX, "PIX").ConfigureAwait(true);
                        return;

                    case "Crédito":
                        using (var frmModalidade = new FrmMenuOpcoes())
                        {
                            frmModalidade.Titulo = "Modalidade de crédito";
                            frmModalidade.DefinirOpcoes("À Vista", "Parcelado pelo Estabelecimento", "Parcelado pelo Emissor");

                            if (frmModalidade.ShowDialog(this) != DialogResult.OK)
                                return;

                            switch (frmModalidade.OpcaoSelecionada)
                            {
                                case "À Vista":
                                    await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Crédito", TipoCredito.NO_INSTALLMENT).ConfigureAwait(true);
                                    break;

                                case "Parcelado pelo Estabelecimento":
                                    await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Créd.Parc.Estabelec.", TipoCredito.INSTALLMENT, TipoJuros.MERCHANT).ConfigureAwait(true);
                                    break;

                                case "Parcelado pelo Emissor":
                                    await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Créd.Parc.Emissor", TipoCredito.INSTALLMENT, TipoJuros.ISSUER).ConfigureAwait(true);
                                    break;
                            }
                        }
                        return;
                }
            }
        }

        private async void btnDebito_Click(object sender, EventArgs e) =>
            await ExecutarPagamentoAsync(TipoTransacao.DEBIT, "Débito");

        private async void btnCredito_Click(object sender, EventArgs e) =>
            await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Crédito", TipoCredito.NO_INSTALLMENT);

        private async void btnCreditoParceladoEstabelecimento_Click(object sender, EventArgs e) =>
            await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Créd.Parc.Estabelec.", TipoCredito.INSTALLMENT, TipoJuros.MERCHANT);

        private async void btnCreditoParceladoEmissor_Click(object sender, EventArgs e) =>
            await ExecutarPagamentoAsync(TipoTransacao.CREDIT, "Créd.Parc.Emissor", TipoCredito.INSTALLMENT, TipoJuros.ISSUER);

        private async void btnPix_Click(object sender, EventArgs e) =>
            await ExecutarPagamentoAsync(TipoTransacao.PIX, "PIX");

        private async Task ExecutarPagamentoAsync(TipoTransacao tipo, string descricao,
            TipoCredito? creditType = null, TipoJuros? interestType = null)
        {
            if (_vendaFinalizada)
            {
                MessageBox.Show(this, "Inicie uma nova venda antes de efetuar outro pagamento.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_transacaoPendente)
            {
                MessageBox.Show(this, "Há uma transação pendente. Confirme ou desfaça-a na aba Administrativo antes de continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numValorOperacao.Value <= 0)
            {
                MessageBox.Show(this, "Informe um valor de operação maior que zero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_valorTotalOperacao == 0)
            {
                _valorTotalOperacao = numValorOperacao.Value;
                numValorOperacao.Enabled = false;
            }

            decimal restante = _valorTotalOperacao - _valorPago;
            if (restante <= 0)
            {
                MessageBox.Show(this, "A venda já está totalmente paga.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valorSugerido = Math.Min(restante, numValorOperacao.Value);

            using (var frmValor = new FrmConfirmarValor())
            {
                frmValor.Maximo = restante;
                frmValor.Valor = valorSugerido;

                if (frmValor.ShowDialog(this) != DialogResult.OK)
                    return;

                valorSugerido = frmValor.Valor;
            }

            if (valorSugerido <= 0)
            {
                MessageBox.Show(this, "Informe um valor maior que zero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valorTransacao = valorSugerido;
            long valorCentavos = (long)Math.Round(valorTransacao * 100m, MidpointRounding.AwayFromZero);

            int? parcelas = null;
            if (creditType == TipoCredito.INSTALLMENT)
            {
                if (numQtdParcelas.Value == 1)
                {
                    using (var frmParcelas = new FrmColetaNumero())
                    {
                        frmParcelas.Titulo = "Número de parcelas";
                        frmParcelas.Minimo = 2;
                        frmParcelas.Maximo = 24;
                        frmParcelas.Valor = 2;

                        if (frmParcelas.ShowDialog(this) != DialogResult.OK)
                            return;

                        parcelas = frmParcelas.Valor;
                    }
                }
                else
                {
                    parcelas = (int)numQtdParcelas.Value;
                }
            }

            string customerId = _service.GerarDocumento();
            txtDocumento.Text = customerId;

            HabilitarControlesPagamento(false);
            DefinirStatusCaixa("EM PAGAMENTO", Color.OrangeRed);

            try
            {
                RespostaTransacao resposta = await _service.EfetuarPagamentoAsync(
                    customerId, valorCentavos, tipo, creditType, interestType, parcelas).ConfigureAwait(true);

                if (resposta.Result && resposta.FinalResult == "APPROVED")
                {
                    _itemContador++;
                    _transacoes.Add(DadosTransacaoGrid.ParaGridItem(_itemContador, descricao, resposta, "Aprovado"));
                    _valorPago += valorTransacao;

                    if (!string.IsNullOrEmpty(resposta.ReceiptContent))
                    {
                        string texto = resposta.ReceiptContent.Replace("@", Environment.NewLine) + Environment.NewLine;
                        txtComprovante.Text += texto;
                        ImprimirSeAutomatico(texto);
                    }

                    AtualizarTotais();

                    if (_valorPago >= _valorTotalOperacao)
                        FinalizarVenda();
                    else
                        DefinirStatusCaixa("PAGAMENTO PARCIAL", Color.DarkGoldenrod);
                }
                else if (resposta.Result && resposta.FinalResult == "PENDING")
                {
                    _transacaoPendente = true;

                    _itemContador++;
                    _transacoes.Add(DadosTransacaoGrid.ParaGridItem(_itemContador, descricao, resposta, "Pendente"));

                    if (!string.IsNullOrEmpty(resposta.ReceiptContent))
                    {
                        string texto = resposta.ReceiptContent.Replace("@", Environment.NewLine) + Environment.NewLine;
                        txtComprovante.Text += texto;
                        ImprimirSeAutomatico(texto);
                    }

                    txtNsuAdmin.Text = resposta.Nsu;

                    MessageBox.Show(this,
                        $"Transação pendente de confirmação (NSU {resposta.Nsu}). Confirme ou desfaça manualmente na aba Administrativo.",
                        "Transação pendente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DefinirStatusCaixa("TRANSAÇÃO PENDENTE", Color.DarkGoldenrod);
                }
                else
                {
                    MessageBox.Show(this, $"{resposta.Message} ({resposta.FinalResult})", "Pagamento recusado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
                }
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
            }
            finally
            {
                HabilitarControlesPagamento(!_transacaoPendente);
            }
        }

        private void FinalizarVenda()
        {
            _vendaFinalizada = true;
            BloquearCamposVendaEmAndamento();
            DefinirStatusCaixa("VENDA CONCLUÍDA", Color.SteelBlue);
        }

        /// <summary>
        /// Envia o texto para a impressora quando "Enviar comprovante para a impressora
        /// automaticamente" está marcado na Configuração. Usado ao concluir a venda e após
        /// cada operação da aba Administrativo que retorna comprovante (cancelamento,
        /// confirmação, desfazimento).
        /// </summary>
        private void ImprimirSeAutomatico(string texto)
        {
            if (!PosPrinterConfigService.ImprimirAutomaticamente || string.IsNullOrWhiteSpace(texto))
                return;

            try
            {
                _impressora.ImprimirTexto(texto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Falha ao imprimir automaticamente: {ex.Message}", "Imprimir",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            _transacoes.Clear();
            _itemContador = 0;
            _valorTotalOperacao = 0;
            _valorPago = 0;
            _vendaFinalizada = false;
            _transacaoPendente = false;

            txtDocumento.Clear();
            numValorOperacao.Value = 0;
            numQtdParcelas.Value = 1;
            txtComprovante.Clear();

            LiberarCamposVenda();
            AtualizarTotais();
            DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
        }

        private void HabilitarControlesPagamento(bool habilitar)
        {
            btnDebito.Enabled = habilitar;
            btnCredito.Enabled = habilitar;
            btnCreditoParceladoEstabelecimento.Enabled = habilitar;
            btnCreditoParceladoEmissor.Enabled = habilitar;
            btnPix.Enabled = habilitar;
            btnEfetuarPagamento.Enabled = habilitar;
            btnNovaVenda.Enabled = habilitar;
        }

        private void BloquearCamposVendaEmAndamento()
        {
            HabilitarControlesPagamento(false);
            btnNovaVenda.Enabled = true;
            numValorOperacao.Enabled = false;
            txtDocumento.Enabled = false;
            btnGerarDocumento.Enabled = false;
        }

        private void LiberarCamposVenda()
        {
            HabilitarControlesPagamento(true);
            numValorOperacao.Enabled = true;
            txtDocumento.Enabled = true;
            btnGerarDocumento.Enabled = true;
        }

        private void AtualizarTotais()
        {
            decimal total = _valorTotalOperacao > 0 ? _valorTotalOperacao : numValorOperacao.Value;
            decimal troco = _valorPago > total ? _valorPago - total : 0;

            lblTotalOperacao.Text = total.ToString("C2");
            lblTotalPago.Text = _valorPago.ToString("C2");
            lblTroco.Text = troco.ToString("C2");
        }

        /// <summary>
        /// Reflete na grid/totais da venda em andamento a confirmação ou desfazimento manual
        /// (aba Administrativo) de uma transação que ficou pendente. Sem isso, uma transação
        /// pendente confirmada/desfeita por NSU nunca sai do status "Pendente" na grid nem
        /// atualiza o total pago da venda.
        /// </summary>
        private void AtualizarTransacaoPendenteNaVenda(string nsu, string novoStatus, string novoResultado, bool contabilizarValor)
        {
            DadosTransacaoGrid item = _transacoes.FirstOrDefault(t => t.Nsu == nsu && t.Status == "Pendente");
            if (item == null)
                return;

            item.Status = novoStatus;
            item.Resultado = novoResultado;
            _transacoes.ResetItem(_transacoes.IndexOf(item));

            _transacaoPendente = false;
            HabilitarControlesPagamento(true);

            if (contabilizarValor)
            {
                _valorPago += item.Valor;
                AtualizarTotais();

                if (_valorPago >= _valorTotalOperacao)
                    FinalizarVenda();
                else
                    DefinirStatusCaixa("PAGAMENTO PARCIAL", Color.DarkGoldenrod);
            }
            else if (_valorPago > 0)
            {
                DefinirStatusCaixa("PAGAMENTO PARCIAL", Color.DarkGoldenrod);
            }
            else
            {
                DefinirStatusCaixa("CAIXA LIVRE", Color.DarkGreen);
            }
        }

        private void DefinirStatusCaixa(string texto, Color cor)
        {
            lblStatusCaixa.Text = texto;
            lblStatusCaixa.ForeColor = cor;
        }

        // --- Aba Administrativo ---

        private async void btnCancelarTransacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNsuAdmin.Text))
            {
                MessageBox.Show(this, "Informe o NSU.", "Cancelar transação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resposta = await _service.CancelarTransacaoAsync(txtNsuAdmin.Text).ConfigureAwait(true);

                if (!string.IsNullOrEmpty(resposta.ReceiptContent))
                {
                    string texto = resposta.ReceiptContent.Replace("@", Environment.NewLine) + Environment.NewLine;
                    txtComprovante.Text += texto;
                    ImprimirSeAutomatico(texto);
                }

                MessageBox.Show(this, $"{resposta.Message} ({resposta.FinalResult})", "Cancelamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnConfirmarTransacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNsuAdmin.Text))
            {
                MessageBox.Show(this, "Informe o NSU.", "Confirmar transação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resposta = await _service.ConfirmarTransacaoAsync(txtNsuAdmin.Text).ConfigureAwait(true);

                if (resposta.Result && resposta.FinalResult == "CONFIRMED")
                    AtualizarTransacaoPendenteNaVenda(txtNsuAdmin.Text, "Aprovado", resposta.FinalResult, contabilizarValor: true);

                MessageBox.Show(this, $"{resposta.Message} ({resposta.FinalResult})", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDesfazerTransacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNsuAdmin.Text))
            {
                MessageBox.Show(this, "Informe o NSU.", "Desfazer transação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resposta = await _service.DesfazerTransacaoAsync(txtNsuAdmin.Text).ConfigureAwait(true);

                if (resposta.Result && resposta.FinalResult == "UNDONE")
                    AtualizarTransacaoPendenteNaVenda(txtNsuAdmin.Text, "Desfeita", resposta.FinalResult, contabilizarValor: false);

                MessageBox.Show(this, $"{resposta.Message} ({resposta.FinalResult})", "Desfazimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAbortar_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.AbortarAsync().ConfigureAwait(true);
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Abortar operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnConsultarStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show(this, "Informe o CustomerId.", "Consultar status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConsultarStatus.Enabled = false;
            _consultaTransacoes.Clear();
            lblResultadoListagem.Text = "";

            try
            {
                var resposta = await _service.ConsultarStatusAsync(txtCustomerId.Text).ConfigureAwait(true);

                if (resposta.Result && resposta.Transaction != null)
                {
                    _consultaTransacoes.Add(ItemTransacaoGrid.DeItemTransacao(resposta.Transaction));
                    lblResultadoListagem.Text = "1 transação encontrada.";
                }
                else
                {
                    lblResultadoListagem.Text = resposta.Message;
                }
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConsultarStatus.Enabled = true;
            }
        }

        private async void btnListarTransacoes_Click(object sender, EventArgs e)
        {
            btnListarTransacoes.Enabled = false;
            lblResultadoListagem.Text = "";

            try
            {
                var payload = new PayloadListagemTransacoes
                {
                    CustomerId = string.IsNullOrWhiteSpace(txtCustomerId.Text) ? null : txtCustomerId.Text,
                    Nsu = string.IsNullOrWhiteSpace(txtFiltroNsu.Text) ? null : txtFiltroNsu.Text,
                    Status = chkFiltroStatus.Checked
                        ? (StatusTransacao?)Enum.Parse(typeof(StatusTransacao), (string)cboFiltroStatus.SelectedItem)
                        : null,
                    TypeTransaction = chkFiltroTipo.Checked
                        ? (TipoTransacao?)Enum.Parse(typeof(TipoTransacao), (string)cboFiltroTipo.SelectedItem)
                        : null,
                    DateStart = dtpFiltroDataInicio.Checked
                        ? (long?)new DateTimeOffset(dtpFiltroDataInicio.Value).ToUnixTimeMilliseconds()
                        : null,
                    DateEnd = dtpFiltroDataFim.Checked
                        ? (long?)new DateTimeOffset(dtpFiltroDataFim.Value).ToUnixTimeMilliseconds()
                        : null,
                    Limit = (int)numFiltroLimit.Value,
                    Offset = (int)numFiltroOffset.Value
                };

                var resposta = await _service.ListarTransacoesAsync(payload).ConfigureAwait(true);

                _consultaTransacoes.Clear();
                if (resposta.Transactions != null)
                    foreach (var item in resposta.Transactions)
                        _consultaTransacoes.Add(ItemTransacaoGrid.DeItemTransacao(item));

                lblResultadoListagem.Text = $"Exibindo {resposta.Count} de {resposta.TotalCount} transação(ões).";
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, ex.Message, "Falha de comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnListarTransacoes.Enabled = true;
            }
        }

        // --- Aba Utilitários ---

        private async void btnColetarDados_Click(object sender, EventArgs e)
        {
            btnColetarDados.Enabled = false;
            txtColetaResultado.Text = "";

            try
            {
                var resposta = await _service.ColetarDadosAsync(
                    txtColetaTitulo.Text,
                    txtColetaMascara.Text,
                    (string)cboColetaTipoEntrada.SelectedItem).ConfigureAwait(true);

                txtColetaResultado.Text = resposta.Result ? resposta.Data : resposta.Message;
            }
            catch (DirectPINException ex)
            {
                txtColetaResultado.Text = ex.Message;
            }
            finally
            {
                btnColetarDados.Enabled = true;
            }
        }

        private async void btnExibirMensagem_Click(object sender, EventArgs e)
        {
            btnExibirMensagem.Enabled = false;
            txtMensagemResultado.Text = "";

            try
            {
                var payload = new PayloadMensagem
                {
                    TypeMessage = (TipoMensagem)Enum.Parse(typeof(TipoMensagem), (string)cboMensagemTipo.SelectedItem),
                    Title = txtMensagemTitulo.Text,
                    Message = txtMensagemTexto.Text,
                    ConfirmMessage = txtMensagemConfirmar.Text,
                    CancelMessage = txtMensagemCancelar.Text,
                    TimeOut = (long)numMensagemTimeout.Value
                };

                var resposta = await _service.ExibirMensagemAsync(payload).ConfigureAwait(true);
                txtMensagemResultado.Text = resposta.Message;
            }
            catch (DirectPINException ex)
            {
                txtMensagemResultado.Text = ex.Message;
            }
            finally
            {
                btnExibirMensagem.Enabled = true;
            }
        }

        private async void btnPesquisaSatisfacao_Click(object sender, EventArgs e)
        {
            btnPesquisaSatisfacao.Enabled = false;
            txtPesquisaResultado.Text = "";

            try
            {
                var payload = new PayloadPesquisa
                {
                    Title = txtPesquisaTitulo.Text,
                    Question = txtPesquisaPergunta.Text,
                    ScaleMin = (int)numPesquisaScaleMin.Value,
                    ScaleMax = (int)numPesquisaScaleMax.Value,
                    SurveyType = (TipoPesquisa)Enum.Parse(typeof(TipoPesquisa), (string)cboPesquisaTipo.SelectedItem)
                };

                var resposta = await _service.PesquisaSatisfacaoAsync(payload).ConfigureAwait(true);
                txtPesquisaResultado.Text = resposta.Result
                    ? $"Nota: {resposta.Data?.Score} | Comentário: {resposta.Data?.Comment}"
                    : resposta.Message;
            }
            catch (DirectPINException ex)
            {
                txtPesquisaResultado.Text = ex.Message;
            }
            finally
            {
                btnPesquisaSatisfacao.Enabled = true;
            }
        }

        // --- Comprovante e log ---

        private void btnLimparComprovante_Click(object sender, EventArgs e) => txtComprovante.Clear();

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComprovante.Text))
            {
                MessageBox.Show(this, "Não há comprovante para imprimir.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _impressora.ImprimirTexto(txtComprovante.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Falha ao imprimir: {ex.Message}", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparLog_Click(object sender, EventArgs e) => txtLog.Clear();

        private void AppendLog(string mensagem)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => AppendLog(mensagem)));
                return;
            }

            txtLog.AppendText($"{DateTime.Now:HH:mm:ss} -> {mensagem}{Environment.NewLine}");

            if (txtLog.TextLength > 120000)
                txtLog.Clear();
        }

        private void ConfigurarColunasGrid()
        {
            gridTransacoes.Columns.Add(NovaColuna("Item", "#", "Item", 36));
            gridTransacoes.Columns.Add(NovaColuna("Tipo", "Tipo", "Tipo", 100));
            gridTransacoes.Columns.Add(NovaColuna("Valor", "Valor", "Valor", 80, "C2"));
            gridTransacoes.Columns.Add(NovaColuna("Nsu", "NSU", "Nsu", 120));
            gridTransacoes.Columns.Add(NovaColuna("NsuAdquirente", "NSU Adquirente", "NsuAdquirente", 110));
            gridTransacoes.Columns.Add(NovaColuna("Autorizacao", "Autoriz.", "Autorizacao", 72));
            gridTransacoes.Columns.Add(NovaColuna("Bandeira", "Bandeira", "Bandeira", 90));
            gridTransacoes.Columns.Add(NovaColuna("Cartao", "Cartão", "Cartao", 120));
            gridTransacoes.Columns.Add(NovaColuna("TipoCaptura", "Captura", "TipoCaptura", 100));
            gridTransacoes.Columns.Add(NovaColuna("Adquirente", "Adquirente", "Adquirente", 100));
            gridTransacoes.Columns.Add(NovaColuna("Data", "Data", "Data", 130));
            gridTransacoes.Columns.Add(NovaColuna("Resultado", "Resultado", "Resultado", 100));
            gridTransacoes.Columns.Add(NovaColuna("Status", "Status", "Status", 90));
        }

        private void ConfigurarColunasGridConsulta()
        {
            gridConsultaTransacoes.Columns.Add(NovaColuna("CustomerId", "CustomerId", "CustomerId", 100));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Nsu", "NSU", "Nsu", 120));
            gridConsultaTransacoes.Columns.Add(NovaColuna("NsuAcquirer", "NSU Adquirente", "NsuAcquirer", 110));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Status", "Status", "Status", 90));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Valor", "Valor", "Valor", 80, "C2"));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Data", "Data", "Data", 130));
            gridConsultaTransacoes.Columns.Add(NovaColuna("TypeTransaction", "Tipo", "TypeTransaction", 90));
            gridConsultaTransacoes.Columns.Add(NovaColuna("TypeCard", "Captura", "TypeCard", 100));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Brand", "Bandeira", "Brand", 90));
            gridConsultaTransacoes.Columns.Add(NovaColuna("PanMasked", "Cartão", "PanMasked", 120));
            gridConsultaTransacoes.Columns.Add(NovaColuna("AuthCode", "Autoriz.", "AuthCode", 72));
            gridConsultaTransacoes.Columns.Add(NovaColuna("Installments", "Parcelas", "Installments", 60));
            gridConsultaTransacoes.Columns.Add(NovaColuna("FinalResult", "Resultado", "FinalResult", 100));
            gridConsultaTransacoes.Columns.Add(NovaColuna("CodeResult", "Cód.", "CodeResult", 45));
        }

        private static DataGridViewTextBoxColumn NovaColuna(string nome, string cabecalho, string propriedade, int largura, string formato = null)
        {
            var coluna = new DataGridViewTextBoxColumn
            {
                Name = nome,
                HeaderText = cabecalho,
                DataPropertyName = propriedade,
                Width = largura,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            if (formato != null)
                coluna.DefaultCellStyle = new DataGridViewCellStyle { Format = formato };

            return coluna;
        }
    }
}
