namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "transactionStatus" — seção 6.9.</summary>
    public class RespostaStatusTransacao
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public ItemTransacao Transaction { get; set; }
        public bool ForceReset { get; set; }
    }
}
