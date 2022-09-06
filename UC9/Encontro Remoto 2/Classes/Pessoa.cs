namespace Encontro_Remoto_2.Classes
{
    //classe pessoa e ela é a superclasse
    public abstract class Pessoa
    {
        //atributos da classe Pessoa
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public float Rendimento { get; set; }
    }
}

//metodos acessores
//get : leitura
//set : edição
//por padrão, esses métodos acessores vem como público, mas caso necessite, coloque como privado