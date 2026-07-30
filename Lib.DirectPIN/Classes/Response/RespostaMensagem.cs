namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "message" — seção 6.7.</summary>
    public class RespostaMensagem
    {
        public string Type { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
    }
}
