namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>
    /// Resultado da operação "collect" — seção 6.6. Em insucesso (CANCELLED/ABORTED),
    /// Data vem nulo.
    /// </summary>
    public class RespostaColeta
    {
        public string Type { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}
