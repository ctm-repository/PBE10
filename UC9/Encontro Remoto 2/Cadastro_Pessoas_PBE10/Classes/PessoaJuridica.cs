namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe Pessoa Juridica herda da superclasse Pessoa
    public class PessoaJuridica : Pessoa
    {
        //atributos da classe Pessoa Juridica
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
    }
}