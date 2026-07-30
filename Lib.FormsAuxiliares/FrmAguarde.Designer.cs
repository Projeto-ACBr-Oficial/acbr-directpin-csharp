namespace Lib.FormsAuxiliares
{
    partial class FrmAguarde
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnAbortar;

        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnAbortar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblMensagem
            //
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMensagem.Location = new System.Drawing.Point(24, 24);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(336, 40);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Aguardando resposta do pinpad...";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // progressBar
            //
            this.progressBar.Location = new System.Drawing.Point(24, 72);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(336, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            //
            // btnAbortar
            //
            this.btnAbortar.Location = new System.Drawing.Point(136, 108);
            this.btnAbortar.Name = "btnAbortar";
            this.btnAbortar.Size = new System.Drawing.Size(112, 32);
            this.btnAbortar.TabIndex = 2;
            this.btnAbortar.Text = "Abortar";
            this.btnAbortar.UseVisualStyleBackColor = true;
            this.btnAbortar.Click += new System.EventHandler(this.btnAbortar_Click);
            //
            // FrmAguarde
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.btnAbortar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAguarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aguarde";
            this.ResumeLayout(false);
        }
    }
}
