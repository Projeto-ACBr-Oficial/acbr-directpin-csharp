namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "cancel_transaction" (estorno) — seção 6.2.</summary>
    public class RespostaCancelamento
    {
        public bool Result { get; set; }
        public string FinalResult { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string ReceiptContent { get; set; }
        public bool ForceReset { get; set; }
    }
}
