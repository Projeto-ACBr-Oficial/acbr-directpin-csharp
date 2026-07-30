using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    /// <summary>
    /// Configura os parâmetros de uma operação "collect" antes de enviá-la ao pinpad — a
    /// digitação em si acontece no terminal, não aqui. Não referencia Lib.DirectPIN
    /// (mesma regra de camadas do Lib.FormsAuxiliares do CliSiTef, que só depende de Lib.Utils):
    /// o combo de tipo de entrada usa os literais do contrato como string simples.
    /// </summary>
    public partial class FrmColetaDados : Form
    {
        public FrmColetaDados()
        {
            InitializeComponent();
            cboTipoEntrada.Items.AddRange(new object[] { "TEXT", "NUMERIC", "NUMERIC_PASSWORD", "PASSWORD", "EMAIL" });
            cboTipoEntrada.SelectedIndex = 0;
        }

        public string Titulo
        {
            get => txtTitulo.Text;
            set => txtTitulo.Text = value;
        }

        public string Mascara
        {
            get => txtMascara.Text;
            set => txtMascara.Text = value;
        }

        public string TipoEntradaSelecionado
        {
            get => cboTipoEntrada.SelectedItem as string ?? "TEXT";
            set => cboTipoEntrada.SelectedItem = value;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
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
