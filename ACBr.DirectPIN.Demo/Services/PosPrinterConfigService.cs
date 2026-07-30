using System;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ACBrLib.Core;
using ACBrLib.Core.PosPrinter;
using ACBrLib.PosPrinter;
using ACBr.DirectPIN.Demo.Helpers;

namespace ACBr.DirectPIN.Demo.Services
{
    /// <summary>
    /// Singleton que mantém viva a instância do ACBrPosPrinter (impressora de comprovantes)
    /// durante a sessão do Demo, e aplica a configuração salva no App.config.
    /// Toda chamada nativa passa por <see cref="AcbrNativeThread"/> — a DLL é x86/single-thread
    /// e não é segura fora da thread STA da UI (mesma convenção do CliSiTef).
    /// </summary>
    internal sealed class PosPrinterConfigService : IDisposable
    {
        private static PosPrinterConfigService _instancia;
        private static readonly object SyncCriacao = new object();

        private ACBrPosPrinter _posPrinter;
        private bool _disposed;

        private PosPrinterConfigService()
        {
        }

        public static PosPrinterConfigService ObtemInstancia()
        {
            return AcbrNativeThread.Executar(() =>
            {
                lock (SyncCriacao)
                {
                    if (_instancia == null || _instancia._disposed)
                        _instancia = new PosPrinterConfigService();
                    return _instancia;
                }
            });
        }

        public ACBrPosPrinter PosPrinter
        {
            get
            {
                if (_posPrinter == null)
                {
                    _posPrinter = new ACBrPosPrinter();
                    AplicarConfiguracaoSalva();
                }

                return _posPrinter;
            }
        }

        public void AplicarConfiguracaoSalva()
        {
            AcbrNativeThread.Executar(() =>
            {
                if (_posPrinter == null)
                    return;

                _posPrinter.Config.Porta = ObterValor("PosPrinter_Porta", "");
                _posPrinter.Config.Modelo = ObterValorEnum("PosPrinter_Modelo", ACBrPosPrinterModelo.ppEscPosEpson);
                _posPrinter.Config.CortaPapel = ObterValorBool("PosPrinter_CortarPapel", true);
                _posPrinter.Config.ColunasFonteNormal = ObterValorInt("PosPrinter_Colunas", 48);
                _posPrinter.Config.EspacoEntreLinhas = ObterValorInt("PosPrinter_Espacos", 0);
                _posPrinter.Config.LinhasBuffer = ObterValorInt("PosPrinter_Buffer", 0);
                _posPrinter.Config.LinhasEntreCupons = ObterValorInt("PosPrinter_LinhasPular", 0);
                _posPrinter.Config.TraduzirTags = ObterValorBool("PosPrinter_TraduzirTags", true);
                _posPrinter.Config.IgnorarTags = ObterValorBool("PosPrinter_IgnorarTags", false);
                _posPrinter.Config.ControlePorta = ObterValorBool("PosPrinter_ControlePorta", false);
                _posPrinter.Config.ArqLog = ObterValor("PosPrinter_ArqLog", "");
                _posPrinter.Config.PaginaDeCodigo = ObterValorEnum("PosPrinter_PaginaCodigo", PosPaginaCodigo.None);

                SalvarConfiguracao();
            });
        }

        /// <summary>
        /// Grava a configuração atual (seja vinda do App.config, seja da própria tela) no
        /// ACBrLib.ini nativo e recarrega — sem isso o motor da biblioteca não passa a usar
        /// os valores. Também garante o log geral da biblioteca (seção [Principal],
        /// LogNivel/LogPath): o ArqLog do componente [PosPrinter] só é escrito de fato se o
        /// log geral estiver habilitado (manual ACBrLib, "Configurações da Biblioteca").
        /// </summary>
        public void SalvarConfiguracao()
        {
            AcbrNativeThread.Executar(() =>
            {
                string logDir = Path.Combine(Application.StartupPath, "Logs");
                if (!Directory.Exists(logDir))
                    Directory.CreateDirectory(logDir);

                PosPrinter.ConfigGravarValor(ACBrSessao.Principal, "LogNivel", 4);
                PosPrinter.ConfigGravarValor(ACBrSessao.Principal, "LogPath", logDir);

                if (string.IsNullOrWhiteSpace(PosPrinter.Config.ArqLog))
                    PosPrinter.Config.ArqLog = Path.Combine(logDir, "PosPrinter.log");

                PosPrinter.ConfigGravar();
                PosPrinter.ConfigLer();
            });
        }

