namespace Lib.DirectPIN.Classes.Response
{
    /// <summary>Resultado da operação "survey" — seção 6.8.</summary>
    public class RespostaPesquisa
    {
        public string Type { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
        public RespostaPesquisaDados Data { get; set; }
    }
}
