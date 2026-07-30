using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>
    /// Payload da operação "abort" — seção 6.5. No transporte Serial não há resposta
    /// própria (ver <see cref="DirectPINSerialTransporte.EnviarAbort"/>).
    /// </summary>
    public class PayloadAbort
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "abort";

        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
