namespace Lib.FormsAuxiliares
{
    partial class FrmColetaDados
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblMascara;
        private System.Windows.Forms.TextBox txtMascara;
        private System.Windows.Forms.Label lblTipoEntrada;
        private System.Windows.Forms.ComboBox cboTipoEntrada;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblMascara = new System.Windows.Forms.Label();
            this.txtMascara = new System.Windows.Forms.TextBox();
            this.lblTipoEntrada = new System.Windows.Forms.Label();
            this.cboTipoEntrada = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título exibido no pinpad:";
            //
            // txtTitulo
            //
            this.txtTitulo.Location = new System.Drawing.Point(144, 14);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 23);
            this.txtTitulo.TabIndex = 1;
            //
            // lblMascara
            //
            this.lblMascara.Location = new System.Drawing.Point(16, 48);
            this.lblMascara.Name = "lblMascara";
            this.lblMascara.Size = new System.Drawing.Size(120, 20);
            this.lblMascara.TabIndex = 2;
            this.lblMascara.Text = "Máscara (opcional):";
            //
            // txtMascara
            //
            this.txtMascara.Location = new System.Drawing.Point(144, 46);
            this.txtMascara.Name = "txtMascara";
            this.txtMascara.Size = new System.Drawing.Size(220, 23);
            this.txtMascara.TabIndex = 3;
            //
            // lblTipoEntrada
            //
            this.lblTipoEntrada.Location = new System.Drawing.Point(16, 80);
            this.lblTipoEntrada.Name = "lblTipoEntrada";
            this.lblTipoEntrada.Size = new System.Drawing.Size(120, 20);
            this.lblTipoEntrada.TabIndex = 4;
            this.lblTipoEntrada.Text = "Tipo de entrada:";
            //
            // cboTipoEntrada
            //
            this.cboTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEntrada.Location = new System.Drawing.Point(144, 78);
            this.cboTipoEntrada.Name = "cboTipoEntrada";
            this.cboTipoEntrada.Size = new System.Drawing.Size(220, 23);
            this.cboTipoEntrada.TabIndex = 5;
            //
            // btnOk
            //
            this.btnOk.Location = new System.Drawing.Point(196, 120);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(284, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FrmColetaDados
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 166);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboTipoEntrada);
            this.Controls.Add(this.lblTipoEntrada);
            this.Controls.Add(this.txtMascara);
            this.Controls.Add(this.lblMascara);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColetaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coleta de dados";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
