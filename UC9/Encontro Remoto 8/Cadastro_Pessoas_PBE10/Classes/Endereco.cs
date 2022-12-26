namespace Cadastro_Pessoas_PBE10.Classes
{
    /// <summary>
    /// classe para Endereço
    /// </summary>
    public class Endereco
    {
        //propriedades da classe Endereço
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public bool Comercial { get; set; }      
    }
}