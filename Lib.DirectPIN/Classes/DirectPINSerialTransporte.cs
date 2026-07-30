using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using Lib.DirectPIN.Exceptions;
using Lib.DirectPIN.Protocolo;
using Lib.Utils.Logs;

namespace Lib.DirectPIN.Classes
{
    /// <summary>
    /// Encapsula o SerialPort e o ciclo write→ACK/NAK→leitura do frame de resposta
    /// descrito na seção 5.4 do guia de integração. Uso interno do <see cref="DirectPINClient"/>.
    /// </summary>
    public sealed class DirectPINSerialTransporte : IDisposable
    {
        private const int MaxTentativas = 3;
        private const int IntervaloPollingMs = 20;
        private const int BackoffAposNakMs = 1000;

        private readonly DirectPINConfig _config;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
        private SerialPort _serialPort;

        public DirectPINSerialTransporte(DirectPINConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public bool Aberta => _serialPort != null && _serialPort.IsOpen;

        public void Abrir()
        {
            if (Aberta)
                return;

            if (string.IsNullOrWhiteSpace(_config.PortaCom))
                throw new DirectPINException("Porta COM não configurada.");

            _serialPort = new SerialPort
            {
                PortName = _config.PortaCom,
                BaudRate = _config.BaudRate,
                DataBits = _config.DataBits,
                Parity = _config.Parity,
                StopBits = _config.StopBits,
                ReadTimeout = 500,
                WriteTimeout = 5000
            };

            try
            {
                _serialPort.Open();
                Log.GerarLogProcessoExecucao($"Porta {_config.PortaCom} aberta ({_config.BaudRate},{_config.DataBits},{_config.Parity},{_config.StopBits}).");
            }
            catch (Exception ex)
            {
                throw new DirectPINException($"Não foi possível abrir a porta {_config.PortaCom}: {ex.Message}", ex);
            }
        }

        public void Fechar()
        {
            if (_serialPort == null)
                return;

            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
            }
            finally
            {
                _serialPort.Dispose();
                _serialPort = null;
            }
        }

        public async Task<string> EnviarRecebendoAsync(string payloadJson, CancellationToken ct)
        {
            if (!Aberta)
                throw new DirectPINException("A porta serial não está aberta.");

            await _lock.WaitAsync(ct).ConfigureAwait(false);
            try
            {
                byte[] frame = DirectPINFrame.MontarFrame(payloadJson);

                for (int tentativa = 1; tentativa <= MaxTentativas; tentativa++)
                {
                    ct.ThrowIfCancellationRequested();

                    _serialPort.DiscardInBuffer();
                    _serialPort.Write(frame, 0, frame.Length);
                    Log.GerarLogProcessoExecucao($"Frame enviado (tentativa {tentativa}/{MaxTentativas}): {payloadJson}");

                    byte controle = await AguardarAckNakAsync(_config.TimeoutAckNak, ct).ConfigureAwait(false);

                    if (controle == DirectPINFrame.Nak)
                    {
                        if (tentativa == MaxTentativas)
                            throw new DirectPINException("O terminal recusou o frame (NAK) após as tentativas configuradas.");

                        // Seção 5.4: não reenviar de imediato após um NAK — aguardar backoff.
                        await Task.Delay(BackoffAposNakMs, ct).ConfigureAwait(false);
                        continue;
                    }

                    byte[] frameResposta = await LerFrameRespostaAsync(_config.TimeoutOperacao, ct).ConfigureAwait(false);

                    if (!DirectPINFrame.TentarLerFrame(frameResposta, out string json, out string erro))
                        throw new DirectPINCrcException(erro);

                    Log.GerarLogProcessoExecucao($"Frame de resposta recebido: {json}");
                    return json;
                }

                throw new DirectPINException("Não foi possível concluir a operação após as tentativas configuradas.");
            }
            finally
            {
                _lock.Release();
            }
        }

        /// <summary>
        /// O abort não segue o ciclo padrão (seção 5.4/6.5): se houver uma operação em
        /// andamento, o abort não recebe ACK — o desfecho chega pelo frame de resposta da
        /// operação original (finalResult=ABORTED). Por isso ele é escrito direto na porta,
        /// sem concorrer pelo lock que <see cref="EnviarRecebendoAsync"/> usa (que está
        /// ocupado aguardando a leitura da operação que está sendo abortada).
        /// </summary>
        public void EnviarAbort(string payloadJson)
        {
            if (!Aberta)
                throw new DirectPINException("A porta serial não está aberta.");

            byte[] frame = DirectPINFrame.MontarFrame(payloadJson);
            _serialPort.Write(frame, 0, frame.Length);
            Log.GerarLogProcessoExecucao($"Frame de abort enviado: {payloadJson}");
        }

        private async Task<byte> AguardarAckNakAsync(int timeoutMs, CancellationToken ct)
        {
            var cronometro = Stopwatch.StartNew();

            while (cronometro.ElapsedMilliseconds < timeoutMs)
            {
                ct.ThrowIfCancellationRequested();

                if (_serialPort.BytesToRead > 0)
                {
                    int b = _serialPort.ReadByte();
                    if (b == DirectPINFrame.Ack || b == DirectPINFrame.Nak)
                        return (byte)b;

                    // Byte inesperado (ex.: SYN de um frame atrasado de uma operação anterior) — descarta.
                }
                else
                {
                    await Task.Delay(IntervaloPollingMs, ct).ConfigureAwait(false);
                }
            }

            throw new DirectPINTimeoutException($"Timeout aguardando ACK/NAK ({timeoutMs} ms).");
        }

        private async Task<byte[]> LerFrameRespostaAsync(int timeoutMs, CancellationToken ct)
        {
            var cronometro = Stopwatch.StartNew();
            var buffer = new List<byte>();
            bool iniciado = false;

            while (cronometro.ElapsedMilliseconds < timeoutMs)
            {
                ct.ThrowIfCancellationRequested();

                if (_serialPort.BytesToRead > 0)
                {
                    int b = _serialPort.ReadByte();

                    if (!iniciado)
                    {
                        if (b == DirectPINFrame.Syn)
                        {
                            iniciado = true;
                            buffer.Add((byte)b);
                        }

                        continue; // descarta bytes até achar o SYN
                    }

                    buffer.Add((byte)b);

                    if (b == DirectPINFrame.Etb)
                        return buffer.ToArray();
                }
                else
                {
                    await Task.Delay(IntervaloPollingMs, ct).ConfigureAwait(false);
                }
            }

            throw new DirectPINTimeoutException($"Timeout aguardando o frame de resposta ({timeoutMs} ms).");
        }

        public void Dispose() => Fechar();
    }
}
