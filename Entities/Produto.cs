namespace ProgramacaoZero.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Codigo { get; set; }

        public decimal Preco { get; set; }

        public int QtdeEstoque { get; set; }
    }
}