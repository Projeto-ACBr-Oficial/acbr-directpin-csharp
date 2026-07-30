using System;
using System.Configuration;
using System.IO.Ports;
using System.Windows.Forms;
using ACBrLib.Core.PosPrinter;
using ACBrLib.PosPrinter;
using ACBr.DirectPIN.Demo.Helpers;
using Lib.DirectPIN.Classes;
using Lib.DirectPIN.Classes.Request;
using Lib.DirectPIN.Exceptions;
using ACBr.DirectPIN.Demo.Services;

namespace ACBr.DirectPIN.Demo
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            AppIconHelper.AplicarIconePadrao(this);

            // --- Aba DirectPIN ---
            AtualizarPortas(cboPortaCom);

            DirectPINConfig config = DirectPINConfigService.Carregar();
            if (!string.IsNullOrEmpty(config.PortaCom) && !cboPortaCom.Items.Contains(config.PortaCom))
                cboPortaCom.Items.Add(config.PortaCom);

            cboPortaCom.Text = config.PortaCom;

            cboBaudRate.Items.AddRange(new object[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "230400" });
            cboBaudRate.Text = config.BaudRate.ToString();

            cboDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            SelecionarItem(cboDataBits, config.DataBits.ToString());

            cboParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            SelecionarItem(cboParity, config.Parity.ToString());

            // StopBits.None não é um valor válido para SerialPort.Open() — fica fora da lista.
            cboStopBits.Items.AddRange(new object[] { nameof(StopBits.One), nameof(StopBits.OnePointFive), nameof(StopBits.Two) });
            SelecionarItem(cboStopBits, config.StopBits.ToString());

            txtEntityIdentifier.Text = config.EntityIdentifier;
            numTimeoutAckNak.Value = config.TimeoutAckNak;
            numTimeoutOperacao.Value = config.TimeoutOperacao;
            chkConfirmarAutomaticamente.Checked = config.ConfirmarTransacoesAutomaticamente;

            // --- Aba Impressora ---
            AtualizarPortasImpressora();

            cboModeloImpressora.Items.AddRange(Enum.GetNames(typeof(ACBrPosPrinterModelo)));
            cboPaginaCodigo.Items.AddRange(Enum.GetNames(typeof(PosPaginaCodigo)));

            string portaImpressora = ObterAppSetting("PosPrinter_Porta", "");
            if (!string.IsNullOrEmpty(portaImpressora) && !cboPortaImpressora.Items.Contains(portaImpressora))
                cboPortaImpressora.Items.Add(portaImpressora);
            cboPortaImpressora.Text = portaImpressora;

            SelecionarItem(cboModeloImpressora, ObterAppSetting("PosPrinter_Modelo", nameof(ACBrPosPrinterModelo.ppEscPosEpson)));
            SelecionarItem(cboPaginaCodigo, ObterAppSetting("PosPrinter_PaginaCodigo", nameof(PosPaginaCodigo.None)));

            chkCortarPapel.Checked = ObterAppSettingBool("PosPrinter_CortarPapel", true);
            numColunas.Value = ObterAppSettingInt("PosPrinter_Colunas", 48);
            numEspacos.Value = ObterAppSettingInt("PosPrinter_Espacos", 0);
            numBuffer.Value = ObterAppSettingInt("PosPrinter_Buffer", 0);
            numLinhasPular.Value = ObterAppSettingInt("PosPrinter_LinhasPular", 0);
            chkTraduzirTags.Checked = ObterAppSettingBool("PosPrinter_TraduzirTags", true);
            chkIgnorarTags.Checked = ObterAppSettingBool("PosPrinter_IgnorarTags", false);
            chkControlePorta.Checked = ObterAppSettingBool("PosPrinter_ControlePorta", false);
            txtArqLog.Text = ObterAppSetting("PosPrinter_ArqLog", "");
            chkImprimirAutomaticamente.Checked = ObterAppSettingBool("PosPrinter_ImprimirAutomaticamente", false);
        }

        private static void SelecionarItem(ComboBox combo, string valor)
        {
            combo.SelectedItem = combo.Items.Contains(valor) ? valor : (combo.Items.Count > 0 ? combo.Items[0] : null);
        }

        private void btnAtualizarPortas_Click(object sender, EventArgs e) => AtualizarPortas(cboPortaCom);

        private void btnAtualizarPortasImpressora_Click(object sender, EventArgs e) => AtualizarPortasImpressora();

        private static void AtualizarPortas(ComboBox combo)
        {
            string atual = combo.Text;
            combo.Items.Clear();
            combo.Items.AddRange(SerialPort.GetPortNames());
            combo.Text = atual;
        }

        /// <summary>
        /// Lista os destinos de impressão via ACBrPosPrinter.AcharPortas() (COM/USB/RAW nativo)
        /// + LPT1/LPT2 + arquivo de comprovante simulado + impressoras Windows instaladas —
        /// mesmo critério do combo "Porta" do ACBr.CliSiTef.Demo.
        /// </summary>
        private void AtualizarPortasImpressora()
        {
            string atual = cboPortaImpressora.Text;
            cboPortaImpressora.Items.Clear();
            cboPortaImpressora.Items.AddRange(PosPrinterConfigService.ObtemInstancia().ListarPortas());
            cboPortaImpressora.Text = atual;
        }

        private void btnArqLog_Click(object sender, EventArgs e)
        {
            using (var dialogo = new SaveFileDialog
            {
                Filter = "Arquivo de log (*.txt)|*.txt|Todos os arquivos (*.*)|*.*",
                FileName = txtArqLog.Text,
                OverwritePrompt = false
            })
            {
                if (dialogo.ShowDialog(this) == DialogResult.OK)
                    txtArqLog.Text = dialogo.FileName;
            }
        }

        private DirectPINConfig ObterConfigDirectPINDaTela()
        {
            return new DirectPINConfig
            {
                PortaCom = cboPortaCom.Text,
                BaudRate = int.TryParse(cboBaudRate.Text, out int baudRate) ? baudRate : 19200,
                DataBits = int.TryParse((string)cboDataBits.SelectedItem, out int dataBits) ? dataBits : 8,
                Parity = (Parity)Enum.Parse(typeof(Parity), (string)cboParity.SelectedItem),
                StopBits = (StopBits)Enum.Parse(typeof(StopBits), (string)cboStopBits.SelectedItem),
                EntityIdentifier = txtEntityIdentifier.Text,
                TimeoutAckNak = (int)numTimeoutAckNak.Value,
                TimeoutOperacao = (int)numTimeoutOperacao.Value,
                ConfirmarTransacoesAutomaticamente = chkConfirmarAutomaticamente.Checked
            };
        }

        private void AplicarConfigImpressoraNaTela(ACBrPosPrinter pos)
        {
            pos.Config.Porta = cboPortaImpressora.Text;
            pos.Config.Modelo = (ACBrPosPrinterModelo)Enum.Parse(typeof(ACBrPosPrinterModelo), (string)cboModeloImpressora.SelectedItem);
            pos.Config.CortaPapel = chkCortarPapel.Checked;
            pos.Config.ColunasFonteNormal = (int)numColunas.Value;
            pos.Config.EspacoEntreLinhas = (int)numEspacos.Value;
            pos.Config.LinhasBuffer = (int)numBuffer.Value;
            pos.Config.LinhasEntreCupons = (int)numLinhasPular.Value;
            pos.Config.TraduzirTags = chkTraduzirTags.Checked;
            pos.Config.IgnorarTags = chkIgnorarTags.Checked;
            pos.Config.ControlePorta = chkControlePorta.Checked;
            pos.Config.ArqLog = txtArqLog.Text;
            pos.Config.PaginaDeCodigo = (PosPaginaCodigo)Enum.Parse(typeof(PosPaginaCodigo), (string)cboPaginaCodigo.SelectedItem);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboPortaCom.Text))
            {
                MessageBox.Show(this, "Informe a porta COM do DirectPIN.", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboPortaImpressora.Text))
            {
                MessageBox.Show(this, "Informe a porta da impressora.", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DirectPINConfigService.Salvar(ObterConfigDirectPINDaTela());

            Configuration configuracaoApp = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            DefinirValor(configuracaoApp, "PosPrinter_Porta", cboPortaImpressora.Text);
            DefinirValor(configuracaoApp, "PosPrinter_Modelo", (string)cboModeloImpressora.SelectedItem);
            DefinirValor(configuracaoApp, "PosPrinter_CortarPapel", chkCortarPapel.Checked.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_Colunas", numColunas.Value.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_Espacos", numEspacos.Value.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_Buffer", numBuffer.Value.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_LinhasPular", numLinhasPular.Value.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_TraduzirTags", chkTraduzirTags.Checked.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_IgnorarTags", chkIgnorarTags.Checked.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_ControlePorta", chkControlePorta.Checked.ToString());
            DefinirValor(configuracaoApp, "PosPrinter_ArqLog", txtArqLog.Text);
            DefinirValor(configuracaoApp, "PosPrinter_PaginaCodigo", (string)cboPaginaCodigo.SelectedItem);
            DefinirValor(configuracaoApp, "PosPrinter_ImprimirAutomaticamente", chkImprimirAutomaticamente.Checked.ToString());
            configuracaoApp.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            PosPrinterConfigService.ObtemInstancia().AplicarConfiguracaoSalva();

            DialogResult = DialogResult.OK;
            Close();
        }

        private static void DefinirValor(Configuration configuracaoApp, string chave, string valor)
        {
            if (configuracaoApp.AppSettings.Settings[chave] == null)
                configuracaoApp.AppSettings.Settings.Add(chave, valor);
            else
                configuracaoApp.AppSettings.Settings[chave].Value = valor;
        }

        private static string ObterAppSetting(string chave, string _default) => ConfigurationManager.AppSettings[chave] ?? _default;

        private static int ObterAppSettingInt(string chave, int _default) =>
            int.TryParse(ConfigurationManager.AppSettings[chave], out int valor) ? valor : _default;

        private static bool ObterAppSettingBool(string chave, bool _default) =>
            bool.TryParse(ConfigurationManager.AppSettings[chave], out bool valor) ? valor : _default;

        private async void btnTestarConexao_Click(object sender, EventArgs e)
        {
            btnTestarConexao.Enabled = false;
            try
            {
                using (var client = new DirectPINClient(ObterConfigDirectPINDaTela()))
                {
                    client.Conectar();

                    // Round-trip real (write→ACK→frame de resposta→CRC): uma consulta de
                    // status por um customerId fictício comprova a comunicação de ponta a
                    // ponta melhor do que só abrir/fechar a porta (seção 6.9).
                    var resposta = await client.ConsultarStatusAsync(new PayloadStatusTransacao
                    {
                        CustomerId = "teste-conexao"
                    }).ConfigureAwait(true);

                    MessageBox.Show(this,
                        $"Comunicação OK. Resposta do terminal: \"{resposta.Message}\".",
                        "Testar conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DirectPINException ex)
            {
                MessageBox.Show(this, $"Falha na comunicação: {ex.Message}", "Testar conexão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTestarConexao.Enabled = true;
            }
        }

        private void btnAtivarImpressora_Click(object sender, EventArgs e)
        {
            btnAtivarImpressora.Enabled = false;
            try
            {
                var servico = PosPrinterConfigService.ObtemInstancia();
                AplicarConfigImpressoraNaTela(servico.PosPrinter);
                servico.SalvarConfiguracao();
                servico.Ativar();

                MessageBox.Show(this, "Impressora ativada com sucesso.", "Ativar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Falha ao ativar a impressora: {ex.Message}", "Ativar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAtivarImpressora.Enabled = true;
            }
        }

        private void btnTestarImpressora_Click(object sender, EventArgs e)
        {
            btnTestarImpressora.Enabled = false;
            try
            {
                var servico = PosPrinterConfigService.ObtemInstancia();
                AplicarConfigImpressoraNaTela(servico.PosPrinter);
                servico.SalvarConfiguracao();

                string texto = "Teste de impressão - ACBr DirectPIN Demo" + Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                new DemoPosPrinterService().ImprimirTexto(texto, chkCortarPapel.Checked);

                MessageBox.Show(this, "Impressão de teste enviada com sucesso.", "Testar impressora",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Falha ao imprimir: {ex.Message}", "Testar impressora",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTestarImpressora.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
