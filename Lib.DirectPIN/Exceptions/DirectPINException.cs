using System;

namespace Lib.DirectPIN.Exceptions
{
    /// <summary>
    /// Falha de infraestrutura/transporte (porta serial, protocolo, comunicação).
    /// Resultado de negócio (transação reprovada, já confirmada etc.) nunca lança
    /// exception — vem como DTO normal em Classes/Response, exatamente como a API documenta.
    /// </summary>
    public class DirectPINException : Exception
    {
        public DirectPINException()
        {
        }

        public DirectPINException(string message) : base(message)
        {
        }

        public DirectPINException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