        /// <summary>Indica se, ao finalizar a venda, o comprovante deve ser enviado à impressora automaticamente.</summary>
        public static bool ImprimirAutomaticamente => ObterValorBool("PosPrinter_ImprimirAutomaticamente", false);

        /// <summary>
        /// Lista as portas/destinos disponíveis: portas nativas encontradas pelo ACBrLib
        /// (COM/USB/RAW), LPT1/LPT2, um arquivo de comprovante simulado (para testar sem
        /// hardware) e as impressoras Windows instaladas (prefixo "RAW:") — mesmo critério
        /// usado no ACBr.CliSiTef.Demo.
        /// </summary>
        public string[] ListarPortas()
        {
            return AcbrNativeThread.Executar(ListarPortasInterno);
        }

        private string[] ListarPortasInterno()
        {
            var lista = new System.Collections.Generic.List<string>();

            try
            {
                lista.AddRange(PosPrinter.AcharPortas());
            }
            catch
            {
                // AcharPortas pode falhar se a lib nativa ainda não estiver disponível;
                // seguimos só com as portas/destinos abaixo.
            }

            lista.Add("LPT1");
            lista.Add("LPT2");
            lista.Add(Path.Combine(Application.StartupPath, "comprovante_simulado.txt"));

            foreach (string impressora in PrinterSettings.InstalledPrinters)
                lista.Add("RAW:" + impressora);

            return lista.Distinct().ToArray();
        }

        public void Ativar()
        {
            AcbrNativeThread.Executar(() => PosPrinter.Ativar());
        }

        public void Desativar()
        {
            AcbrNativeThread.Executar(() =>
            {
                try { _posPrinter?.Desativar(); }
                catch { /* pode falhar se a porta já estiver fechada — não é um erro de negócio */ }
            });
        }

        /// <summary>
        /// Imprime o texto já preparado (tags ACBr como &lt;/lf&gt;/&lt;/corte_total&gt; incluídas
        /// pelo chamador — ver <see cref="DemoPosPrinterService"/>). decodificarTags fica no
        /// padrão (true): é ele que faz o motor traduzir essas tags em comandos ESC/POS reais.
        /// </summary>
        public void Imprimir(string texto)
        {
            AcbrNativeThread.Executar(() => PosPrinter.Imprimir(texto));
        }

        private static string ObterValor(string chave, string _default) => ConfigurationManager.AppSettings[chave] ?? _default;

        private static int ObterValorInt(string chave, int _default) =>
            int.TryParse(ConfigurationManager.AppSettings[chave], out int valor) ? valor : _default;

        private static bool ObterValorBool(string chave, bool _default) =>
            bool.TryParse(ConfigurationManager.AppSettings[chave], out bool valor) ? valor : _default;

        private static TEnum ObterValorEnum<TEnum>(string chave, TEnum _default) where TEnum : struct
        {
            string valor = ConfigurationManager.AppSettings[chave];
            return !string.IsNullOrEmpty(valor) && Enum.TryParse(valor, out TEnum resultado) ? resultado : _default;
        }

        public void Dispose()
        {
            AcbrNativeThread.Executar(() =>
            {
                if (_disposed)
                    return;

                // Dispose não deve propagar exceção — se a impressora já estiver desconectada
                // ou a porta indisponível, o encerramento do app não pode travar por causa disso.
                try { _posPrinter?.Desativar(); } catch { }

                _posPrinter?.Dispose();
                _posPrinter = null;
                _disposed = true;

                lock (SyncCriacao)
                {
                    if (ReferenceEquals(_instancia, this))
                        _instancia = null;
                }
            });
        }
    }
}
