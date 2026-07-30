using System.Drawing;
using System.Windows.Forms;

namespace ACBr.DirectPIN.Demo.Helpers
{
    /// <summary>
    /// Aplica o ícone do executável (ico\logo_topo.ico, embutido via ApplicationIcon no
    /// csproj) nas janelas do Demo, em vez do ícone padrão do .NET.
    /// </summary>
    internal static class AppIconHelper
    {
        public static void AplicarIconePadrao(Form form)
        {
            using (Icon icone = Icon.ExtractAssociatedIcon(Application.ExecutablePath))
            {
                if (icone != null)
                    form.Icon = (Icon)icone.Clone();
            }
        }
    }
}
