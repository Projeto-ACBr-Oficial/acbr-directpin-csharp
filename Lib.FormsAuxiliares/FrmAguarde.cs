using System;
using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    /// <summary>
    /// Exibida enquanto o PDV aguarda o frame de resposta do pinpad. O Serial não envia
    /// notificações intermediárias (isso só existe no transporte TCP/IP) — por isso aqui só
    /// há uma mensagem estática, sem detalhe de progresso.
    /// </summary>
    public partial class FrmAguarde : Form
    {
        public event EventHandler AbortarSolicitado;

        public FrmAguarde()
        {
            InitializeComponent();
        }

        public string Mensagem
        {
            get => lblMensagem.Text;
            set => lblMensagem.Text = value;
        }

        public void MostrarSemBotaoAbortar()
        {
            btnAbortar.Visible = false;
        }

        private void btnAbortar_Click(object sender, EventArgs e)
        {
            AbortarSolicitado?.Invoke(this, EventArgs.Empty);
        }
    }
}
