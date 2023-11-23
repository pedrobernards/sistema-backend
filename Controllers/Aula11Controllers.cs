
using Microsoft.AspNetCore.Mvc;
using ProgramacaoDoZero.Models;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula11")]
    [ApiController]
    public class Aula11Controllers : ControllerBase
    {
        [Route("obterVeiculo")]
        [HttpGet]
        public Veiculo obterVeiculo()
        {
            var meuVeiculo = new Veiculo();

            meuVeiculo.Cor = "Amarelo";
            meuVeiculo.Marca = "Marca";
            meuVeiculo.Modelo = "Fusion";
            meuVeiculo.Placa = "DEX-3358";

            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();

            return meuVeiculo;
        }

        [Route("obterCarro")]
        [HttpGet]

        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.Marca = "Honda";
            meuCarro.Modelo = "Fit";
            meuCarro.Placa = "DRT-2352";
            meuCarro.Cor = "Vermelho";

            meuCarro.Acelerar();
            return meuCarro;
        }


        [Route("obterMoto")]
        [HttpGet]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.Marca = "Yamaha";
            minhaMoto.Modelo = "Fazer 250";
            minhaMoto.Cor = "Azul";
            minhaMoto.Placa = "EED-3523";

            minhaMoto.Acelerar();

            return minhaMoto;
        }
    }
}
