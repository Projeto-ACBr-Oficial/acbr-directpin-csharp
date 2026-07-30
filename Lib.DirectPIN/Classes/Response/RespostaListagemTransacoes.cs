using System.Collections.Generic;

namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "listTransactions" — seção 6.10.</summary>
    public class RespostaListagemTransacoes
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public int TotalCount { get; set; }
        public int Count { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public List<ItemTransacao> Transactions { get; set; }
        public bool ForceReset { get; set; }
    }
}
