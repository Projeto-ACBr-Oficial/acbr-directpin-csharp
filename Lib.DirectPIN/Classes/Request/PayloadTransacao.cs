using System.Text.Json;
using System.Text.Json.Serialization;
using Lib.DirectPIN.ConstantValues;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes.Request
{
    /// <summary>Payload da operação "transaction" — seção 6.1.</summary>
    public class PayloadTransacao
    {
        [JsonPropertyName("type")]
        public string Type { get; } = "transaction";

        public long Amount { get; set; }
        public TipoTransacao TypeTransaction { get; set; }
        public TipoCredito? CreditType { get; set; }
        public int? Installment { get; set; }
        public bool IsTyped { get; set; }
        public bool IsPreAuth { get; set; }
        public bool AutoConfirm { get; set; } = true;
        public TipoJuros? InterestType { get; set; }
        public bool PrintReceipt { get; set; }
        public string EntityIdentifier { get; set; }
        public string CustomerId { get; set; }

        public string AsJson() => JsonSerializer.Serialize(this, DirectPINJson.Opcoes);
    }
}
