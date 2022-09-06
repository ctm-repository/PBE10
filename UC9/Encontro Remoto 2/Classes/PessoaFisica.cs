namespace Encontro_Remoto_2.Classes
{
    //classe Pessoa Fisica que herda da superclasse Pessoa
    public class PessoaFisica : Pessoa
    {
        //atributos da classe Pessoa Fisica
        public string? Cpf { get; set; } 
        public DateTime DataNascimento { get; set; }
    }
}