using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    /// <summary>
    /// Diálogo genérico de seleção — título + lista de opções. Usado pelo assistente de
    /// pagamento do Demo para perguntar decisões que o próprio DirectPIN não faz de forma
    /// interativa (tipo de transação, modalidade de crédito), diferente do fluxo do
    /// SiTef/CliSiTef onde o terminal conduzia esse menu.
    /// </summary>
    public partial class FrmMenuOpcoes : Form
    {
        public FrmMenuOpcoes()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public void DefinirOpcoes(params string[] opcoes)
        {
            lstOpcoes.Items.Clear();
            lstOpcoes.Items.AddRange(opcoes);
            if (lstOpcoes.Items.Count > 0)
                lstOpcoes.SelectedIndex = 0;
        }

        public string OpcaoSelecionada => lstOpcoes.SelectedItem as string;

        private void lstOpcoes_DoubleClick(object sender, System.EventArgs e) => Confirmar();

        private void btnSelecionar_Click(object sender, System.EventArgs e) => Confirmar();

        private void Confirmar()
        {
            if (lstOpcoes.SelectedItem == null)
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
