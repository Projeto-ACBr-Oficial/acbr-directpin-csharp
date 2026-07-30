using System.Collections.Generic;

namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Objeto "data" do resultado de "survey" — seção 6.8.</summary>
    public class RespostaPesquisaDados
    {
        public string SurveyId { get; set; }
        public string SurveyType { get; set; }
        public string UserId { get; set; }
        public string CustomerId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
        public string TransactionId { get; set; }
        public string OperationType { get; set; }
        public string Channel { get; set; }
        public string DeviceIdentifier { get; set; }
        public string Flow { get; set; }
        public string Event { get; set; }
        public Dictionary<string, object> Context { get; set; }
        public string CreatedAt { get; set; }
    }
}
