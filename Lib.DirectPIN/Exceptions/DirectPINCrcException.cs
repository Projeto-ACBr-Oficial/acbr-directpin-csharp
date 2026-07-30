namespace Lib.DirectPIN.Exceptions
{
    /// <summary>
    /// Frame recebido do terminal com CRC-16/CCITT inválido (seção 5.2).
    /// </summary>
    public class DirectPINCrcException : DirectPINException
    {
        public DirectPINCrcException(string message) : base(message)
        {
        }
    }
}
