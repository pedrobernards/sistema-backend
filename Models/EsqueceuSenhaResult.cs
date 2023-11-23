using System;

namespace ProgramacaoDoZero.Models
{
    public class EsqueceuSenhaResult : BaseResult
    {
        public static implicit operator EsqueceuSenhaResult(string v)
        {
            throw new NotImplementedException();
        }
    }
}
