namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "undotransaction" — seção 6.4.</summary>
    public class RespostaDesfazimento
    {
        public bool Result { get; set; }
        public string FinalResult { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public bool ForceReset { get; set; }
        public string ReceiptContent { get; set; }
    }
}
