using System.IO.Ports;

namespace Lib.DirectPIN.Classes
{
    public class DirectPINConfig
    {
        public string PortaCom { get; set; }

        // Fixos pelo protocolo (seção 5.3) — não deveriam ser expostos como configuráveis
        // por instalação, apenas mantidos aqui para montar o SerialPort.
        public int BaudRate { get; set; } = 19200;
        public int DataBits { get; set; } = 8;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;

        // Seção 5.4: aguardar ao menos 5s pelo ACK/NAK antes de considerar falha de comunicação.
        public int TimeoutAckNak { get; set; } = 5000;

        // Seção 5: recomenda-se 120s para transações (leitura de cartão, PIN e autorização).
        public int TimeoutOperacao { get; set; } = 120000;

        public string EntityIdentifier { get; set; } = "";

        public bool ConfirmarTransacoesAutomaticamente { get; set; } = true;
    }
}
