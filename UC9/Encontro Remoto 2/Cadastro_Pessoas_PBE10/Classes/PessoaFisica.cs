namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe Pessoa Fisica que herda da superclasse Pessoa
    public class PessoaFisica : Pessoa
    {
        //atributos da classe Pessoa Fisica
        public string? Cpf { get; set; } 
        public DateTime DataNascimento { get; set; }
    }
}