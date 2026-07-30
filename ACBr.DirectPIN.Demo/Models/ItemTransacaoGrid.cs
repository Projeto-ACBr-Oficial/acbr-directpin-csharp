using System;
using Lib.DirectPIN.Classes.Response;

namespace ACBr.DirectPIN.Demo.Models
{
    /// <summary>DTO achatado de <see cref="ItemTransacao"/> para exibição em grid — usado
    /// tanto por "Consultar status" (1 linha) quanto por "Listar transações" (N linhas),
    /// já que as duas operações retornam o mesmo formato de item.</summary>
    internal class ItemTransacaoGrid
    {
        public string CustomerId { get; set; }
        public string Nsu { get; set; }
        public string NsuAcquirer { get; set; }
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public string TypeTransaction { get; set; }
        public string TypeCard { get; set; }
        public string Brand { get; set; }
        public string PanMasked { get; set; }
        public string AuthCode { get; set; }
        public int Installments { get; set; }
        public string FinalResult { get; set; }
        public int CodeResult { get; set; }

        public static ItemTransacaoGrid DeItemTransacao(ItemTransacao item)
        {
            return new ItemTransacaoGrid
            {
                CustomerId = item.CustomerId,
                Nsu = item.Nsu,
                NsuAcquirer = item.NsuAcquirer,
                Status = item.Status,
                Valor = item.Amount / 100m,
                Data = item.Date > 0
                    ? DateTimeOffset.FromUnixTimeMilliseconds(item.Date).LocalDateTime.ToString("dd/MM/yyyy HH:mm:ss")
                    : "",
                TypeTransaction = item.TypeTransaction,
                TypeCard = item.TypeCard,
                Brand = item.Brand,
                PanMasked = item.PanMasked,
                AuthCode = item.AuthCode,
                Installments = item.Installments,
                FinalResult = item.FinalResult,
                CodeResult = item.CodeResult
            };
        }
    }
}
