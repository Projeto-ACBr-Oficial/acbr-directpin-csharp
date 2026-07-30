using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "survey" (pesquisa de satisfação) — seção 6.8.</summary>
    public class PayloadPesquisa
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "survey";

        public string Title { get; set; }
        public string Question { get; set; }
        public int ScaleMin { get; set; }
        public int ScaleMax { get; set; }
        public string SurveyId { get; set; }
        public TipoPesquisa? SurveyType { get; set; }
        public bool AllowComment { get; set; } = true;
        public bool Active { get; set; } = true;
        public string CreatedAt { get; set; }
        public string UserId { get; set; }
        public string CustomerId { get; set; }
        public string TransactionId { get; set; }
        public string OperationType { get; set; }
        public string Channel { get; set; }
        public string DeviceIdentifier { get; set; }
        public string Flow { get; set; }
        public string Event { get; set; }
        public Dictionary<string, object> Context { get; set; }
        public string EntityIdentifier { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
