using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe pessoa e ela é a superclasse
    public abstract class Pessoa : IPessoa
    {
        //atributos da classe Pessoa
        public string? Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public float Rendimento { get; set; }
        public abstract float PagarImposto(float rendimento);        
    }
}

//metodos acessores
//get : leitura
//set : edição
//por padrão, esses métodos acessores vem como público, mas caso necessite, coloque como privado
