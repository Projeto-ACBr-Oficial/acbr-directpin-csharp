using System;
using System.Text;

namespace Lib.DirectPIN.Protocolo
{
    /// <summary>
    /// Framing do transporte Serial: [SYN | base64_payload | CRC_hi | CRC_lo | ETB],
    /// conforme seção 5.2 do guia de integração DirectPIN. O CRC é calculado sobre os
    /// bytes ASCII do Base64, não sobre o JSON original (seção 5.5).
    /// </summary>
    public static class DirectPINFrame
    {
        public const byte Ack = 0x06;
        public const byte Nak = 0x15;
        public const byte Syn = 0x16;
        public const byte Etb = 0x17;

        public static byte[] MontarFrame(string jsonPayload)
        {
            if (jsonPayload == null)
                throw new ArgumentNullException(nameof(jsonPayload));

            byte[] base64Payload = Encoding.ASCII.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonPayload)));
            ushort crc = Crc16Ccitt.Calcular(base64Payload);

            byte[] frame = new byte[1 + base64Payload.Length + 2 + 1];
            int i = 0;
            frame[i++] = Syn;
            Array.Copy(base64Payload, 0, frame, i, base64Payload.Length);
            i += base64Payload.Length;
            frame[i++] = (byte)((crc >> 8) & 0xFF); // CRC_hi
            frame[i++] = (byte)(crc & 0xFF);        // CRC_lo
            frame[i] = Etb;

            return frame;
        }

        public static bool TentarLerFrame(byte[] frame, out string json, out string erro)
        {
            json = null;
            erro = null;

            if (frame == null || frame.Length < 4)
            {
                erro = "Frame recebido menor que o tamanho mínimo (SYN+CRC+ETB).";
                return false;
            }

            if (frame[0] != Syn)
            {
                erro = "Frame recebido não inicia com SYN (0x16).";
                return false;
            }

            if (frame[frame.Length - 1] != Etb)
            {
                erro = "Frame recebido não termina com ETB (0x17).";
                return false;
            }

            int tamanhoPayload = frame.Length - 4; // SYN + CRC(2) + ETB
            byte[] base64Payload = new byte[tamanhoPayload];
            Array.Copy(frame, 1, base64Payload, 0, tamanhoPayload);

            byte crcHiRecebido = frame[frame.Length - 3];
            byte crcLoRecebido = frame[frame.Length - 2];
            ushort crcRecebido = (ushort)((crcHiRecebido << 8) | crcLoRecebido);
            ushort crcCalculado = Crc16Ccitt.Calcular(base64Payload);

            if (crcCalculado != crcRecebido)
            {
                erro = $"CRC inválido: recebido 0x{crcRecebido:X4}, calculado 0x{crcCalculado:X4}.";
                return false;
            }

            try
            {
                string base64String = Encoding.ASCII.GetString(base64Payload);
                byte[] jsonBytes = Convert.FromBase64String(base64String);
                json = Encoding.UTF8.GetString(jsonBytes);
                return true;
            }
            catch (Exception ex)
            {
                erro = $"Falha ao decodificar o payload Base64/UTF-8: {ex.Message}";
                return false;
            }
        }
    }
}
