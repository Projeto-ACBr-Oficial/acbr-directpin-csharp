using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "listTransactions" — seção 6.10.</summary>
    public class PayloadListagemTransacoes
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "listTransactions";

        public string CustomerId { get; set; }
        public string Nsu { get; set; }
        public StatusTransacao? Status { get; set; }
        public TipoTransacao? TypeTransaction { get; set; }
        public long? DateStart { get; set; }
        public long? DateEnd { get; set; }
        public int? Limit { get; set; } = 50;
        public int? Offset { get; set; } = 0;
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
