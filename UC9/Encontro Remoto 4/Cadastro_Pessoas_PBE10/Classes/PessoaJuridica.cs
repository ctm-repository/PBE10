using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe Pessoa Juridica herda da superclasse Pessoa
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos da classe Pessoa Juridica
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f;        
            }
            else if (rendimento >= 3001 && rendimento <= 6000)
            {
                return rendimento * 0.05f;
            }
            else if (rendimento >= 6001 && rendimento <= 10000)
            {
                return rendimento * 0.07f;
            }
            else
            {
                return rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}

