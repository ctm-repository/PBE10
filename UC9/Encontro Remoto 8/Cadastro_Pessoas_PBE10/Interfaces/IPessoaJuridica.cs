using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Interfaces
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// método para validar cnpj
        /// </summary>
        /// <param name="cnpj">cnpj da pessoa juridica</param>
        /// <returns>verdadeiro ou falso</returns>
        bool ValidarCnpj(string cnpj);
    }
}