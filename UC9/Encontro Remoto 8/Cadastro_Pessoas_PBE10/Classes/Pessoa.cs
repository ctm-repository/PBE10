using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    /// <summary>
    /// classe pessoa e ela é a superclasse
    /// </summary>
    public abstract class Pessoa : IPessoa
    {
        //propriedades da classe Pessoa
        public string? Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public float Rendimento { get; set; }

        

        /// <summary>
        /// método para calcular imposto - método abstrato
        /// </summary>
        /// <param name="rendimento">rendimento da pessoa</param>
        /// <returns>valor do imposto a ser pago</returns>
        public abstract float PagarImposto(float rendimento);        
    }
}

//metodos acessores
//get : leitura
//set : edição
//por padrão, esses métodos acessores vem como público, mas caso necessite, coloque como privado