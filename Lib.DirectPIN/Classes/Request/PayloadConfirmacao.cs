using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "confirmtransaction" — seção 6.3.</summary>
    public class PayloadConfirmacao
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "confirmtransaction";

        public string Nsu { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
