using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe para Endereço
    public class Endereco
    {
        //atributos da classe Endereço
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public bool Comercial { get; set; }      
    }
}