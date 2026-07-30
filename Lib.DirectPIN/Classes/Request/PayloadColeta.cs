using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "collect" — seção 6.6.</summary>
    public class PayloadColeta
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "collect";

        public string Title { get; set; }
        public string Mask { get; set; }
        public TipoEntrada InputType { get; set; } = TipoEntrada.TEXT;
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
