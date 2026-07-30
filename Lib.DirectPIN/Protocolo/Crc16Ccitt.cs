namespace Lib.DirectPIN.Protocolo
{
    /// <summary>
    /// CRC-16/CCITT (polinômio 0x1021, valor inicial 0x0000, sem XOR final, sem reflexão)
    /// conforme seção 5.2 do guia de integração DirectPIN.
    /// </summary>
    public static class Crc16Ccitt
    {
        private const int Polinomio = 0x1021;

        public static ushort Calcular(byte[] dados)
        {
            int crc = 0x0000;

            foreach (byte b in dados)
            {
                crc ^= (b << 8) & 0xFFFF;

                for (int i = 0; i < 8; i++)
                {
                    crc = (crc & 0x8000) != 0
                        ? ((crc << 1) ^ Polinomio) & 0xFFFF
                        : (crc << 1) & 0xFFFF;
                }
            }

            return (ushort)(crc & 0xFFFF);
        }
    }
}
