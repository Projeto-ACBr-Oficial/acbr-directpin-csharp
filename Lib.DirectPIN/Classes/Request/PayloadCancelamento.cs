using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "cancel_transaction" (estorno) — seção 6.2.</summary>
    public class PayloadCancelamento
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "cancel_transaction";

        public string Nsu { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
