using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    /// <summary>Diálogo genérico de coleta de um número inteiro — título + NumericUpDown.</summary>
    public partial class FrmColetaNumero : Form
    {
        public FrmColetaNumero()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public decimal Minimo
        {
            get => numValor.Minimum;
            set => numValor.Minimum = value;
        }

        public decimal Maximo
        {
            get => numValor.Maximum;
            set => numValor.Maximum = value;
        }

        public int Valor
        {
            get => (int)numValor.Value;
            set => numValor.Value = value;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
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
