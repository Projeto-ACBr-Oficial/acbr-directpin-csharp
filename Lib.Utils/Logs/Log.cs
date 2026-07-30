using System;
using System.IO;

namespace Lib.Utils.Logs
{
    public static class Log
    {
        public static void GerarLogProcessoExecucao(string _mensagem, string _path = "")
        {
            try
            {
                string pasta = string.IsNullOrEmpty(_path) ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs") : _path;

                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                string arquivo = Path.Combine(pasta, $"Log{DateTime.Now:yyyyMMdd}.txt");
                string linha = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {_mensagem}{Environment.NewLine}";

                File.AppendAllText(arquivo, linha);
            }
            catch
            {
                // Falha ao gravar log não deve interromper o fluxo principal.
            }
        }
    }
}
