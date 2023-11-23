namespace ProgramacaoDoZero.Models
{
    public class Veiculo
    {
        // Construtor
        public Veiculo()
        {
            TanqueCombustivel = 40;
        }

        //atributos ou propriedades 
        public string Cor { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public string Modelo { get; set; }

        public int TanqueCombustivel { get; set; }

        private string Motor { get; set; }

        //métodos
        public virtual void Acelerar()
        {
            InjetarCombustivel(2);
        }

        public void Frear()
        {

        }
        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
        }
    }
}
