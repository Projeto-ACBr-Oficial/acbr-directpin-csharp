namespace Lib.DirectPIN.Exceptions
{
    /// <summary>
    /// Estouro de timeout aguardando ACK/NAK (seção 5.4) ou o frame de resposta da operação.
    /// </summary>
    public class DirectPINTimeoutException : DirectPINException
    {
        public DirectPINTimeoutException(string message) : base(message)
        {
        }
    }
}
