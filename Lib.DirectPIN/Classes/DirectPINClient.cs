using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Lib.DirectPIN.Classes.Request;
using Lib.DirectPIN.Classes.Response;
using Lib.DirectPIN.Protocolo;

namespace Lib.DirectPIN.Classes
{
    /// <summary>
    /// Facade pública da lib — único ponto de entrada para conversar com o pinpad DirectPIN
    /// via Serial. Esconde a montagem/leitura do frame, o CRC e o ciclo ACK/NAK/retry por
    /// trás de um método async por operação do protocolo.
    /// </summary>
    public sealed class DirectPINClient : IDisposable
    {
        private readonly DirectPINConfig _config;
        private readonly DirectPINSerialTransporte _transporte;

        public DirectPINClient(DirectPINConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _transporte = new DirectPINSerialTransporte(config);
        }

        public bool Conectado => _transporte.Aberta;

        public void Conectar() => _transporte.Abrir();

        public void Desconectar() => _transporte.Fechar();

        public async Task<RespostaTransacao> TransacaoAsync(PayloadTransacao payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaTransacao>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaCancelamento> CancelarTransacaoAsync(PayloadCancelamento payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaCancelamento>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaConfirmacao> ConfirmarTransacaoAsync(PayloadConfirmacao payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaConfirmacao>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaDesfazimento> DesfazerTransacaoAsync(PayloadDesfazimento payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaDesfazimento>(json, DirectPINJson.Opcoes);
        }

        /// <summary>
        /// Aborta o fluxo em andamento (seção 6.5). No Serial não há resposta própria: o
        /// desfecho (ABORTED ou o resultado real, se a captura já tinha ocorrido) chega pela
        /// chamada pendente da operação original — normalmente ela lançará
        /// <see cref="Exceptions.DirectPINTimeoutException"/> caso já tenha estourado o timeout,
        /// ou retornará normalmente com FinalResult="ABORTED".
        /// </summary>
        public Task AbortarAsync(CancellationToken ct = default)
        {
            var payload = new PayloadAbort { EntityIdentifier = _config.EntityIdentifier };
            _transporte.EnviarAbort(payload.AsJson());
            return Task.CompletedTask;
        }

        public async Task<RespostaColeta> ColetarDadosAsync(PayloadColeta payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaColeta>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaMensagem> ExibirMensagemAsync(PayloadMensagem payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaMensagem>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaPesquisa> PesquisaSatisfacaoAsync(PayloadPesquisa payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaPesquisa>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaStatusTransacao> ConsultarStatusAsync(PayloadStatusTransacao payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaStatusTransacao>(json, DirectPINJson.Opcoes);
        }

        public async Task<RespostaListagemTransacoes> ListarTransacoesAsync(PayloadListagemTransacoes payload, CancellationToken ct = default)
        {
            PreencherEntityIdentifier(payload);
            string json = await _transporte.EnviarRecebendoAsync(payload.AsJson(), ct).ConfigureAwait(false);
            return JsonSerializer.Deserialize<RespostaListagemTransacoes>(json, DirectPINJson.Opcoes);
        }

        private void PreencherEntityIdentifier(PayloadTransacao p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadCancelamento p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadConfirmacao p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadDesfazimento p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadColeta p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadMensagem p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadPesquisa p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadStatusTransacao p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }
        private void PreencherEntityIdentifier(PayloadListagemTransacoes p) { if (string.IsNullOrEmpty(p.EntityIdentifier)) p.EntityIdentifier = _config.EntityIdentifier; }

        public void Dispose() => _transporte.Dispose();
    }
}
