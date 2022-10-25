namespace Cadastro_Pessoas_PBE10.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }


        //"Database/PessoaJuridica.csv"     
        //método para verificar se existe o Caminho = "Database/PessoaJuridica.csv"
        public static void VerificarPastaArquivo(string caminho)
        {
            //dar o split na / do caminho, e pegar a posição 0
            string pasta = caminho.Split("/")[0];

            //se NÃO existir um diretório nessa posição
            if(!Directory.Exists(pasta))
            {
                //então cria-se o diretório Database
                Directory.CreateDirectory(pasta);
            }

            //se NÃO existir um arquivo nesse caminho
            if(!File.Exists(caminho))
            {
                //então cria-se o arquivo PessoaJuridica.csv
                using(File.Create(caminho)){}
            }
        }
    }
}