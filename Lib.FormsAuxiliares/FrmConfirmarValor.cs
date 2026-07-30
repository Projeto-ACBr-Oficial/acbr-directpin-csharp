using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    /// <summary>
    /// Confirma/ajusta o valor de uma transação específica — usado quando a venda é paga em
    /// múltiplas transações (o campo "Valor operação" da tela é o total da venda, não o valor
    /// desta parcela/cartão em particular).
    /// </summary>
    public partial class FrmConfirmarValor : Form
    {
        public FrmConfirmarValor()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public decimal Valor
        {
            get => numValor.Value;
            set => numValor.Value = value;
        }

        public decimal Maximo
        {
            get => numValor.Maximum;
            set => numValor.Maximum = value;
        }

        private void btnPagar_Click(object sender, System.EventArgs e)
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
