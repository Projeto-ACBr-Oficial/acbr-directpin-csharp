namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>
    /// Objeto "transaction" reaproveitado por transactionStatus (seção 6.9) e por cada item
    /// de listTransactions (seção 6.10).
    /// </summary>
    public class ItemTransacao
    {
        public string CustomerId { get; set; }
        public string Nsu { get; set; }
        public string NsuAcquirer { get; set; }
        public string Status { get; set; }
        public long Amount { get; set; }
        public long Date { get; set; }
        public string TypeTransaction { get; set; }
        public string TypeCard { get; set; }
        public string Brand { get; set; }
        public string PanMasked { get; set; }
        public string AuthCode { get; set; }
        public int Installments { get; set; }
        public string FinalResult { get; set; }
        public int CodeResult { get; set; }
    }
}
