namespace ProgramacaoDoZero.Models
{
    public class CadastroProdutoRequest
    {
        public string nome { get; set; }

        public string codigo { get; set; }

        public decimal preco { get; set; }

        public int qtdeEstoque { get; set; }
    }
}