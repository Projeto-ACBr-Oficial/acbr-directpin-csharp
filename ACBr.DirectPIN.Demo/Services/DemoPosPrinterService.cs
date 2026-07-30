namespace ACBr.DirectPIN.Demo.Services
{
    /// <summary>Consumidor simples do singleton <see cref="PosPrinterConfigService"/>.</summary>
    internal class DemoPosPrinterService
    {
        private readonly PosPrinterConfigService _config = PosPrinterConfigService.ObtemInstancia();

        public void ImprimirTexto(string texto, bool cortarPapel = true)
        {
            _config.Ativar();
            try
            {
                _config.Imprimir(ParaEscPos(texto, cortarPapel));
            }
            finally
            {
                _config.Desativar();
            }
        }

        public void AplicarConfiguracaoSalva() => _config.AplicarConfiguracaoSalva();

        /// <summary>
        /// Envolve o texto com as tags de controle do ACBrPosPrinter — mesmo padrão do
        /// ComprovanteBuilder.ParaEscPos do ACBr.CliSiTef.Demo: "&lt;/zera&gt;" reseta o
        /// buffer, "&lt;/ae&gt;" alinha à esquerda, "&lt;/lf&gt;" substitui as quebras de
        /// linha e "&lt;/corte_total&gt;" comanda o corte no final. Só funcionam porque
        /// Config.TraduzirTags=true e o Imprimir() decodifica tags por padrão.
        /// </summary>
        private static string ParaEscPos(string texto, bool cortarPapel)
        {
            if (string.IsNullOrEmpty(texto))
                return "</zera>";

            string corpo = texto.Replace("\r\n", "\n").Replace("\n", "</lf>");
            string sufixo = cortarPapel ? "</lf></corte_total>" : "</lf>";

            return "</zera></ae>" + corpo + sufixo;
        }
    }
}
