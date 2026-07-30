using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "transactionStatus" — seção 6.9.</summary>
    public class PayloadStatusTransacao
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "transactionStatus";

        public string CustomerId { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
