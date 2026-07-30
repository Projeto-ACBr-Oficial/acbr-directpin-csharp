namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>
    /// Resultado da operação "transaction" — seção 6.1. Campos de domínio variável
    /// (FinalResult, TypeCard) ficam como string: a seção 8.1/7 pede tolerância a valores
    /// desconhecidos, então não usamos enum aqui para não quebrar o parse com um valor novo.
    /// </summary>
    public class RespostaTransacao
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public string FinalResult { get; set; }
        public int CodeResult { get; set; }
        public long Amount { get; set; }
        public string AuthCode { get; set; }
        public string Brand { get; set; }
        public string Nsu { get; set; }
        public string NsuAcquirer { get; set; }
        public string PanMasked { get; set; }
        public long Date { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public string TypeCard { get; set; }
        public string ReceiptContent { get; set; }
        public bool ForceReset { get; set; }
        public string EndToEnd { get; set; }
        public string AcquirerName { get; set; }
        public string AcquirerId { get; set; }
        public string EstablishmentId { get; set; }
        public string CustomerId { get; set; }
    }
}
