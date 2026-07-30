using System;
using System.Configuration;
using System.IO.Ports;
using Lib.DirectPIN.Classes;

namespace ACBr.DirectPIN.Demo.Services
{
    /// <summary>Carrega/salva a configuração do DirectPIN no App.config.</summary>
    internal static class DirectPINConfigService
    {
        public static DirectPINConfig Carregar()
        {
            return new DirectPINConfig
            {
                // Sem padrão de porta: força a configuração manual em vez de assumir uma
                // COM1 que pode não existir na máquina (evita um erro confuso na 1ª execução).
                PortaCom = ObterValor("DirectPIN_PortaCom", ""),
                BaudRate = ObterValorInt("DirectPIN_BaudRate", 19200),
                DataBits = ObterValorInt("DirectPIN_DataBits", 8),
                Parity = ObterValorEnum("DirectPIN_Parity", Parity.None),
                StopBits = ObterValorEnum("DirectPIN_StopBits", StopBits.One),
                EntityIdentifier = ObterValor("DirectPIN_EntityIdentifier", ""),
                TimeoutAckNak = ObterValorInt("DirectPIN_TimeoutAckNak", 5000),
                TimeoutOperacao = ObterValorInt("DirectPIN_TimeoutOperacao", 120000),
                ConfirmarTransacoesAutomaticamente = ObterValorBool("DirectPIN_ConfirmarAutomaticamente", true)
            };
        }

        public static void Salvar(DirectPINConfig config)
        {
            Configuration configuracaoApp = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            DefinirValor(configuracaoApp, "DirectPIN_PortaCom", config.PortaCom);
            DefinirValor(configuracaoApp, "DirectPIN_BaudRate", config.BaudRate.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_DataBits", config.DataBits.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_Parity", config.Parity.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_StopBits", config.StopBits.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_EntityIdentifier", config.EntityIdentifier);
            DefinirValor(configuracaoApp, "DirectPIN_TimeoutAckNak", config.TimeoutAckNak.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_TimeoutOperacao", config.TimeoutOperacao.ToString());
            DefinirValor(configuracaoApp, "DirectPIN_ConfirmarAutomaticamente", config.ConfirmarTransacoesAutomaticamente.ToString());

            configuracaoApp.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private static void DefinirValor(Configuration configuracaoApp, string chave, string valor)
        {
            if (configuracaoApp.AppSettings.Settings[chave] == null)
                configuracaoApp.AppSettings.Settings.Add(chave, valor);
            else
                configuracaoApp.AppSettings.Settings[chave].Value = valor;
        }

        private static string ObterValor(string chave, string _default)
        {
            return ConfigurationManager.AppSettings[chave] ?? _default;
        }

        private static int ObterValorInt(string chave, int _default)
        {
            return int.TryParse(ConfigurationManager.AppSettings[chave], out int valor) ? valor : _default;
        }

        private static bool ObterValorBool(string chave, bool _default)
        {
            return bool.TryParse(ConfigurationManager.AppSettings[chave], out bool valor) ? valor : _default;
        }

        private static TEnum ObterValorEnum<TEnum>(string chave, TEnum _default) where TEnum : struct
        {
            string valor = ConfigurationManager.AppSettings[chave];
            return !string.IsNullOrEmpty(valor) && Enum.TryParse(valor, out TEnum resultado) ? resultado : _default;
        }
    }
}
