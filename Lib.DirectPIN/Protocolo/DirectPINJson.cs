using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lib.DirectPIN.Protocolo
{
    internal static class DirectPINJson
    {
        public static readonly JsonSerializerOptions Opcoes = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            // Sem PropertyNamingPolicy aqui: os valores dos enums (DEBIT, CREDIT, MERCHANT...)
            // já são exatamente os literais do contrato, sem conversão de casing.
            Converters = { new JsonStringEnumConverter() },
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}
