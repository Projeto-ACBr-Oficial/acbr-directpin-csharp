using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "undotransaction" — seção 6.4.</summary>
    public class PayloadDesfazimento
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "undotransaction";

        public string Nsu { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
