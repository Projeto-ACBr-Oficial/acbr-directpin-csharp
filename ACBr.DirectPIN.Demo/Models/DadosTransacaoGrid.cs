using System;
using Lib.DirectPIN.Classes.Response;

namespace ACBr.DirectPIN.Demo.Models
{
    /// <summary>DTO achatado de <see cref="RespostaTransacao"/> para exibição no grid da venda.</summary>
    internal class DadosTransacaoGrid
    {
        public int Item { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Nsu { get; set; }
        public string NsuAdquirente { get; set; }
        public string Autorizacao { get; set; }
        public string Bandeira { get; set; }
        public string Cartao { get; set; }
        public string TipoCaptura { get; set; }
        public string Adquirente { get; set; }
        public string CnpjAdquirente { get; set; }
        public string CnpjEstabelecimento { get; set; }
        public string Data { get; set; }
        public string Resultado { get; set; }
        public int CodigoResultado { get; set; }
        public string Status { get; set; }

        public static DadosTransacaoGrid ParaGridItem(int item, string tipo, RespostaTransacao resposta, string status)
        {
            return new DadosTransacaoGrid
            {
                Item = item,
                Tipo = tipo,
                Valor = resposta.Amount / 100m,
                Nsu = resposta.Nsu,
                NsuAdquirente = resposta.NsuAcquirer,
                Autorizacao = resposta.AuthCode,
                Bandeira = resposta.Brand,
                Cartao = resposta.PanMasked,
                TipoCaptura = resposta.TypeCard,
                Adquirente = resposta.AcquirerName,
                CnpjAdquirente = resposta.AcquirerId,
                CnpjEstabelecimento = resposta.EstablishmentId,
                Data = resposta.Date > 0
                    ? DateTimeOffset.FromUnixTimeMilliseconds(resposta.Date).LocalDateTime.ToString("dd/MM/yyyy HH:mm:ss")
                    : "",
                Resultado = resposta.FinalResult,
                CodigoResultado = resposta.CodeResult,
                Status = status
            };
        }
    }
}
