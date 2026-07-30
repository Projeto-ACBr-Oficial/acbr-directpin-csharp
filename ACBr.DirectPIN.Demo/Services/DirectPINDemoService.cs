using System;
using System.Threading.Tasks;
using Lib.DirectPIN.Classes;
using Lib.DirectPIN.Classes.Request;
using Lib.DirectPIN.Classes.Response;
using Lib.DirectPIN.ConstantValues;

namespace ACBr.DirectPIN.Demo.Services
{
    /// <summary>Orquestra o DirectPINClient para o Demo e centraliza o log de execução.</summary>
    internal class DirectPINDemoService : IDisposable
    {
        private DirectPINClient _client;
        private DirectPINConfig _config;

        public event EventHandler<string> OnLog;

        public bool Conectado => _client != null && _client.Conectado;

        public void Inicializar(DirectPINConfig config)
        {
            _config = config;
            _client?.Dispose();
            _client = new DirectPINClient(config);
            _client.Conectar();
            Log($"Porta {config.PortaCom} conectada ({config.BaudRate},{config.DataBits},N,1).");
        }

        public string GerarDocumento() => DateTime.Now.ToString("yyyyMMddHHmmssfff");

        public async Task<RespostaTransacao> EfetuarPagamentoAsync(string customerId, long valorCentavos, TipoTransacao tipo,
            TipoCredito? creditType = null, TipoJuros? interestType = null, int? parcelas = null)
        {
            var payload = new PayloadTransacao
            {
                Amount = valorCentavos,
                TypeTransaction = tipo,
                CreditType = creditType,
                Installment = parcelas,
                InterestType = interestType,
                AutoConfirm = _config.ConfirmarTransacoesAutomaticamente,
                CustomerId = customerId
            };

            Log($"Enviando transação ({tipo}): {payload.AsJson()}");
            RespostaTransacao resposta = await _client.TransacaoAsync(payload).ConfigureAwait(false);
            Log($"Resposta: FinalResult={resposta.FinalResult}, Message={resposta.Message}, Nsu={resposta.Nsu}");
            return resposta;
        }

        public async Task<RespostaCancelamento> CancelarTransacaoAsync(string nsu)
        {
            RespostaCancelamento resposta = await _client.CancelarTransacaoAsync(new PayloadCancelamento { Nsu = nsu }).ConfigureAwait(false);
            Log($"Cancelamento: FinalResult={resposta.FinalResult}, Message={resposta.Message}");
            return resposta;
        }

        public async Task<RespostaConfirmacao> ConfirmarTransacaoAsync(string nsu)
        {
            RespostaConfirmacao resposta = await _client.ConfirmarTransacaoAsync(new PayloadConfirmacao { Nsu = nsu }).ConfigureAwait(false);
            Log($"Confirmação: FinalResult={resposta.FinalResult}, Message={resposta.Message}");
            return resposta;
        }

        public async Task<RespostaDesfazimento> DesfazerTransacaoAsync(string nsu)
        {
            RespostaDesfazimento resposta = await _client.DesfazerTransacaoAsync(new PayloadDesfazimento { Nsu = nsu }).ConfigureAwait(false);
            Log($"Desfazimento: FinalResult={resposta.FinalResult}, Message={resposta.Message}");
            return resposta;
        }

        public Task AbortarAsync()
        {
            Log("Enviando abort...");
            return _client.AbortarAsync();
        }

        public async Task<RespostaColeta> ColetarDadosAsync(string titulo, string mascara, string tipoEntrada)
        {
            var payload = new PayloadColeta
            {
                Title = titulo,
                Mask = mascara,
                InputType = (TipoEntrada)Enum.Parse(typeof(TipoEntrada), tipoEntrada)
            };
            RespostaColeta resposta = await _client.ColetarDadosAsync(payload).ConfigureAwait(false);
            Log($"Coleta: Result={resposta.Result}, Message={resposta.Message}, Data={resposta.Data}");
            return resposta;
        }

        public async Task<RespostaMensagem> ExibirMensagemAsync(PayloadMensagem payload)
        {
            RespostaMensagem resposta = await _client.ExibirMensagemAsync(payload).ConfigureAwait(false);
            Log($"Mensagem: Result={resposta.Result}, Message={resposta.Message}");
            return resposta;
        }

        public async Task<RespostaPesquisa> PesquisaSatisfacaoAsync(PayloadPesquisa payload)
        {
            RespostaPesquisa resposta = await _client.PesquisaSatisfacaoAsync(payload).ConfigureAwait(false);
            Log($"Pesquisa: Result={resposta.Result}, Message={resposta.Message}");
            return resposta;
        }

        public async Task<RespostaStatusTransacao> ConsultarStatusAsync(string customerId)
        {
            RespostaStatusTransacao resposta = await _client.ConsultarStatusAsync(new PayloadStatusTransacao { CustomerId = customerId }).ConfigureAwait(false);
            Log($"Status: Result={resposta.Result}, Message={resposta.Message}");
            return resposta;
        }

        public async Task<RespostaListagemTransacoes> ListarTransacoesAsync(PayloadListagemTransacoes payload)
        {
            RespostaListagemTransacoes resposta = await _client.ListarTransacoesAsync(payload).ConfigureAwait(false);
            Log($"Listagem: Count={resposta.Count}, TotalCount={resposta.TotalCount}");
            return resposta;
        }

        private void Log(string mensagem)
        {
            OnLog?.Invoke(this, mensagem);
            Lib.Utils.Logs.Log.GerarLogProcessoExecucao(mensagem);
        }

        public void Dispose() => _client?.Dispose();
    }
}
