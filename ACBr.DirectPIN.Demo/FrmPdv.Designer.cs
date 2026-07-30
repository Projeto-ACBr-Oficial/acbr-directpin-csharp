namespace ACBr.DirectPIN.Demo
{
    partial class FrmPdv
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.Label lblStatusOperacao;
        private System.Windows.Forms.Button btnConfiguracao;

        private System.Windows.Forms.SplitContainer splitPrincipal;
        private System.Windows.Forms.TabControl tabOperacao;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabUtilitarios;

        private System.Windows.Forms.Panel pnlVendaTopo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnGerarDocumento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown numValorOperacao;
        private System.Windows.Forms.Button btnEfetuarPagamento;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown numQtdParcelas;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnCreditoParceladoEstabelecimento;
        private System.Windows.Forms.Button btnCreditoParceladoEmissor;
        private System.Windows.Forms.Button btnPix;

        private System.Windows.Forms.DataGridView gridTransacoes;

        private System.Windows.Forms.Panel pnlVendaRodape;
        private System.Windows.Forms.TableLayoutPanel tblTotais;
        private System.Windows.Forms.Label lblTituloTotalOperacao;
        private System.Windows.Forms.Label lblTotalOperacao;
        private System.Windows.Forms.Label lblTituloTotalPago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblTituloTroco;
        private System.Windows.Forms.Label lblTroco;

        private System.Windows.Forms.Label lblNsuAdmin;
        private System.Windows.Forms.TextBox txtNsuAdmin;
        private System.Windows.Forms.Button btnCancelarTransacao;
        private System.Windows.Forms.Button btnConfirmarTransacao;
        private System.Windows.Forms.Button btnDesfazerTransacao;
        private System.Windows.Forms.Button btnAbortar;

        private System.Windows.Forms.Panel pnlConsultaTopo;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnConsultarStatus;
        private System.Windows.Forms.GroupBox grpFiltrosListagem;
        private System.Windows.Forms.Label lblFiltroNsu;
        private System.Windows.Forms.TextBox txtFiltroNsu;
        private System.Windows.Forms.CheckBox chkFiltroStatus;
        private System.Windows.Forms.ComboBox cboFiltroStatus;
        private System.Windows.Forms.CheckBox chkFiltroTipo;
        private System.Windows.Forms.ComboBox cboFiltroTipo;
        private System.Windows.Forms.Label lblFiltroDataInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataInicio;
        private System.Windows.Forms.Label lblFiltroDataFim;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataFim;
        private System.Windows.Forms.Label lblFiltroLimit;
        private System.Windows.Forms.NumericUpDown numFiltroLimit;
        private System.Windows.Forms.Label lblFiltroOffset;
        private System.Windows.Forms.NumericUpDown numFiltroOffset;
        private System.Windows.Forms.Button btnListarTransacoes;
        private System.Windows.Forms.Label lblResultadoListagem;
        private System.Windows.Forms.DataGridView gridConsultaTransacoes;

        private System.Windows.Forms.GroupBox grpColeta;
        private System.Windows.Forms.Label lblColetaTitulo;
        private System.Windows.Forms.TextBox txtColetaTitulo;
        private System.Windows.Forms.Label lblColetaTipoEntrada;
        private System.Windows.Forms.ComboBox cboColetaTipoEntrada;
        private System.Windows.Forms.Label lblColetaMascara;
        private System.Windows.Forms.TextBox txtColetaMascara;
        private System.Windows.Forms.Button btnColetarDados;
        private System.Windows.Forms.Label lblColetaResultadoTitulo;
        private System.Windows.Forms.TextBox txtColetaResultado;

        private System.Windows.Forms.GroupBox grpMensagem;
        private System.Windows.Forms.Label lblMensagemTipo;
        private System.Windows.Forms.ComboBox cboMensagemTipo;
        private System.Windows.Forms.Label lblMensagemTimeout;
        private System.Windows.Forms.NumericUpDown numMensagemTimeout;
        private System.Windows.Forms.Label lblMensagemTitulo;
        private System.Windows.Forms.TextBox txtMensagemTitulo;
        private System.Windows.Forms.Label lblMensagemTexto;
        private System.Windows.Forms.TextBox txtMensagemTexto;
        private System.Windows.Forms.Label lblMensagemConfirmar;
        private System.Windows.Forms.TextBox txtMensagemConfirmar;
        private System.Windows.Forms.Label lblMensagemCancelar;
        private System.Windows.Forms.TextBox txtMensagemCancelar;
        private System.Windows.Forms.Button btnExibirMensagem;
        private System.Windows.Forms.Label lblMensagemResultadoTitulo;
        private System.Windows.Forms.TextBox txtMensagemResultado;

        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label lblPesquisaTitulo;
        private System.Windows.Forms.TextBox txtPesquisaTitulo;
        private System.Windows.Forms.Label lblPesquisaTipo;
        private System.Windows.Forms.ComboBox cboPesquisaTipo;
        private System.Windows.Forms.Label lblPesquisaPergunta;
        private System.Windows.Forms.TextBox txtPesquisaPergunta;
        private System.Windows.Forms.Label lblPesquisaScaleMin;
        private System.Windows.Forms.NumericUpDown numPesquisaScaleMin;
        private System.Windows.Forms.Label lblPesquisaScaleMax;
        private System.Windows.Forms.NumericUpDown numPesquisaScaleMax;
        private System.Windows.Forms.Button btnPesquisaSatisfacao;
        private System.Windows.Forms.Label lblPesquisaResultadoTitulo;
        private System.Windows.Forms.TextBox txtPesquisaResultado;

        private System.Windows.Forms.SplitContainer splitDireita;
        private System.Windows.Forms.GroupBox grpComprovante;
        private System.Windows.Forms.TextBox txtComprovante;
        private System.Windows.Forms.Button btnLimparComprovante;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnLimparLog;

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.lblStatusOperacao = new System.Windows.Forms.Label();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.tabOperacao = new System.Windows.Forms.TabControl();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.gridTransacoes = new System.Windows.Forms.DataGridView();
            this.pnlVendaRodape = new System.Windows.Forms.Panel();
            this.tblTotais = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloTotalOperacao = new System.Windows.Forms.Label();
            this.lblTituloTotalPago = new System.Windows.Forms.Label();
            this.lblTituloTroco = new System.Windows.Forms.Label();
            this.lblTotalOperacao = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.pnlVendaTopo = new System.Windows.Forms.Panel();
            this.btnPix = new System.Windows.Forms.Button();
            this.btnCreditoParceladoEmissor = new System.Windows.Forms.Button();
            this.btnCreditoParceladoEstabelecimento = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.numQtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnEfetuarPagamento = new System.Windows.Forms.Button();
            this.numValorOperacao = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnGerarDocumento = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNsuAdmin = new System.Windows.Forms.Label();
            this.txtNsuAdmin = new System.Windows.Forms.TextBox();
            this.btnCancelarTransacao = new System.Windows.Forms.Button();
            this.btnConfirmarTransacao = new System.Windows.Forms.Button();
            this.btnDesfazerTransacao = new System.Windows.Forms.Button();
            this.btnAbortar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridConsultaTransacoes = new System.Windows.Forms.DataGridView();
            this.pnlConsultaTopo = new System.Windows.Forms.Panel();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnConsultarStatus = new System.Windows.Forms.Button();
            this.grpFiltrosListagem = new System.Windows.Forms.GroupBox();
            this.lblFiltroNsu = new System.Windows.Forms.Label();
            this.txtFiltroNsu = new System.Windows.Forms.TextBox();
            this.chkFiltroStatus = new System.Windows.Forms.CheckBox();
            this.cboFiltroStatus = new System.Windows.Forms.ComboBox();
            this.chkFiltroTipo = new System.Windows.Forms.CheckBox();
            this.cboFiltroTipo = new System.Windows.Forms.ComboBox();
            this.lblFiltroDataInicio = new System.Windows.Forms.Label();
            this.dtpFiltroDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroDataFim = new System.Windows.Forms.Label();
            this.dtpFiltroDataFim = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroLimit = new System.Windows.Forms.Label();
            this.numFiltroLimit = new System.Windows.Forms.NumericUpDown();
            this.lblFiltroOffset = new System.Windows.Forms.Label();
            this.numFiltroOffset = new System.Windows.Forms.NumericUpDown();
            this.btnListarTransacoes = new System.Windows.Forms.Button();
            this.lblResultadoListagem = new System.Windows.Forms.Label();
            this.tabUtilitarios = new System.Windows.Forms.TabPage();
            this.grpColeta = new System.Windows.Forms.GroupBox();
            this.lblColetaTitulo = new System.Windows.Forms.Label();
            this.txtColetaTitulo = new System.Windows.Forms.TextBox();
            this.lblColetaTipoEntrada = new System.Windows.Forms.Label();
            this.cboColetaTipoEntrada = new System.Windows.Forms.ComboBox();
            this.lblColetaMascara = new System.Windows.Forms.Label();
            this.txtColetaMascara = new System.Windows.Forms.TextBox();
            this.btnColetarDados = new System.Windows.Forms.Button();
            this.lblColetaResultadoTitulo = new System.Windows.Forms.Label();
            this.txtColetaResultado = new System.Windows.Forms.TextBox();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.lblMensagemTipo = new System.Windows.Forms.Label();
            this.cboMensagemTipo = new System.Windows.Forms.ComboBox();
            this.lblMensagemTimeout = new System.Windows.Forms.Label();
            this.numMensagemTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblMensagemTitulo = new System.Windows.Forms.Label();
            this.txtMensagemTitulo = new System.Windows.Forms.TextBox();
            this.lblMensagemTexto = new System.Windows.Forms.Label();
            this.txtMensagemTexto = new System.Windows.Forms.TextBox();
            this.lblMensagemConfirmar = new System.Windows.Forms.Label();
            this.txtMensagemConfirmar = new System.Windows.Forms.TextBox();
            this.lblMensagemCancelar = new System.Windows.Forms.Label();
            this.txtMensagemCancelar = new System.Windows.Forms.TextBox();
            this.btnExibirMensagem = new System.Windows.Forms.Button();
            this.lblMensagemResultadoTitulo = new System.Windows.Forms.Label();
            this.txtMensagemResultado = new System.Windows.Forms.TextBox();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.lblPesquisaTitulo = new System.Windows.Forms.Label();
            this.txtPesquisaTitulo = new System.Windows.Forms.TextBox();
            this.lblPesquisaTipo = new System.Windows.Forms.Label();
            this.cboPesquisaTipo = new System.Windows.Forms.ComboBox();
            this.lblPesquisaPergunta = new System.Windows.Forms.Label();
            this.txtPesquisaPergunta = new System.Windows.Forms.TextBox();
            this.lblPesquisaScaleMin = new System.Windows.Forms.Label();
            this.numPesquisaScaleMin = new System.Windows.Forms.NumericUpDown();
            this.lblPesquisaScaleMax = new System.Windows.Forms.Label();
            this.numPesquisaScaleMax = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisaSatisfacao = new System.Windows.Forms.Button();
            this.lblPesquisaResultadoTitulo = new System.Windows.Forms.Label();
            this.txtPesquisaResultado = new System.Windows.Forms.TextBox();
            this.splitDireita = new System.Windows.Forms.SplitContainer();
            this.grpComprovante = new System.Windows.Forms.GroupBox();
            this.txtComprovante = new System.Windows.Forms.TextBox();
            this.btnLimparComprovante = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnLimparLog = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            this.tabOperacao.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacoes)).BeginInit();
            this.pnlVendaRodape.SuspendLayout();
            this.tblTotais.SuspendLayout();
            this.pnlVendaTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorOperacao)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTransacoes)).BeginInit();
            this.pnlConsultaTopo.SuspendLayout();
            this.grpFiltrosListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltroLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltroOffset)).BeginInit();
            this.tabUtilitarios.SuspendLayout();
            this.grpColeta.SuspendLayout();
            this.grpMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMensagemTimeout)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisaScaleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisaScaleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitDireita)).BeginInit();
            this.splitDireita.Panel1.SuspendLayout();
            this.splitDireita.Panel2.SuspendLayout();
            this.splitDireita.SuspendLayout();
            this.grpComprovante.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTopo.Controls.Add(this.lblStatusCaixa);
            this.pnlTopo.Controls.Add(this.lblStatusOperacao);
            this.pnlTopo.Controls.Add(this.btnConfiguracao);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(916, 55);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusCaixa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatusCaixa.Location = new System.Drawing.Point(103, 3);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(710, 28);
            this.lblStatusCaixa.TabIndex = 0;
            this.lblStatusCaixa.Text = "CAIXA LIVRE";
            this.lblStatusCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusOperacao.Location = new System.Drawing.Point(103, 33);
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            this.lblStatusOperacao.Size = new System.Drawing.Size(710, 17);
            this.lblStatusOperacao.TabIndex = 1;
            this.lblStatusOperacao.Text = "Aguardando...";
            this.lblStatusOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracao.Location = new System.Drawing.Point(816, 14);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(86, 28);
            this.btnConfiguracao.TabIndex = 2;
            this.btnConfiguracao.Text = "Configuração";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // splitPrincipal
            // 
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.Location = new System.Drawing.Point(0, 55);
            this.splitPrincipal.Name = "splitPrincipal";
            // 
            // splitPrincipal.Panel1
            // 
            this.splitPrincipal.Panel1.Controls.Add(this.tabOperacao);
            this.splitPrincipal.Panel1MinSize = 520;
            // 
            // splitPrincipal.Panel2
            // 
            this.splitPrincipal.Panel2.Controls.Add(this.splitDireita);
            this.splitPrincipal.Panel2MinSize = 320;
            this.splitPrincipal.Size = new System.Drawing.Size(916, 573);
            this.splitPrincipal.SplitterDistance = 582;
            this.splitPrincipal.SplitterWidth = 3;
            this.splitPrincipal.TabIndex = 1;
            // 
            // tabOperacao
            // 
            this.tabOperacao.Controls.Add(this.tabVenda);
            this.tabOperacao.Controls.Add(this.tabAdmin);
            this.tabOperacao.Controls.Add(this.tabUtilitarios);
            this.tabOperacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOperacao.Location = new System.Drawing.Point(0, 0);
            this.tabOperacao.Name = "tabOperacao";
            this.tabOperacao.SelectedIndex = 0;
            this.tabOperacao.Size = new System.Drawing.Size(582, 573);
            this.tabOperacao.TabIndex = 0;
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.gridTransacoes);
            this.tabVenda.Controls.Add(this.pnlVendaRodape);
            this.tabVenda.Controls.Add(this.pnlVendaTopo);
            this.tabVenda.Location = new System.Drawing.Point(4, 22);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(574, 547);
            this.tabVenda.TabIndex = 0;
            this.tabVenda.Text = "Venda";
            this.tabVenda.UseVisualStyleBackColor = true;
            // 
            // gridTransacoes
            // 
            this.gridTransacoes.AllowUserToAddRows = false;
            this.gridTransacoes.AllowUserToDeleteRows = false;
            this.gridTransacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTransacoes.Location = new System.Drawing.Point(3, 167);
            this.gridTransacoes.Name = "gridTransacoes";
            this.gridTransacoes.ReadOnly = true;
            this.gridTransacoes.RowHeadersVisible = false;
            this.gridTransacoes.Size = new System.Drawing.Size(568, 316);
            this.gridTransacoes.TabIndex = 1;
            // 
            // pnlVendaRodape
            // 
            this.pnlVendaRodape.Controls.Add(this.tblTotais);
            this.pnlVendaRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVendaRodape.Location = new System.Drawing.Point(3, 483);
            this.pnlVendaRodape.Name = "pnlVendaRodape";
            this.pnlVendaRodape.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.pnlVendaRodape.Size = new System.Drawing.Size(568, 61);
            this.pnlVendaRodape.TabIndex = 2;
            // 
            // tblTotais
            // 
            this.tblTotais.ColumnCount = 3;
            this.tblTotais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblTotais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblTotais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblTotais.Controls.Add(this.lblTituloTotalOperacao, 0, 0);
            this.tblTotais.Controls.Add(this.lblTituloTotalPago, 1, 0);
            this.tblTotais.Controls.Add(this.lblTituloTroco, 2, 0);
            this.tblTotais.Controls.Add(this.lblTotalOperacao, 0, 1);
            this.tblTotais.Controls.Add(this.lblTotalPago, 1, 1);
            this.tblTotais.Controls.Add(this.lblTroco, 2, 1);
            this.tblTotais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTotais.Location = new System.Drawing.Point(7, 3);
            this.tblTotais.Name = "tblTotais";
            this.tblTotais.RowCount = 2;
            this.tblTotais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblTotais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTotais.Size = new System.Drawing.Size(554, 55);
            this.tblTotais.TabIndex = 0;
            // 
            // lblTituloTotalOperacao
            // 
            this.lblTituloTotalOperacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloTotalOperacao.Location = new System.Drawing.Point(3, 0);
            this.lblTituloTotalOperacao.Name = "lblTituloTotalOperacao";
            this.lblTituloTotalOperacao.Size = new System.Drawing.Size(178, 19);
            this.lblTituloTotalOperacao.TabIndex = 0;
            this.lblTituloTotalOperacao.Text = "Total operação";
            // 
            // lblTituloTotalPago
            // 
            this.lblTituloTotalPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloTotalPago.Location = new System.Drawing.Point(187, 0);
            this.lblTituloTotalPago.Name = "lblTituloTotalPago";
            this.lblTituloTotalPago.Size = new System.Drawing.Size(178, 19);
            this.lblTituloTotalPago.TabIndex = 1;
            this.lblTituloTotalPago.Text = "Total pago";
            // 
            // lblTituloTroco
            // 
            this.lblTituloTroco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloTroco.Location = new System.Drawing.Point(371, 0);
            this.lblTituloTroco.Name = "lblTituloTroco";
            this.lblTituloTroco.Size = new System.Drawing.Size(180, 19);
            this.lblTituloTroco.TabIndex = 2;
            this.lblTituloTroco.Text = "Troco";
            // 
            // lblTotalOperacao
            // 
            this.lblTotalOperacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOperacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalOperacao.Location = new System.Drawing.Point(3, 19);
            this.lblTotalOperacao.Name = "lblTotalOperacao";
            this.lblTotalOperacao.Size = new System.Drawing.Size(178, 36);
            this.lblTotalOperacao.TabIndex = 3;
            this.lblTotalOperacao.Text = "R$ 0,00";
            this.lblTotalOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPago.Location = new System.Drawing.Point(187, 19);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(178, 36);
            this.lblTotalPago.TabIndex = 4;
            this.lblTotalPago.Text = "R$ 0,00";
            this.lblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTroco
            // 
            this.lblTroco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTroco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTroco.Location = new System.Drawing.Point(371, 19);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(180, 36);
            this.lblTroco.TabIndex = 5;
            this.lblTroco.Text = "R$ 0,00";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlVendaTopo
            // 
            this.pnlVendaTopo.Controls.Add(this.btnPix);
            this.pnlVendaTopo.Controls.Add(this.btnCreditoParceladoEmissor);
            this.pnlVendaTopo.Controls.Add(this.btnCreditoParceladoEstabelecimento);
            this.pnlVendaTopo.Controls.Add(this.btnCredito);
            this.pnlVendaTopo.Controls.Add(this.btnDebito);
            this.pnlVendaTopo.Controls.Add(this.numQtdParcelas);
            this.pnlVendaTopo.Controls.Add(this.lblParcelas);
            this.pnlVendaTopo.Controls.Add(this.btnNovaVenda);
            this.pnlVendaTopo.Controls.Add(this.btnEfetuarPagamento);
            this.pnlVendaTopo.Controls.Add(this.numValorOperacao);
            this.pnlVendaTopo.Controls.Add(this.lblValor);
            this.pnlVendaTopo.Controls.Add(this.btnGerarDocumento);
            this.pnlVendaTopo.Controls.Add(this.txtDocumento);
            this.pnlVendaTopo.Controls.Add(this.lblDocumento);
            this.pnlVendaTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendaTopo.Location = new System.Drawing.Point(3, 3);
            this.pnlVendaTopo.Name = "pnlVendaTopo";
            this.pnlVendaTopo.Size = new System.Drawing.Size(568, 164);
            this.pnlVendaTopo.TabIndex = 0;
            // 
            // btnPix
            // 
            this.btnPix.Location = new System.Drawing.Point(434, 106);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(101, 43);
            this.btnPix.TabIndex = 14;
            this.btnPix.Text = "PIX";
            this.btnPix.UseVisualStyleBackColor = true;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // btnCreditoParceladoEmissor
            // 
            this.btnCreditoParceladoEmissor.Location = new System.Drawing.Point(327, 106);
            this.btnCreditoParceladoEmissor.Name = "btnCreditoParceladoEmissor";
            this.btnCreditoParceladoEmissor.Size = new System.Drawing.Size(101, 43);
            this.btnCreditoParceladoEmissor.TabIndex = 12;
            this.btnCreditoParceladoEmissor.Text = "Crédito Parcelado Emissor";
            this.btnCreditoParceladoEmissor.UseVisualStyleBackColor = true;
            this.btnCreditoParceladoEmissor.Click += new System.EventHandler(this.btnCreditoParceladoEmissor_Click);
            // 
            // btnCreditoParceladoEstabelecimento
            // 
            this.btnCreditoParceladoEstabelecimento.Location = new System.Drawing.Point(220, 106);
            this.btnCreditoParceladoEstabelecimento.Name = "btnCreditoParceladoEstabelecimento";
            this.btnCreditoParceladoEstabelecimento.Size = new System.Drawing.Size(101, 43);
            this.btnCreditoParceladoEstabelecimento.TabIndex = 11;
            this.btnCreditoParceladoEstabelecimento.Text = "Crédito Parcelado Estabelecimento";
            this.btnCreditoParceladoEstabelecimento.UseVisualStyleBackColor = true;
            this.btnCreditoParceladoEstabelecimento.Click += new System.EventHandler(this.btnCreditoParceladoEstabelecimento_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(113, 106);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(101, 43);
            this.btnCredito.TabIndex = 10;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(7, 106);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(101, 43);
            this.btnDebito.TabIndex = 9;
            this.btnDebito.Text = "Débito";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // numQtdParcelas
            // 
            this.numQtdParcelas.Location = new System.Drawing.Point(141, 73);
            this.numQtdParcelas.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numQtdParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdParcelas.Name = "numQtdParcelas";
            this.numQtdParcelas.Size = new System.Drawing.Size(91, 20);
            this.numQtdParcelas.TabIndex = 8;
            this.numQtdParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelas
            // 
            this.lblParcelas.Location = new System.Drawing.Point(14, 75);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(137, 17);
            this.lblParcelas.TabIndex = 7;
            this.lblParcelas.Text = "Quantidade de Parcelas:";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(394, 36);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(94, 29);
            this.btnNovaVenda.TabIndex = 6;
            this.btnNovaVenda.Text = "Nova venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnEfetuarPagamento
            // 
            this.btnEfetuarPagamento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEfetuarPagamento.Location = new System.Drawing.Point(240, 36);
            this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
            this.btnEfetuarPagamento.Size = new System.Drawing.Size(146, 29);
            this.btnEfetuarPagamento.TabIndex = 5;
            this.btnEfetuarPagamento.Text = "Efetuar Pagamento";
            this.btnEfetuarPagamento.UseVisualStyleBackColor = true;
            this.btnEfetuarPagamento.Click += new System.EventHandler(this.btnEfetuarPagamento_Click);
            // 
            // numValorOperacao
            // 
            this.numValorOperacao.DecimalPlaces = 2;
            this.numValorOperacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numValorOperacao.Location = new System.Drawing.Point(103, 39);
            this.numValorOperacao.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numValorOperacao.Name = "numValorOperacao";
            this.numValorOperacao.Size = new System.Drawing.Size(129, 29);
            this.numValorOperacao.TabIndex = 4;
            this.numValorOperacao.ThousandsSeparator = true;
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(14, 42);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(82, 17);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor operação:";
            // 
            // btnGerarDocumento
            // 
            this.btnGerarDocumento.Location = new System.Drawing.Point(369, 9);
            this.btnGerarDocumento.Name = "btnGerarDocumento";
            this.btnGerarDocumento.Size = new System.Drawing.Size(120, 22);
            this.btnGerarDocumento.TabIndex = 2;
            this.btnGerarDocumento.Text = "Gerar documento";
            this.btnGerarDocumento.UseVisualStyleBackColor = true;
            this.btnGerarDocumento.Click += new System.EventHandler(this.btnGerarDocumento_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(103, 10);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(258, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Location = new System.Drawing.Point(14, 12);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(69, 17);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento:";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabControl1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(574, 536);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Administrativo";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 530);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNsuAdmin);
            this.tabPage2.Controls.Add(this.txtNsuAdmin);
            this.tabPage2.Controls.Add(this.btnCancelarTransacao);
            this.tabPage2.Controls.Add(this.btnConfirmarTransacao);
            this.tabPage2.Controls.Add(this.btnDesfazerTransacao);
            this.tabPage2.Controls.Add(this.btnAbortar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrativo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNsuAdmin
            // 
            this.lblNsuAdmin.Location = new System.Drawing.Point(21, 24);
            this.lblNsuAdmin.Name = "lblNsuAdmin";
            this.lblNsuAdmin.Size = new System.Drawing.Size(40, 17);
            this.lblNsuAdmin.TabIndex = 0;
            this.lblNsuAdmin.Text = "NSU:";
            // 
            // txtNsuAdmin
            // 
            this.txtNsuAdmin.Location = new System.Drawing.Point(65, 21);
            this.txtNsuAdmin.Name = "txtNsuAdmin";
            this.txtNsuAdmin.Size = new System.Drawing.Size(162, 20);
            this.txtNsuAdmin.TabIndex = 1;
            // 
            // btnCancelarTransacao
            // 
            this.btnCancelarTransacao.Location = new System.Drawing.Point(21, 56);
            this.btnCancelarTransacao.Name = "btnCancelarTransacao";
            this.btnCancelarTransacao.Size = new System.Drawing.Size(206, 31);
            this.btnCancelarTransacao.TabIndex = 2;
            this.btnCancelarTransacao.Text = "Cancelar transação (NSU)";
            this.btnCancelarTransacao.UseVisualStyleBackColor = true;
            this.btnCancelarTransacao.Click += new System.EventHandler(this.btnCancelarTransacao_Click);
            // 
            // btnConfirmarTransacao
            // 
            this.btnConfirmarTransacao.Location = new System.Drawing.Point(21, 98);
            this.btnConfirmarTransacao.Name = "btnConfirmarTransacao";
            this.btnConfirmarTransacao.Size = new System.Drawing.Size(206, 31);
            this.btnConfirmarTransacao.TabIndex = 3;
            this.btnConfirmarTransacao.Text = "Confirmar transação (NSU)";
            this.btnConfirmarTransacao.UseVisualStyleBackColor = true;
            this.btnConfirmarTransacao.Click += new System.EventHandler(this.btnConfirmarTransacao_Click);
            // 
            // btnDesfazerTransacao
            // 
            this.btnDesfazerTransacao.Location = new System.Drawing.Point(21, 140);
            this.btnDesfazerTransacao.Name = "btnDesfazerTransacao";
            this.btnDesfazerTransacao.Size = new System.Drawing.Size(206, 31);
            this.btnDesfazerTransacao.TabIndex = 4;
            this.btnDesfazerTransacao.Text = "Desfazer transação (NSU)";
            this.btnDesfazerTransacao.UseVisualStyleBackColor = true;
            this.btnDesfazerTransacao.Click += new System.EventHandler(this.btnDesfazerTransacao_Click);
            // 
            // btnAbortar
            // 
            this.btnAbortar.Location = new System.Drawing.Point(21, 182);
            this.btnAbortar.Name = "btnAbortar";
            this.btnAbortar.Size = new System.Drawing.Size(206, 31);
            this.btnAbortar.TabIndex = 5;
            this.btnAbortar.Text = "Abortar operação";
            this.btnAbortar.UseVisualStyleBackColor = true;
            this.btnAbortar.Click += new System.EventHandler(this.btnAbortar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridConsultaTransacoes);
            this.tabPage3.Controls.Add(this.pnlConsultaTopo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(560, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Transações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridConsultaTransacoes
            // 
            this.gridConsultaTransacoes.AllowUserToAddRows = false;
            this.gridConsultaTransacoes.AllowUserToDeleteRows = false;
            this.gridConsultaTransacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaTransacoes.Location = new System.Drawing.Point(3, 209);
            this.gridConsultaTransacoes.Name = "gridConsultaTransacoes";
            this.gridConsultaTransacoes.ReadOnly = true;
            this.gridConsultaTransacoes.RowHeadersVisible = false;
            this.gridConsultaTransacoes.Size = new System.Drawing.Size(554, 292);
            this.gridConsultaTransacoes.TabIndex = 1;
            // 
            // pnlConsultaTopo
            // 
            this.pnlConsultaTopo.Controls.Add(this.lblCustomerId);
            this.pnlConsultaTopo.Controls.Add(this.txtCustomerId);
            this.pnlConsultaTopo.Controls.Add(this.btnConsultarStatus);
            this.pnlConsultaTopo.Controls.Add(this.grpFiltrosListagem);
            this.pnlConsultaTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsultaTopo.Location = new System.Drawing.Point(3, 3);
            this.pnlConsultaTopo.Name = "pnlConsultaTopo";
            this.pnlConsultaTopo.Size = new System.Drawing.Size(554, 206);
            this.pnlConsultaTopo.TabIndex = 0;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.Location = new System.Drawing.Point(10, 11);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(75, 17);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "CustomerId:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(88, 8);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // btnConsultarStatus
            // 
            this.btnConsultarStatus.Location = new System.Drawing.Point(300, 6);
            this.btnConsultarStatus.Name = "btnConsultarStatus";
            this.btnConsultarStatus.Size = new System.Drawing.Size(150, 26);
            this.btnConsultarStatus.TabIndex = 2;
            this.btnConsultarStatus.Text = "Consultar status";
            this.btnConsultarStatus.UseVisualStyleBackColor = true;
            this.btnConsultarStatus.Click += new System.EventHandler(this.btnConsultarStatus_Click);
            // 
            // grpFiltrosListagem
            // 
            this.grpFiltrosListagem.Controls.Add(this.lblFiltroNsu);
            this.grpFiltrosListagem.Controls.Add(this.txtFiltroNsu);
            this.grpFiltrosListagem.Controls.Add(this.chkFiltroStatus);
            this.grpFiltrosListagem.Controls.Add(this.cboFiltroStatus);
            this.grpFiltrosListagem.Controls.Add(this.chkFiltroTipo);
            this.grpFiltrosListagem.Controls.Add(this.cboFiltroTipo);
            this.grpFiltrosListagem.Controls.Add(this.lblFiltroDataInicio);
            this.grpFiltrosListagem.Controls.Add(this.dtpFiltroDataInicio);
            this.grpFiltrosListagem.Controls.Add(this.lblFiltroDataFim);
            this.grpFiltrosListagem.Controls.Add(this.dtpFiltroDataFim);
            this.grpFiltrosListagem.Controls.Add(this.lblFiltroLimit);
            this.grpFiltrosListagem.Controls.Add(this.numFiltroLimit);
            this.grpFiltrosListagem.Controls.Add(this.lblFiltroOffset);
            this.grpFiltrosListagem.Controls.Add(this.numFiltroOffset);
            this.grpFiltrosListagem.Controls.Add(this.btnListarTransacoes);
            this.grpFiltrosListagem.Controls.Add(this.lblResultadoListagem);
            this.grpFiltrosListagem.Location = new System.Drawing.Point(10, 38);
            this.grpFiltrosListagem.Name = "grpFiltrosListagem";
            this.grpFiltrosListagem.Size = new System.Drawing.Size(534, 158);
            this.grpFiltrosListagem.TabIndex = 3;
            this.grpFiltrosListagem.TabStop = false;
            this.grpFiltrosListagem.Text = "Filtros (listTransactions)";
            // 
            // lblFiltroNsu
            // 
            this.lblFiltroNsu.Location = new System.Drawing.Point(10, 20);
            this.lblFiltroNsu.Name = "lblFiltroNsu";
            this.lblFiltroNsu.Size = new System.Drawing.Size(35, 17);
            this.lblFiltroNsu.TabIndex = 0;
            this.lblFiltroNsu.Text = "NSU:";
            // 
            // txtFiltroNsu
            // 
            this.txtFiltroNsu.Location = new System.Drawing.Point(48, 17);
            this.txtFiltroNsu.Name = "txtFiltroNsu";
            this.txtFiltroNsu.Size = new System.Drawing.Size(140, 20);
            this.txtFiltroNsu.TabIndex = 1;
            // 
            // chkFiltroStatus
            // 
            this.chkFiltroStatus.Location = new System.Drawing.Point(200, 19);
            this.chkFiltroStatus.Name = "chkFiltroStatus";
            this.chkFiltroStatus.Size = new System.Drawing.Size(60, 20);
            this.chkFiltroStatus.TabIndex = 2;
            this.chkFiltroStatus.Text = "Status:";
            this.chkFiltroStatus.UseVisualStyleBackColor = true;
            // 
            // cboFiltroStatus
            // 
            this.cboFiltroStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroStatus.Location = new System.Drawing.Point(262, 17);
            this.cboFiltroStatus.Name = "cboFiltroStatus";
            this.cboFiltroStatus.Size = new System.Drawing.Size(120, 21);
            this.cboFiltroStatus.TabIndex = 3;
            // 
            // chkFiltroTipo
            // 
            this.chkFiltroTipo.Location = new System.Drawing.Point(10, 47);
            this.chkFiltroTipo.Name = "chkFiltroTipo";
            this.chkFiltroTipo.Size = new System.Drawing.Size(140, 20);
            this.chkFiltroTipo.TabIndex = 4;
            this.chkFiltroTipo.Text = "Tipo da Transação:";
            this.chkFiltroTipo.UseVisualStyleBackColor = true;
            // 
            // cboFiltroTipo
            // 
            this.cboFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroTipo.Location = new System.Drawing.Point(154, 45);
            this.cboFiltroTipo.Name = "cboFiltroTipo";
            this.cboFiltroTipo.Size = new System.Drawing.Size(100, 21);
            this.cboFiltroTipo.TabIndex = 5;
            // 
            // lblFiltroDataInicio
            // 
            this.lblFiltroDataInicio.Location = new System.Drawing.Point(10, 77);
            this.lblFiltroDataInicio.Name = "lblFiltroDataInicio";
            this.lblFiltroDataInicio.Size = new System.Drawing.Size(75, 17);
            this.lblFiltroDataInicio.TabIndex = 6;
            this.lblFiltroDataInicio.Text = "Data início:";
            // 
            // dtpFiltroDataInicio
            // 
            this.dtpFiltroDataInicio.Checked = false;
            this.dtpFiltroDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroDataInicio.Location = new System.Drawing.Point(88, 74);
            this.dtpFiltroDataInicio.Name = "dtpFiltroDataInicio";
            this.dtpFiltroDataInicio.ShowCheckBox = true;
            this.dtpFiltroDataInicio.Size = new System.Drawing.Size(140, 20);
            this.dtpFiltroDataInicio.TabIndex = 7;
            // 
            // lblFiltroDataFim
            // 
            this.lblFiltroDataFim.Location = new System.Drawing.Point(240, 77);
            this.lblFiltroDataFim.Name = "lblFiltroDataFim";
            this.lblFiltroDataFim.Size = new System.Drawing.Size(60, 17);
            this.lblFiltroDataFim.TabIndex = 8;
            this.lblFiltroDataFim.Text = "Data fim:";
            // 
            // dtpFiltroDataFim
            // 
            this.dtpFiltroDataFim.Checked = false;
            this.dtpFiltroDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroDataFim.Location = new System.Drawing.Point(304, 74);
            this.dtpFiltroDataFim.Name = "dtpFiltroDataFim";
            this.dtpFiltroDataFim.ShowCheckBox = true;
            this.dtpFiltroDataFim.Size = new System.Drawing.Size(140, 20);
            this.dtpFiltroDataFim.TabIndex = 9;
            // 
            // lblFiltroLimit
            // 
            this.lblFiltroLimit.Location = new System.Drawing.Point(10, 105);
            this.lblFiltroLimit.Name = "lblFiltroLimit";
            this.lblFiltroLimit.Size = new System.Drawing.Size(40, 17);
            this.lblFiltroLimit.TabIndex = 10;
            this.lblFiltroLimit.Text = "Limit:";
            // 
            // numFiltroLimit
            // 
            this.numFiltroLimit.Location = new System.Drawing.Point(54, 102);
            this.numFiltroLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFiltroLimit.Name = "numFiltroLimit";
            this.numFiltroLimit.Size = new System.Drawing.Size(55, 20);
            this.numFiltroLimit.TabIndex = 11;
            this.numFiltroLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblFiltroOffset
            // 
            this.lblFiltroOffset.Location = new System.Drawing.Point(120, 105);
            this.lblFiltroOffset.Name = "lblFiltroOffset";
            this.lblFiltroOffset.Size = new System.Drawing.Size(45, 17);
            this.lblFiltroOffset.TabIndex = 12;
            this.lblFiltroOffset.Text = "Offset:";
            // 
            // numFiltroOffset
            // 
            this.numFiltroOffset.Location = new System.Drawing.Point(168, 102);
            this.numFiltroOffset.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFiltroOffset.Name = "numFiltroOffset";
            this.numFiltroOffset.Size = new System.Drawing.Size(55, 20);
            this.numFiltroOffset.TabIndex = 13;
            // 
            // btnListarTransacoes
            // 
            this.btnListarTransacoes.Location = new System.Drawing.Point(400, 100);
            this.btnListarTransacoes.Name = "btnListarTransacoes";
            this.btnListarTransacoes.Size = new System.Drawing.Size(130, 26);
            this.btnListarTransacoes.TabIndex = 12;
            this.btnListarTransacoes.Text = "Listar transações";
            this.btnListarTransacoes.UseVisualStyleBackColor = true;
            this.btnListarTransacoes.Click += new System.EventHandler(this.btnListarTransacoes_Click);
            // 
            // lblResultadoListagem
            // 
            this.lblResultadoListagem.Location = new System.Drawing.Point(10, 130);
            this.lblResultadoListagem.Name = "lblResultadoListagem";
            this.lblResultadoListagem.Size = new System.Drawing.Size(510, 17);
            this.lblResultadoListagem.TabIndex = 14;
            // 
            // tabUtilitarios
            // 
            this.tabUtilitarios.Controls.Add(this.grpColeta);
            this.tabUtilitarios.Controls.Add(this.grpMensagem);
            this.tabUtilitarios.Controls.Add(this.grpPesquisa);
            this.tabUtilitarios.Location = new System.Drawing.Point(4, 22);
            this.tabUtilitarios.Name = "tabUtilitarios";
            this.tabUtilitarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilitarios.Size = new System.Drawing.Size(574, 536);
            this.tabUtilitarios.TabIndex = 2;
            this.tabUtilitarios.Text = "Utilitários";
            this.tabUtilitarios.UseVisualStyleBackColor = true;
            // 
            // grpColeta
            // 
            this.grpColeta.Controls.Add(this.lblColetaTitulo);
            this.grpColeta.Controls.Add(this.txtColetaTitulo);
            this.grpColeta.Controls.Add(this.lblColetaTipoEntrada);
            this.grpColeta.Controls.Add(this.cboColetaTipoEntrada);
            this.grpColeta.Controls.Add(this.lblColetaMascara);
            this.grpColeta.Controls.Add(this.txtColetaMascara);
            this.grpColeta.Controls.Add(this.btnColetarDados);
            this.grpColeta.Controls.Add(this.lblColetaResultadoTitulo);
            this.grpColeta.Controls.Add(this.txtColetaResultado);
            this.grpColeta.Location = new System.Drawing.Point(8, 8);
            this.grpColeta.Name = "grpColeta";
            this.grpColeta.Size = new System.Drawing.Size(554, 112);
            this.grpColeta.TabIndex = 0;
            this.grpColeta.TabStop = false;
            this.grpColeta.Text = "Coletar dados (collect)";
            // 
            // lblColetaTitulo
            // 
            this.lblColetaTitulo.Location = new System.Drawing.Point(10, 24);
            this.lblColetaTitulo.Name = "lblColetaTitulo";
            this.lblColetaTitulo.Size = new System.Drawing.Size(55, 17);
            this.lblColetaTitulo.TabIndex = 0;
            this.lblColetaTitulo.Text = "Título:";
            // 
            // txtColetaTitulo
            // 
            this.txtColetaTitulo.Location = new System.Drawing.Point(70, 21);
            this.txtColetaTitulo.Name = "txtColetaTitulo";
            this.txtColetaTitulo.Size = new System.Drawing.Size(260, 20);
            this.txtColetaTitulo.TabIndex = 1;
            this.txtColetaTitulo.Text = "Informe o CPF";
            // 
            // lblColetaTipoEntrada
            // 
            this.lblColetaTipoEntrada.Location = new System.Drawing.Point(340, 24);
            this.lblColetaTipoEntrada.Name = "lblColetaTipoEntrada";
            this.lblColetaTipoEntrada.Size = new System.Drawing.Size(40, 17);
            this.lblColetaTipoEntrada.TabIndex = 2;
            this.lblColetaTipoEntrada.Text = "Tipo:";
            // 
            // cboColetaTipoEntrada
            // 
            this.cboColetaTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColetaTipoEntrada.Location = new System.Drawing.Point(384, 21);
            this.cboColetaTipoEntrada.Name = "cboColetaTipoEntrada";
            this.cboColetaTipoEntrada.Size = new System.Drawing.Size(150, 21);
            this.cboColetaTipoEntrada.TabIndex = 3;
            // 
            // lblColetaMascara
            // 
            this.lblColetaMascara.Location = new System.Drawing.Point(10, 53);
            this.lblColetaMascara.Name = "lblColetaMascara";
            this.lblColetaMascara.Size = new System.Drawing.Size(60, 17);
            this.lblColetaMascara.TabIndex = 4;
            this.lblColetaMascara.Text = "Máscara:";
            // 
            // txtColetaMascara
            // 
            this.txtColetaMascara.Location = new System.Drawing.Point(70, 50);
            this.txtColetaMascara.Name = "txtColetaMascara";
            this.txtColetaMascara.Size = new System.Drawing.Size(150, 20);
            this.txtColetaMascara.TabIndex = 5;
            this.txtColetaMascara.Text = "###.###.###-##";
            // 
            // btnColetarDados
            // 
            this.btnColetarDados.Location = new System.Drawing.Point(384, 48);
            this.btnColetarDados.Name = "btnColetarDados";
            this.btnColetarDados.Size = new System.Drawing.Size(150, 26);
            this.btnColetarDados.TabIndex = 6;
            this.btnColetarDados.Text = "Coletar dados";
            this.btnColetarDados.UseVisualStyleBackColor = true;
            this.btnColetarDados.Click += new System.EventHandler(this.btnColetarDados_Click);
            // 
            // lblColetaResultadoTitulo
            // 
            this.lblColetaResultadoTitulo.Location = new System.Drawing.Point(10, 84);
            this.lblColetaResultadoTitulo.Name = "lblColetaResultadoTitulo";
            this.lblColetaResultadoTitulo.Size = new System.Drawing.Size(60, 17);
            this.lblColetaResultadoTitulo.TabIndex = 7;
            this.lblColetaResultadoTitulo.Text = "Resultado:";
            // 
            // txtColetaResultado
            // 
            this.txtColetaResultado.Location = new System.Drawing.Point(70, 81);
            this.txtColetaResultado.Name = "txtColetaResultado";
            this.txtColetaResultado.ReadOnly = true;
            this.txtColetaResultado.Size = new System.Drawing.Size(464, 20);
            this.txtColetaResultado.TabIndex = 8;
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.lblMensagemTipo);
            this.grpMensagem.Controls.Add(this.cboMensagemTipo);
            this.grpMensagem.Controls.Add(this.lblMensagemTimeout);
            this.grpMensagem.Controls.Add(this.numMensagemTimeout);
            this.grpMensagem.Controls.Add(this.lblMensagemTitulo);
            this.grpMensagem.Controls.Add(this.txtMensagemTitulo);
            this.grpMensagem.Controls.Add(this.lblMensagemTexto);
            this.grpMensagem.Controls.Add(this.txtMensagemTexto);
            this.grpMensagem.Controls.Add(this.lblMensagemConfirmar);
            this.grpMensagem.Controls.Add(this.txtMensagemConfirmar);
            this.grpMensagem.Controls.Add(this.lblMensagemCancelar);
            this.grpMensagem.Controls.Add(this.txtMensagemCancelar);
            this.grpMensagem.Controls.Add(this.btnExibirMensagem);
            this.grpMensagem.Controls.Add(this.lblMensagemResultadoTitulo);
            this.grpMensagem.Controls.Add(this.txtMensagemResultado);
            this.grpMensagem.Location = new System.Drawing.Point(8, 128);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(554, 168);
            this.grpMensagem.TabIndex = 1;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Exibir mensagem (message)";
            // 
            // lblMensagemTipo
            // 
            this.lblMensagemTipo.Location = new System.Drawing.Point(10, 24);
            this.lblMensagemTipo.Name = "lblMensagemTipo";
            this.lblMensagemTipo.Size = new System.Drawing.Size(40, 17);
            this.lblMensagemTipo.TabIndex = 0;
            this.lblMensagemTipo.Text = "Tipo:";
            // 
            // cboMensagemTipo
            // 
            this.cboMensagemTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMensagemTipo.Location = new System.Drawing.Point(54, 21);
            this.cboMensagemTipo.Name = "cboMensagemTipo";
            this.cboMensagemTipo.Size = new System.Drawing.Size(100, 21);
            this.cboMensagemTipo.TabIndex = 1;
            // 
            // lblMensagemTimeout
            // 
            this.lblMensagemTimeout.Location = new System.Drawing.Point(340, 24);
            this.lblMensagemTimeout.Name = "lblMensagemTimeout";
            this.lblMensagemTimeout.Size = new System.Drawing.Size(90, 17);
            this.lblMensagemTimeout.TabIndex = 2;
            this.lblMensagemTimeout.Text = "Timeout (ms):";
            // 
            // numMensagemTimeout
            // 
            this.numMensagemTimeout.Location = new System.Drawing.Point(434, 21);
            this.numMensagemTimeout.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numMensagemTimeout.Name = "numMensagemTimeout";
            this.numMensagemTimeout.Size = new System.Drawing.Size(100, 20);
            this.numMensagemTimeout.TabIndex = 3;
            this.numMensagemTimeout.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // lblMensagemTitulo
            // 
            this.lblMensagemTitulo.Location = new System.Drawing.Point(10, 52);
            this.lblMensagemTitulo.Name = "lblMensagemTitulo";
            this.lblMensagemTitulo.Size = new System.Drawing.Size(55, 17);
            this.lblMensagemTitulo.TabIndex = 4;
            this.lblMensagemTitulo.Text = "Título:";
            // 
            // txtMensagemTitulo
            // 
            this.txtMensagemTitulo.Location = new System.Drawing.Point(70, 49);
            this.txtMensagemTitulo.Name = "txtMensagemTitulo";
            this.txtMensagemTitulo.Size = new System.Drawing.Size(464, 20);
            this.txtMensagemTitulo.TabIndex = 5;
            this.txtMensagemTitulo.Text = "Confirmar operação?";
            // 
            // lblMensagemTexto
            // 
            this.lblMensagemTexto.Location = new System.Drawing.Point(10, 78);
            this.lblMensagemTexto.Name = "lblMensagemTexto";
            this.lblMensagemTexto.Size = new System.Drawing.Size(70, 17);
            this.lblMensagemTexto.TabIndex = 6;
            this.lblMensagemTexto.Text = "Mensagem:";
            // 
            // txtMensagemTexto
            // 
            this.txtMensagemTexto.Location = new System.Drawing.Point(84, 75);
            this.txtMensagemTexto.Name = "txtMensagemTexto";
            this.txtMensagemTexto.Size = new System.Drawing.Size(450, 20);
            this.txtMensagemTexto.TabIndex = 7;
            this.txtMensagemTexto.Text = "Deseja continuar?";
            // 
            // lblMensagemConfirmar
            // 
            this.lblMensagemConfirmar.Location = new System.Drawing.Point(10, 104);
            this.lblMensagemConfirmar.Name = "lblMensagemConfirmar";
            this.lblMensagemConfirmar.Size = new System.Drawing.Size(70, 17);
            this.lblMensagemConfirmar.TabIndex = 8;
            this.lblMensagemConfirmar.Text = "Confirmar:";
            // 
            // txtMensagemConfirmar
            // 
            this.txtMensagemConfirmar.Location = new System.Drawing.Point(84, 101);
            this.txtMensagemConfirmar.Name = "txtMensagemConfirmar";
            this.txtMensagemConfirmar.Size = new System.Drawing.Size(180, 20);
            this.txtMensagemConfirmar.TabIndex = 9;
            this.txtMensagemConfirmar.Text = "Confirmar";
            // 
            // lblMensagemCancelar
            // 
            this.lblMensagemCancelar.Location = new System.Drawing.Point(280, 104);
            this.lblMensagemCancelar.Name = "lblMensagemCancelar";
            this.lblMensagemCancelar.Size = new System.Drawing.Size(60, 17);
            this.lblMensagemCancelar.TabIndex = 10;
            this.lblMensagemCancelar.Text = "Cancelar:";
            // 
            // txtMensagemCancelar
            // 
            this.txtMensagemCancelar.Location = new System.Drawing.Point(344, 101);
            this.txtMensagemCancelar.Name = "txtMensagemCancelar";
            this.txtMensagemCancelar.Size = new System.Drawing.Size(180, 20);
            this.txtMensagemCancelar.TabIndex = 11;
            this.txtMensagemCancelar.Text = "Cancelar";
            // 
            // btnExibirMensagem
            // 
            this.btnExibirMensagem.Location = new System.Drawing.Point(10, 130);
            this.btnExibirMensagem.Name = "btnExibirMensagem";
            this.btnExibirMensagem.Size = new System.Drawing.Size(150, 26);
            this.btnExibirMensagem.TabIndex = 12;
            this.btnExibirMensagem.Text = "Exibir mensagem";
            this.btnExibirMensagem.UseVisualStyleBackColor = true;
            this.btnExibirMensagem.Click += new System.EventHandler(this.btnExibirMensagem_Click);
            // 
            // lblMensagemResultadoTitulo
            // 
            this.lblMensagemResultadoTitulo.Location = new System.Drawing.Point(180, 137);
            this.lblMensagemResultadoTitulo.Name = "lblMensagemResultadoTitulo";
            this.lblMensagemResultadoTitulo.Size = new System.Drawing.Size(64, 17);
            this.lblMensagemResultadoTitulo.TabIndex = 13;
            this.lblMensagemResultadoTitulo.Text = "Resultado:";
            // 
            // txtMensagemResultado
            // 
            this.txtMensagemResultado.Location = new System.Drawing.Point(250, 134);
            this.txtMensagemResultado.Name = "txtMensagemResultado";
            this.txtMensagemResultado.ReadOnly = true;
            this.txtMensagemResultado.Size = new System.Drawing.Size(284, 20);
            this.txtMensagemResultado.TabIndex = 14;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.lblPesquisaTitulo);
            this.grpPesquisa.Controls.Add(this.txtPesquisaTitulo);
            this.grpPesquisa.Controls.Add(this.lblPesquisaTipo);
            this.grpPesquisa.Controls.Add(this.cboPesquisaTipo);
            this.grpPesquisa.Controls.Add(this.lblPesquisaPergunta);
            this.grpPesquisa.Controls.Add(this.txtPesquisaPergunta);
            this.grpPesquisa.Controls.Add(this.lblPesquisaScaleMin);
            this.grpPesquisa.Controls.Add(this.numPesquisaScaleMin);
            this.grpPesquisa.Controls.Add(this.lblPesquisaScaleMax);
            this.grpPesquisa.Controls.Add(this.numPesquisaScaleMax);
            this.grpPesquisa.Controls.Add(this.btnPesquisaSatisfacao);
            this.grpPesquisa.Controls.Add(this.lblPesquisaResultadoTitulo);
            this.grpPesquisa.Controls.Add(this.txtPesquisaResultado);
            this.grpPesquisa.Location = new System.Drawing.Point(8, 304);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(554, 140);
            this.grpPesquisa.TabIndex = 2;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa de satisfação (survey)";
            // 
            // lblPesquisaTitulo
            // 
            this.lblPesquisaTitulo.Location = new System.Drawing.Point(10, 24);
            this.lblPesquisaTitulo.Name = "lblPesquisaTitulo";
            this.lblPesquisaTitulo.Size = new System.Drawing.Size(55, 17);
            this.lblPesquisaTitulo.TabIndex = 0;
            this.lblPesquisaTitulo.Text = "Título:";
            // 
            // txtPesquisaTitulo
            // 
            this.txtPesquisaTitulo.Location = new System.Drawing.Point(70, 21);
            this.txtPesquisaTitulo.Name = "txtPesquisaTitulo";
            this.txtPesquisaTitulo.Size = new System.Drawing.Size(260, 20);
            this.txtPesquisaTitulo.TabIndex = 1;
            this.txtPesquisaTitulo.Text = "Pesquisa de satisfação";
            // 
            // lblPesquisaTipo
            // 
            this.lblPesquisaTipo.Location = new System.Drawing.Point(340, 24);
            this.lblPesquisaTipo.Name = "lblPesquisaTipo";
            this.lblPesquisaTipo.Size = new System.Drawing.Size(40, 17);
            this.lblPesquisaTipo.TabIndex = 2;
            this.lblPesquisaTipo.Text = "Tipo:";
            // 
            // cboPesquisaTipo
            // 
            this.cboPesquisaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaTipo.Location = new System.Drawing.Point(384, 21);
            this.cboPesquisaTipo.Name = "cboPesquisaTipo";
            this.cboPesquisaTipo.Size = new System.Drawing.Size(150, 21);
            this.cboPesquisaTipo.TabIndex = 3;
            // 
            // lblPesquisaPergunta
            // 
            this.lblPesquisaPergunta.Location = new System.Drawing.Point(10, 52);
            this.lblPesquisaPergunta.Name = "lblPesquisaPergunta";
            this.lblPesquisaPergunta.Size = new System.Drawing.Size(70, 17);
            this.lblPesquisaPergunta.TabIndex = 4;
            this.lblPesquisaPergunta.Text = "Pergunta:";
            // 
            // txtPesquisaPergunta
            // 
            this.txtPesquisaPergunta.Location = new System.Drawing.Point(84, 49);
            this.txtPesquisaPergunta.Name = "txtPesquisaPergunta";
            this.txtPesquisaPergunta.Size = new System.Drawing.Size(450, 20);
            this.txtPesquisaPergunta.TabIndex = 5;
            this.txtPesquisaPergunta.Text = "Como você avalia sua experiência?";
            // 
            // lblPesquisaScaleMin
            // 
            this.lblPesquisaScaleMin.Location = new System.Drawing.Point(10, 80);
            this.lblPesquisaScaleMin.Name = "lblPesquisaScaleMin";
            this.lblPesquisaScaleMin.Size = new System.Drawing.Size(40, 17);
            this.lblPesquisaScaleMin.TabIndex = 6;
            this.lblPesquisaScaleMin.Text = "Min:";
            // 
            // numPesquisaScaleMin
            // 
            this.numPesquisaScaleMin.Location = new System.Drawing.Point(54, 77);
            this.numPesquisaScaleMin.Name = "numPesquisaScaleMin";
            this.numPesquisaScaleMin.Size = new System.Drawing.Size(50, 20);
            this.numPesquisaScaleMin.TabIndex = 7;
            // 
            // lblPesquisaScaleMax
            // 
            this.lblPesquisaScaleMax.Location = new System.Drawing.Point(112, 80);
            this.lblPesquisaScaleMax.Name = "lblPesquisaScaleMax";
            this.lblPesquisaScaleMax.Size = new System.Drawing.Size(40, 17);
            this.lblPesquisaScaleMax.TabIndex = 8;
            this.lblPesquisaScaleMax.Text = "Max:";
            // 
            // numPesquisaScaleMax
            // 
            this.numPesquisaScaleMax.Location = new System.Drawing.Point(156, 77);
            this.numPesquisaScaleMax.Name = "numPesquisaScaleMax";
            this.numPesquisaScaleMax.Size = new System.Drawing.Size(50, 20);
            this.numPesquisaScaleMax.TabIndex = 9;
            this.numPesquisaScaleMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnPesquisaSatisfacao
            // 
            this.btnPesquisaSatisfacao.Location = new System.Drawing.Point(230, 75);
            this.btnPesquisaSatisfacao.Name = "btnPesquisaSatisfacao";
            this.btnPesquisaSatisfacao.Size = new System.Drawing.Size(180, 26);
            this.btnPesquisaSatisfacao.TabIndex = 10;
            this.btnPesquisaSatisfacao.Text = "Pesquisa de satisfação";
            this.btnPesquisaSatisfacao.UseVisualStyleBackColor = true;
            this.btnPesquisaSatisfacao.Click += new System.EventHandler(this.btnPesquisaSatisfacao_Click);
            // 
            // lblPesquisaResultadoTitulo
            // 
            this.lblPesquisaResultadoTitulo.Location = new System.Drawing.Point(10, 110);
            this.lblPesquisaResultadoTitulo.Name = "lblPesquisaResultadoTitulo";
            this.lblPesquisaResultadoTitulo.Size = new System.Drawing.Size(70, 17);
            this.lblPesquisaResultadoTitulo.TabIndex = 11;
            this.lblPesquisaResultadoTitulo.Text = "Resultado:";
            // 
            // txtPesquisaResultado
            // 
            this.txtPesquisaResultado.Location = new System.Drawing.Point(84, 107);
            this.txtPesquisaResultado.Name = "txtPesquisaResultado";
            this.txtPesquisaResultado.ReadOnly = true;
            this.txtPesquisaResultado.Size = new System.Drawing.Size(450, 20);
            this.txtPesquisaResultado.TabIndex = 12;
            // 
            // splitDireita
            // 
            this.splitDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDireita.Location = new System.Drawing.Point(0, 0);
            this.splitDireita.Name = "splitDireita";
            this.splitDireita.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDireita.Panel1
            // 
            this.splitDireita.Panel1.Controls.Add(this.grpComprovante);
            // 
            // splitDireita.Panel2
            // 
            this.splitDireita.Panel2.Controls.Add(this.grpLog);
            this.splitDireita.Size = new System.Drawing.Size(331, 573);
            this.splitDireita.SplitterDistance = 292;
            this.splitDireita.SplitterWidth = 3;
            this.splitDireita.TabIndex = 0;
            // 
            // grpComprovante
            // 
            this.grpComprovante.Controls.Add(this.txtComprovante);
            this.grpComprovante.Controls.Add(this.btnLimparComprovante);
            this.grpComprovante.Controls.Add(this.btnImprimir);
            this.grpComprovante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpComprovante.Location = new System.Drawing.Point(0, 0);
            this.grpComprovante.Name = "grpComprovante";
            this.grpComprovante.Padding = new System.Windows.Forms.Padding(7);
            this.grpComprovante.Size = new System.Drawing.Size(331, 292);
            this.grpComprovante.TabIndex = 0;
            this.grpComprovante.TabStop = false;
            this.grpComprovante.Text = "Comprovante (preview)";
            // 
            // txtComprovante
            // 
            this.txtComprovante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprovante.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtComprovante.Location = new System.Drawing.Point(10, 19);
            this.txtComprovante.Multiline = true;
            this.txtComprovante.Name = "txtComprovante";
            this.txtComprovante.ReadOnly = true;
            this.txtComprovante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComprovante.Size = new System.Drawing.Size(311, 239);
            this.txtComprovante.TabIndex = 0;
            // 
            // btnLimparComprovante
            // 
            this.btnLimparComprovante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparComprovante.Location = new System.Drawing.Point(10, 261);
            this.btnLimparComprovante.Name = "btnLimparComprovante";
            this.btnLimparComprovante.Size = new System.Drawing.Size(69, 24);
            this.btnLimparComprovante.TabIndex = 1;
            this.btnLimparComprovante.Text = "Limpar";
            this.btnLimparComprovante.UseVisualStyleBackColor = true;
            this.btnLimparComprovante.Click += new System.EventHandler(this.btnLimparComprovante_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(253, 261);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 24);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Controls.Add(this.btnLimparLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(0, 0);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(7);
            this.grpLog.Size = new System.Drawing.Size(331, 278);
            this.grpLog.TabIndex = 0;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log de execução";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtLog.Location = new System.Drawing.Point(10, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(311, 225);
            this.txtLog.TabIndex = 0;
            // 
            // btnLimparLog
            // 
            this.btnLimparLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparLog.Location = new System.Drawing.Point(10, 247);
            this.btnLimparLog.Name = "btnLimparLog";
            this.btnLimparLog.Size = new System.Drawing.Size(77, 24);
            this.btnLimparLog.TabIndex = 1;
            this.btnLimparLog.Text = "Limpar log";
            this.btnLimparLog.UseVisualStyleBackColor = true;
            this.btnLimparLog.Click += new System.EventHandler(this.btnLimparLog_Click);
            // 
            // FrmPdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 628);
            this.Controls.Add(this.splitPrincipal);
            this.Controls.Add(this.pnlTopo);
            this.MinimumSize = new System.Drawing.Size(859, 560);
            this.Name = "FrmPdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACBr DirectPIN - Demo";
            this.Load += new System.EventHandler(this.FrmPdv_Load);
            this.Shown += new System.EventHandler(this.FrmPdv_Shown);
            this.pnlTopo.ResumeLayout(false);
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            this.tabOperacao.ResumeLayout(false);
            this.tabVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacoes)).EndInit();
            this.pnlVendaRodape.ResumeLayout(false);
            this.tblTotais.ResumeLayout(false);
            this.pnlVendaTopo.ResumeLayout(false);
            this.pnlVendaTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorOperacao)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTransacoes)).EndInit();
            this.pnlConsultaTopo.ResumeLayout(false);
            this.pnlConsultaTopo.PerformLayout();
            this.grpFiltrosListagem.ResumeLayout(false);
            this.grpFiltrosListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltroLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltroOffset)).EndInit();
            this.tabUtilitarios.ResumeLayout(false);
            this.grpColeta.ResumeLayout(false);
            this.grpColeta.PerformLayout();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMensagemTimeout)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisaScaleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisaScaleMax)).EndInit();
            this.splitDireita.Panel1.ResumeLayout(false);
            this.splitDireita.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDireita)).EndInit();
            this.splitDireita.ResumeLayout(false);
            this.grpComprovante.ResumeLayout(false);
            this.grpComprovante.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
