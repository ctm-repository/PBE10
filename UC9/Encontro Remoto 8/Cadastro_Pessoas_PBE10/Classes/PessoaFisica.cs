using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    /// <summary>
    /// classe Pessoa Fisica que herda da superclasse Pessoa
    /// </summary>
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //propiedades da classe Pessoa Fisica
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }


        /// <summary>
        /// método para calcular imposto - sobrescrita da classe abstrata
        /// </summary>
        /// <param name="rendimento">rendimento da pessoa física</param>
        /// <returns>valor do imposto a ser pago</returns>
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento >= 1501 && rendimento <= 3500)
            {
                return rendimento * 0.02f;
            }
            else if (rendimento >= 3501 && rendimento <= 6000)
            {
                return rendimento * 0.035f;
            }
            else
            {
                return rendimento * 0.05f;
            }
        }


        /// <summary>
        /// método para validar se uma pessoa é maior de idade
        /// </summary>
        /// <param name="datanascimento">data de nascimento do tipo DateTime</param>
        /// <returns>true ou false</returns>
        public bool ValidarDataNascimento(DateTime datanascimento)
        {
            //DateTime.today pega a data
            DateTime dataAtual = DateTime.Today;

            //TotalDays = converte para dias
            double anos = (dataAtual - datanascimento).TotalDays / 365;

            //Condicional para verificação
            if (anos >= 18)
            {
                return true;
            }

            //não precisamos do else, pq caso seja verdadeiro, o primeiro return é true, caso contrário, false
            return false;
        }


        /// <summary>
        /// método para validar se uma pessoa é maior de idade 
        /// </summary>
        /// <param name="datanascimento">data de nascimento do tipo string</param>
        /// <returns>true ou false</returns>
        public bool ValidarDataNascimento(string datanascimento)
        {
            DateTime dataConvertida;

            // verificar se a string esta em um formato valido
            // DateTime.TryParse = tenta converter a string em DateTime e coloca na saída (out)
            if (DateTime.TryParse(datanascimento, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
