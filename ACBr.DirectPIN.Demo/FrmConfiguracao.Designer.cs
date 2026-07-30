namespace ACBr.DirectPIN.Demo
{
    partial class FrmConfiguracao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabConfiguracao;
        private System.Windows.Forms.TabPage tabDirectPIN;
        private System.Windows.Forms.TabPage tabImpressora;

        private System.Windows.Forms.Label lblPortaCom;
        private System.Windows.Forms.ComboBox cboPortaCom;
        private System.Windows.Forms.Button btnAtualizarPortas;
        private System.Windows.Forms.Label lblEntityIdentifier;
        private System.Windows.Forms.TextBox txtEntityIdentifier;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label lblTimeoutAckNak;
        private System.Windows.Forms.NumericUpDown numTimeoutAckNak;
        private System.Windows.Forms.Label lblTimeoutOperacao;
        private System.Windows.Forms.NumericUpDown numTimeoutOperacao;
        private System.Windows.Forms.CheckBox chkConfirmarAutomaticamente;

        private System.Windows.Forms.Label lblModeloImpressora;
        private System.Windows.Forms.ComboBox cboModeloImpressora;
        private System.Windows.Forms.Button btnAtivarImpressora;
        private System.Windows.Forms.Label lblPortaImpressora;
        private System.Windows.Forms.ComboBox cboPortaImpressora;
        private System.Windows.Forms.Button btnAtualizarPortasImpressora;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.NumericUpDown numColunas;
        private System.Windows.Forms.Label lblEspacos;
        private System.Windows.Forms.NumericUpDown numEspacos;
        private System.Windows.Forms.Label lblBuffer;
        private System.Windows.Forms.NumericUpDown numBuffer;
        private System.Windows.Forms.Label lblLinhasPular;
        private System.Windows.Forms.NumericUpDown numLinhasPular;
        private System.Windows.Forms.CheckBox chkCortarPapel;
        private System.Windows.Forms.CheckBox chkTraduzirTags;
        private System.Windows.Forms.CheckBox chkIgnorarTags;
        private System.Windows.Forms.CheckBox chkControlePorta;
        private System.Windows.Forms.Label lblArqLog;
        private System.Windows.Forms.TextBox txtArqLog;
        private System.Windows.Forms.Button btnArqLog;
        private System.Windows.Forms.Label lblPaginaCodigo;
        private System.Windows.Forms.ComboBox cboPaginaCodigo;
        private System.Windows.Forms.CheckBox chkImprimirAutomaticamente;

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnTestarImpressora;
        private System.Windows.Forms.Button btnFechar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabConfiguracao = new System.Windows.Forms.TabControl();
            this.tabDirectPIN = new System.Windows.Forms.TabPage();
            this.chkConfirmarAutomaticamente = new System.Windows.Forms.CheckBox();
            this.numTimeoutOperacao = new System.Windows.Forms.NumericUpDown();
            this.lblTimeoutOperacao = new System.Windows.Forms.Label();
            this.numTimeoutAckNak = new System.Windows.Forms.NumericUpDown();
            this.lblTimeoutAckNak = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.txtEntityIdentifier = new System.Windows.Forms.TextBox();
            this.lblEntityIdentifier = new System.Windows.Forms.Label();
            this.btnAtualizarPortas = new System.Windows.Forms.Button();
            this.cboPortaCom = new System.Windows.Forms.ComboBox();
            this.lblPortaCom = new System.Windows.Forms.Label();
            this.tabImpressora = new System.Windows.Forms.TabPage();
            this.chkImprimirAutomaticamente = new System.Windows.Forms.CheckBox();
            this.cboPaginaCodigo = new System.Windows.Forms.ComboBox();
            this.lblPaginaCodigo = new System.Windows.Forms.Label();
            this.btnArqLog = new System.Windows.Forms.Button();
            this.txtArqLog = new System.Windows.Forms.TextBox();
            this.lblArqLog = new System.Windows.Forms.Label();
            this.chkControlePorta = new System.Windows.Forms.CheckBox();
            this.chkIgnorarTags = new System.Windows.Forms.CheckBox();
            this.chkTraduzirTags = new System.Windows.Forms.CheckBox();
            this.chkCortarPapel = new System.Windows.Forms.CheckBox();
            this.numLinhasPular = new System.Windows.Forms.NumericUpDown();
            this.lblLinhasPular = new System.Windows.Forms.Label();
            this.numBuffer = new System.Windows.Forms.NumericUpDown();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.numEspacos = new System.Windows.Forms.NumericUpDown();
            this.lblEspacos = new System.Windows.Forms.Label();
            this.numColunas = new System.Windows.Forms.NumericUpDown();
            this.lblColunas = new System.Windows.Forms.Label();
            this.btnAtualizarPortasImpressora = new System.Windows.Forms.Button();
            this.cboPortaImpressora = new System.Windows.Forms.ComboBox();
            this.lblPortaImpressora = new System.Windows.Forms.Label();
            this.btnAtivarImpressora = new System.Windows.Forms.Button();
            this.cboModeloImpressora = new System.Windows.Forms.ComboBox();
            this.lblModeloImpressora = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnTestarImpressora = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabConfiguracao.SuspendLayout();
            this.tabDirectPIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutAckNak)).BeginInit();
            this.tabImpressora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhasPular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(14, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(377, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuração - ACBr DirectPIN Demo";
            // 
            // tabConfiguracao
            // 
            this.tabConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConfiguracao.Controls.Add(this.tabDirectPIN);
            this.tabConfiguracao.Controls.Add(this.tabImpressora);
            this.tabConfiguracao.Location = new System.Drawing.Point(14, 49);
            this.tabConfiguracao.Name = "tabConfiguracao";
            this.tabConfiguracao.SelectedIndex = 0;
            this.tabConfiguracao.Size = new System.Drawing.Size(378, 362);
            this.tabConfiguracao.TabIndex = 1;
            // 
            // tabDirectPIN
            // 
            this.tabDirectPIN.Controls.Add(this.chkConfirmarAutomaticamente);
            this.tabDirectPIN.Controls.Add(this.numTimeoutOperacao);
            this.tabDirectPIN.Controls.Add(this.lblTimeoutOperacao);
            this.tabDirectPIN.Controls.Add(this.numTimeoutAckNak);
            this.tabDirectPIN.Controls.Add(this.lblTimeoutAckNak);
            this.tabDirectPIN.Controls.Add(this.lblBaudRate);
            this.tabDirectPIN.Controls.Add(this.cboBaudRate);
            this.tabDirectPIN.Controls.Add(this.lblDataBits);
            this.tabDirectPIN.Controls.Add(this.cboDataBits);
            this.tabDirectPIN.Controls.Add(this.lblParity);
            this.tabDirectPIN.Controls.Add(this.cboParity);
            this.tabDirectPIN.Controls.Add(this.lblStopBits);
            this.tabDirectPIN.Controls.Add(this.cboStopBits);
            this.tabDirectPIN.Controls.Add(this.txtEntityIdentifier);
            this.tabDirectPIN.Controls.Add(this.lblEntityIdentifier);
            this.tabDirectPIN.Controls.Add(this.btnAtualizarPortas);
            this.tabDirectPIN.Controls.Add(this.cboPortaCom);
            this.tabDirectPIN.Controls.Add(this.lblPortaCom);
            this.tabDirectPIN.Location = new System.Drawing.Point(4, 22);
            this.tabDirectPIN.Name = "tabDirectPIN";
            this.tabDirectPIN.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectPIN.Size = new System.Drawing.Size(370, 336);
            this.tabDirectPIN.TabIndex = 0;
            this.tabDirectPIN.Text = "Configuração DirectPIN";
            this.tabDirectPIN.UseVisualStyleBackColor = true;
            // 
            // chkConfirmarAutomaticamente
            // 
            this.chkConfirmarAutomaticamente.Checked = true;
            this.chkConfirmarAutomaticamente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfirmarAutomaticamente.Location = new System.Drawing.Point(10, 191);
            this.chkConfirmarAutomaticamente.Name = "chkConfirmarAutomaticamente";
            this.chkConfirmarAutomaticamente.Size = new System.Drawing.Size(257, 21);
            this.chkConfirmarAutomaticamente.TabIndex = 10;
            this.chkConfirmarAutomaticamente.Text = "Confirmar transações automaticamente";
            this.chkConfirmarAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // numTimeoutOperacao
            // 
            this.numTimeoutOperacao.Location = new System.Drawing.Point(151, 159);
            this.numTimeoutOperacao.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numTimeoutOperacao.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numTimeoutOperacao.Name = "numTimeoutOperacao";
            this.numTimeoutOperacao.Size = new System.Drawing.Size(86, 20);
            this.numTimeoutOperacao.TabIndex = 9;
            this.numTimeoutOperacao.Value = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            // 
            // lblTimeoutOperacao
            // 
            this.lblTimeoutOperacao.Location = new System.Drawing.Point(10, 161);
            this.lblTimeoutOperacao.Name = "lblTimeoutOperacao";
            this.lblTimeoutOperacao.Size = new System.Drawing.Size(137, 17);
            this.lblTimeoutOperacao.TabIndex = 8;
            this.lblTimeoutOperacao.Text = "Timeout operação (ms):";
            // 
            // numTimeoutAckNak
            // 
            this.numTimeoutAckNak.Location = new System.Drawing.Point(151, 132);
            this.numTimeoutAckNak.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numTimeoutAckNak.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeoutAckNak.Name = "numTimeoutAckNak";
            this.numTimeoutAckNak.Size = new System.Drawing.Size(86, 20);
            this.numTimeoutAckNak.TabIndex = 7;
            this.numTimeoutAckNak.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblTimeoutAckNak
            // 
            this.lblTimeoutAckNak.Location = new System.Drawing.Point(10, 133);
            this.lblTimeoutAckNak.Name = "lblTimeoutAckNak";
            this.lblTimeoutAckNak.Size = new System.Drawing.Size(137, 17);
            this.lblTimeoutAckNak.TabIndex = 6;
            this.lblTimeoutAckNak.Text = "Timeout ACK/NAK (ms):";
            //
            // lblBaudRate
            //
            this.lblBaudRate.Location = new System.Drawing.Point(10, 73);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(70, 17);
            this.lblBaudRate.TabIndex = 5;
            this.lblBaudRate.Text = "BaudRate:";
            //
            // cboBaudRate
            //
            this.cboBaudRate.Location = new System.Drawing.Point(10, 90);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(80, 21);
            this.cboBaudRate.TabIndex = 100;
            //
            // lblDataBits
            //
            this.lblDataBits.Location = new System.Drawing.Point(96, 73);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(65, 17);
            this.lblDataBits.TabIndex = 101;
            this.lblDataBits.Text = "DataBits:";
            //
            // cboDataBits
            //
            this.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBits.Location = new System.Drawing.Point(96, 90);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(60, 21);
            this.cboDataBits.TabIndex = 102;
            //
            // lblParity
            //
            this.lblParity.Location = new System.Drawing.Point(162, 73);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(50, 17);
            this.lblParity.TabIndex = 103;
            this.lblParity.Text = "Parity:";
            //
            // cboParity
            //
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.Location = new System.Drawing.Point(162, 90);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(85, 21);
            this.cboParity.TabIndex = 104;
            //
            // lblStopBits
            //
            this.lblStopBits.Location = new System.Drawing.Point(253, 73);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(65, 17);
            this.lblStopBits.TabIndex = 105;
            this.lblStopBits.Text = "StopBits:";
            //
            // cboStopBits
            //
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.Location = new System.Drawing.Point(253, 90);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(80, 21);
            this.cboStopBits.TabIndex = 106;
            //
            // txtEntityIdentifier
            // 
            this.txtEntityIdentifier.Location = new System.Drawing.Point(151, 41);
            this.txtEntityIdentifier.Name = "txtEntityIdentifier";
            this.txtEntityIdentifier.Size = new System.Drawing.Size(210, 20);
            this.txtEntityIdentifier.TabIndex = 4;
            // 
            // lblEntityIdentifier
            // 
            this.lblEntityIdentifier.Location = new System.Drawing.Point(10, 43);
            this.lblEntityIdentifier.Name = "lblEntityIdentifier";
            this.lblEntityIdentifier.Size = new System.Drawing.Size(137, 17);
            this.lblEntityIdentifier.TabIndex = 3;
            this.lblEntityIdentifier.Text = "Identificador da Entidade:";
            // 
            // btnAtualizarPortas
            // 
            this.btnAtualizarPortas.Location = new System.Drawing.Point(278, 10);
            this.btnAtualizarPortas.Name = "btnAtualizarPortas";
            this.btnAtualizarPortas.Size = new System.Drawing.Size(82, 22);
            this.btnAtualizarPortas.TabIndex = 2;
            this.btnAtualizarPortas.Text = "Atualizar";
            this.btnAtualizarPortas.UseVisualStyleBackColor = true;
            this.btnAtualizarPortas.Click += new System.EventHandler(this.btnAtualizarPortas_Click);
            // 
            // cboPortaCom
            // 
            this.cboPortaCom.Location = new System.Drawing.Point(151, 11);
            this.cboPortaCom.Name = "cboPortaCom";
            this.cboPortaCom.Size = new System.Drawing.Size(121, 21);
            this.cboPortaCom.TabIndex = 1;
            // 
            // lblPortaCom
            // 
            this.lblPortaCom.Location = new System.Drawing.Point(10, 14);
            this.lblPortaCom.Name = "lblPortaCom";
            this.lblPortaCom.Size = new System.Drawing.Size(77, 17);
            this.lblPortaCom.TabIndex = 0;
            this.lblPortaCom.Text = "Porta COM:";
            // 
            // tabImpressora
            // 
            this.tabImpressora.Controls.Add(this.chkImprimirAutomaticamente);
            this.tabImpressora.Controls.Add(this.cboPaginaCodigo);
            this.tabImpressora.Controls.Add(this.lblPaginaCodigo);
            this.tabImpressora.Controls.Add(this.btnArqLog);
            this.tabImpressora.Controls.Add(this.txtArqLog);
            this.tabImpressora.Controls.Add(this.lblArqLog);
            this.tabImpressora.Controls.Add(this.chkControlePorta);
            this.tabImpressora.Controls.Add(this.chkIgnorarTags);
            this.tabImpressora.Controls.Add(this.chkTraduzirTags);
            this.tabImpressora.Controls.Add(this.chkCortarPapel);
            this.tabImpressora.Controls.Add(this.numLinhasPular);
            this.tabImpressora.Controls.Add(this.lblLinhasPular);
            this.tabImpressora.Controls.Add(this.numBuffer);
            this.tabImpressora.Controls.Add(this.lblBuffer);
            this.tabImpressora.Controls.Add(this.numEspacos);
            this.tabImpressora.Controls.Add(this.lblEspacos);
            this.tabImpressora.Controls.Add(this.numColunas);
            this.tabImpressora.Controls.Add(this.lblColunas);
            this.tabImpressora.Controls.Add(this.btnAtualizarPortasImpressora);
            this.tabImpressora.Controls.Add(this.cboPortaImpressora);
            this.tabImpressora.Controls.Add(this.lblPortaImpressora);
            this.tabImpressora.Controls.Add(this.btnAtivarImpressora);
            this.tabImpressora.Controls.Add(this.cboModeloImpressora);
            this.tabImpressora.Controls.Add(this.lblModeloImpressora);
            this.tabImpressora.Location = new System.Drawing.Point(4, 22);
            this.tabImpressora.Name = "tabImpressora";
            this.tabImpressora.Padding = new System.Windows.Forms.Padding(3);
            this.tabImpressora.Size = new System.Drawing.Size(370, 336);
            this.tabImpressora.TabIndex = 1;
            this.tabImpressora.Text = "Configuração Impressora";
            this.tabImpressora.UseVisualStyleBackColor = true;
            // 
            // chkImprimirAutomaticamente
            // 
            this.chkImprimirAutomaticamente.Location = new System.Drawing.Point(10, 210);
            this.chkImprimirAutomaticamente.Name = "chkImprimirAutomaticamente";
            this.chkImprimirAutomaticamente.Size = new System.Drawing.Size(343, 21);
            this.chkImprimirAutomaticamente.TabIndex = 23;
            this.chkImprimirAutomaticamente.Text = "Enviar comprovante para a impressora automaticamente";
            this.chkImprimirAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // cboPaginaCodigo
            // 
            this.cboPaginaCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaginaCodigo.Location = new System.Drawing.Point(86, 178);
            this.cboPaginaCodigo.Name = "cboPaginaCodigo";
            this.cboPaginaCodigo.Size = new System.Drawing.Size(138, 21);
            this.cboPaginaCodigo.TabIndex = 22;
            // 
            // lblPaginaCodigo
            // 
            this.lblPaginaCodigo.Location = new System.Drawing.Point(10, 180);
            this.lblPaginaCodigo.Name = "lblPaginaCodigo";
            this.lblPaginaCodigo.Size = new System.Drawing.Size(72, 17);
            this.lblPaginaCodigo.TabIndex = 21;
            this.lblPaginaCodigo.Text = "Pág. código:";
            // 
            // btnArqLog
            // 
            this.btnArqLog.Location = new System.Drawing.Point(327, 147);
            this.btnArqLog.Name = "btnArqLog";
            this.btnArqLog.Size = new System.Drawing.Size(26, 22);
            this.btnArqLog.TabIndex = 20;
            this.btnArqLog.Text = "...";
            this.btnArqLog.UseVisualStyleBackColor = true;
            this.btnArqLog.Click += new System.EventHandler(this.btnArqLog_Click);
            // 
            // txtArqLog
            // 
            this.txtArqLog.Location = new System.Drawing.Point(65, 148);
            this.txtArqLog.Name = "txtArqLog";
            this.txtArqLog.Size = new System.Drawing.Size(258, 20);
            this.txtArqLog.TabIndex = 19;
            // 
            // lblArqLog
            // 
            this.lblArqLog.Location = new System.Drawing.Point(10, 151);
            this.lblArqLog.Name = "lblArqLog";
            this.lblArqLog.Size = new System.Drawing.Size(51, 17);
            this.lblArqLog.TabIndex = 18;
            this.lblArqLog.Text = "Arq. log:";
            // 
            // chkControlePorta
            // 
            this.chkControlePorta.Location = new System.Drawing.Point(137, 121);
            this.chkControlePorta.Name = "chkControlePorta";
            this.chkControlePorta.Size = new System.Drawing.Size(120, 21);
            this.chkControlePorta.TabIndex = 17;
            this.chkControlePorta.Text = "Controle porta";
            this.chkControlePorta.UseVisualStyleBackColor = true;
            // 
            // chkIgnorarTags
            // 
            this.chkIgnorarTags.Location = new System.Drawing.Point(10, 121);
            this.chkIgnorarTags.Name = "chkIgnorarTags";
            this.chkIgnorarTags.Size = new System.Drawing.Size(120, 21);
            this.chkIgnorarTags.TabIndex = 16;
            this.chkIgnorarTags.Text = "Ignorar tags";
            this.chkIgnorarTags.UseVisualStyleBackColor = true;
            // 
            // chkTraduzirTags
            // 
            this.chkTraduzirTags.Checked = true;
            this.chkTraduzirTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTraduzirTags.Location = new System.Drawing.Point(137, 99);
            this.chkTraduzirTags.Name = "chkTraduzirTags";
            this.chkTraduzirTags.Size = new System.Drawing.Size(111, 21);
            this.chkTraduzirTags.TabIndex = 15;
            this.chkTraduzirTags.Text = "Traduzir tags";
            this.chkTraduzirTags.UseVisualStyleBackColor = true;
            // 
            // chkCortarPapel
            // 
            this.chkCortarPapel.Checked = true;
            this.chkCortarPapel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCortarPapel.Location = new System.Drawing.Point(10, 99);
            this.chkCortarPapel.Name = "chkCortarPapel";
            this.chkCortarPapel.Size = new System.Drawing.Size(120, 21);
            this.chkCortarPapel.TabIndex = 14;
            this.chkCortarPapel.Text = "Cortar papel";
            this.chkCortarPapel.UseVisualStyleBackColor = true;
            // 
            // numLinhasPular
            // 
            this.numLinhasPular.Location = new System.Drawing.Point(324, 68);
            this.numLinhasPular.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLinhasPular.Name = "numLinhasPular";
            this.numLinhasPular.Size = new System.Drawing.Size(36, 20);
            this.numLinhasPular.TabIndex = 13;
            // 
            // lblLinhasPular
            // 
            this.lblLinhasPular.Location = new System.Drawing.Point(288, 69);
            this.lblLinhasPular.Name = "lblLinhasPular";
            this.lblLinhasPular.Size = new System.Drawing.Size(34, 17);
            this.lblLinhasPular.TabIndex = 12;
            this.lblLinhasPular.Text = "Pular:";
            // 
            // numBuffer
            // 
            this.numBuffer.Location = new System.Drawing.Point(240, 68);
            this.numBuffer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuffer.Name = "numBuffer";
            this.numBuffer.Size = new System.Drawing.Size(43, 20);
            this.numBuffer.TabIndex = 11;
            // 
            // lblBuffer
            // 
            this.lblBuffer.Location = new System.Drawing.Point(199, 69);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(39, 17);
            this.lblBuffer.TabIndex = 10;
            this.lblBuffer.Text = "Buffer:";
            // 
            // numEspacos
            // 
            this.numEspacos.Location = new System.Drawing.Point(154, 68);
            this.numEspacos.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEspacos.Name = "numEspacos";
            this.numEspacos.Size = new System.Drawing.Size(39, 20);
            this.numEspacos.TabIndex = 9;
            // 
            // lblEspacos
            // 
            this.lblEspacos.Location = new System.Drawing.Point(105, 69);
            this.lblEspacos.Name = "lblEspacos";
            this.lblEspacos.Size = new System.Drawing.Size(48, 17);
            this.lblEspacos.TabIndex = 8;
            this.lblEspacos.Text = "Espaços:";
            // 
            // numColunas
            // 
            this.numColunas.Location = new System.Drawing.Point(60, 68);
            this.numColunas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numColunas.Name = "numColunas";
            this.numColunas.Size = new System.Drawing.Size(39, 20);
            this.numColunas.TabIndex = 7;
            this.numColunas.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // lblColunas
            // 
            this.lblColunas.Location = new System.Drawing.Point(10, 69);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(48, 17);
            this.lblColunas.TabIndex = 6;
            this.lblColunas.Text = "Colunas:";
            // 
            // btnAtualizarPortasImpressora
            // 
            this.btnAtualizarPortasImpressora.Location = new System.Drawing.Point(214, 36);
            this.btnAtualizarPortasImpressora.Name = "btnAtualizarPortasImpressora";
            this.btnAtualizarPortasImpressora.Size = new System.Drawing.Size(82, 22);
            this.btnAtualizarPortasImpressora.TabIndex = 5;
            this.btnAtualizarPortasImpressora.Text = "Atualizar";
            this.btnAtualizarPortasImpressora.UseVisualStyleBackColor = true;
            this.btnAtualizarPortasImpressora.Click += new System.EventHandler(this.btnAtualizarPortasImpressora_Click);
            // 
            // cboPortaImpressora
            // 
            this.cboPortaImpressora.Location = new System.Drawing.Point(86, 37);
            this.cboPortaImpressora.Name = "cboPortaImpressora";
            this.cboPortaImpressora.Size = new System.Drawing.Size(121, 21);
            this.cboPortaImpressora.TabIndex = 4;
            // 
            // lblPortaImpressora
            // 
            this.lblPortaImpressora.Location = new System.Drawing.Point(10, 40);
            this.lblPortaImpressora.Name = "lblPortaImpressora";
            this.lblPortaImpressora.Size = new System.Drawing.Size(51, 17);
            this.lblPortaImpressora.TabIndex = 3;
            this.lblPortaImpressora.Text = "Porta:";
            // 
            // btnAtivarImpressora
            // 
            this.btnAtivarImpressora.Location = new System.Drawing.Point(257, 10);
            this.btnAtivarImpressora.Name = "btnAtivarImpressora";
            this.btnAtivarImpressora.Size = new System.Drawing.Size(103, 22);
            this.btnAtivarImpressora.TabIndex = 2;
            this.btnAtivarImpressora.Text = "Ativar";
            this.btnAtivarImpressora.UseVisualStyleBackColor = true;
            this.btnAtivarImpressora.Click += new System.EventHandler(this.btnAtivarImpressora_Click);
            // 
            // cboModeloImpressora
            // 
            this.cboModeloImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeloImpressora.Location = new System.Drawing.Point(86, 11);
            this.cboModeloImpressora.Name = "cboModeloImpressora";
            this.cboModeloImpressora.Size = new System.Drawing.Size(163, 21);
            this.cboModeloImpressora.TabIndex = 1;
            // 
            // lblModeloImpressora
            // 
            this.lblModeloImpressora.Location = new System.Drawing.Point(10, 14);
            this.lblModeloImpressora.Name = "lblModeloImpressora";
            this.lblModeloImpressora.Size = new System.Drawing.Size(51, 17);
            this.lblModeloImpressora.TabIndex = 0;
            this.lblModeloImpressora.Text = "Modelo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(14, 419);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestarConexao.Location = new System.Drawing.Point(96, 419);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(103, 28);
            this.btnTestarConexao.TabIndex = 3;
            this.btnTestarConexao.Text = "Testar conexão";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnTestarImpressora
            // 
            this.btnTestarImpressora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestarImpressora.Location = new System.Drawing.Point(205, 419);
            this.btnTestarImpressora.Name = "btnTestarImpressora";
            this.btnTestarImpressora.Size = new System.Drawing.Size(103, 28);
            this.btnTestarImpressora.TabIndex = 4;
            this.btnTestarImpressora.Text = "Testar impressora";
            this.btnTestarImpressora.UseVisualStyleBackColor = true;
            this.btnTestarImpressora.Click += new System.EventHandler(this.btnTestarImpressora_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(313, 419);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 28);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 457);
            this.Controls.Add(this.tabConfiguracao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnTestarImpressora);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            this.tabConfiguracao.ResumeLayout(false);
            this.tabDirectPIN.ResumeLayout(false);
            this.tabDirectPIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutAckNak)).EndInit();
            this.tabImpressora.ResumeLayout(false);
            this.tabImpressora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhasPular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
