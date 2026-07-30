using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "message" (texto ou QR Code) — seção 6.7.</summary>
    public class PayloadMensagem
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "message";

        public TipoMensagem TypeMessage { get; set; } = ConstantValues.TipoMensagem.TEXT;
        public string Title { get; set; }
        public string Message { get; set; }
        public string ConfirmMessage { get; set; }
        public string CancelMessage { get; set; }
        public long? TimeOut { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
