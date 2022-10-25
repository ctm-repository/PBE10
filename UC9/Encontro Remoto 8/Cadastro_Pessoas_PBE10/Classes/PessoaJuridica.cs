using System.Text.RegularExpressions;
using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe Pessoa Juridica herda da superclasse Pessoa
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos da classe Pessoa Juridica
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
        public string Caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        

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


        //58.635.559/0001-55 : 18 CARACTERES
        //58635559000155 : 14 CARACTERES
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // método para inserir uma pessoa juridica em um arquivo csv 
        public void Inserir(PessoaJuridica pj)
        {
            //chamada do método para verificar se o caminho já existe, ou seja a pasta e o arquivo
            Utils.VerificarPastaArquivo(Caminho);

            //criado um array de strings que recebe o objeto transformado em strings, ou seja, em partes
            //feito dessa maneira pq o método que vai inserir os dados espera receber um array de strings 
            //padrão que será salvo dentro do arquivo
            string[] pjStrings = {$"{pj.Nome}, {pj.Cnpj}, {pj.RazaoSocial}"};

            //metodo que salva o conteúdo dentro do arquivo
            //AppendAllLines = método que vai inserir todas as linhas dentro do arquivo
            File.AppendAllLines(Caminho, pjStrings);
        }

        // método para listar os itens do arquivo csv
        public List<PessoaJuridica> LerArquivo()
        {
            //criado uma lista para armazenar os itens lidos no csv
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            //criado um array de strings onde será armazenados os itens dentro do csv
            string[] linhas = File.ReadAllLines(Caminho);

            //criado um foreach para leitura de cada item do array "linhas"
            foreach (string cadaLinha in linhas)
            {
                //array para armazenar os atributos do objeto, ou seja, vamos pegar o padrão e separar onde tem uma vírgula
                string[] atributos = cadaLinha.Split(",");

                //criamos um objeto para atribuir os valores lidos nele
                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}
