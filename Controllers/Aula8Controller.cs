using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula8")]
    [ApiController]
    public class Aula8Controller : ControllerBase
    {

        [Route("olaMundo")]
        [HttpGet]
        public string OlaMundo()
        {
            var mensagem = "Olá mundo via API";

            return mensagem;
        }
        
        [Route("olaMundoPersonalizado")]
        [HttpGet]
        public string OlaMundoPersonalizado(string nome)
        {
            var mensagem = "Olá mundo via API " + nome;

            return mensagem;
        }
    }
}
