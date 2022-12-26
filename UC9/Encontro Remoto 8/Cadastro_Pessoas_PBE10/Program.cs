using Cadastro_Pessoas_PBE10.Classes;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
===========================================
|   Bem vindo ao sistema de cadastro de   |
|      Pessoas Físicas e Jurídicas        |
===========================================
");
Console.ResetColor();

Utils.BarraCarregamento("Iniciando", 100, 10);

//lista para armazenar as pessoas físicas cadastradas
List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|             1 - Pessoa Física           |
|             2 - Pessoa Jurídica         |
|                                         |
|             0 - Sair                    |
===========================================
");
    Console.ResetColor();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|      1 - Cadastrar Pessoa Física        |
|      2 - Listar Pessoas Física          |
|                                         |
|      0 - voltar ao menu anterior        |
===========================================
");
                Console.ResetColor();
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        //criação dos objetos
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Endereco novoEnderecoPf = new Endereco();

                        //entrada e armazenamento do nome
                        Console.WriteLine(@$"Digite o nome que deseja cadastrar");
                        novaPessoaFisica.Nome = Console.ReadLine();

                        //entrada e armazenamentodo cpf
                        Console.WriteLine($"Digite o número do cpf");
                        novaPessoaFisica.Cpf = Console.ReadLine();

                        //validação da data de nascimento

                        bool dataValida; //variável que guarda a informação se a data é válida ou não

                        do //laço de repetição
                        {
                            //entrada e armazenamento da data de nascimento digitada
                            Console.WriteLine(@$"Digite a data de nascimento ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            //variável recebe a validação da data de nascimento digitada
                            dataValida = metodosPf.ValidarDataNascimento(dataNascimento);

                            //se a data for válida
                            if (dataValida)
                            {
                                //variável para armazenar a data convertida de string pra DateTime
                                DateTime dataConvertida;

                                //fazendo a conversão e colocando a saída dentro da variável dataConvertida
                                DateTime.TryParse(dataNascimento, out dataConvertida);

                                //atribui-se a data digitada para a DataNascimento do objeto
                                novaPessoaFisica.DataNascimento = dataConvertida;
                            }
                            else
                            {
                                //senão, mostra-se uma mensagem no console que a data não é válida
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inválida, favor digitar uma data válida!");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);//enquanto a dataValida for false, repetir o laço 

                        //entrada e armazenamento do rendimento
                        Console.WriteLine($"Digite o rendimento mensal - (apenas números): ");
                        novaPessoaFisica.Rendimento = float.Parse(Console.ReadLine());

                        //entrada e armazenamento do logradouro
                        Console.WriteLine($"Digite o logradouro: ");
                        novoEnderecoPf.Logradouro = Console.ReadLine();

                        //entrada e armazenamento do número
                        Console.WriteLine($"Digite o número");
                        novoEnderecoPf.Numero = int.Parse(Console.ReadLine());

                        //entrada e armazenamento do complemento
                        Console.WriteLine($"Informe o complemento: ");
                        novoEnderecoPf.Complemento = Console.ReadLine();

                        //entrada e armazenamento do endereço comercial
                        Console.WriteLine($"Endereço é comercial ? S para sim ou N para não: ");
                        string endCom = Console.ReadLine().ToUpper();

                        //se o endereço digitado for comercial "S"
                        if (endCom == "S")
                        {
                            //atribui-se true para o endereço comercial
                            novoEnderecoPf.Comercial = true;
                        }
                        else
                        {
                            //senão, atribui-se false
                            novoEnderecoPf.Comercial = false;
                        }

                        //então armazena todos os dados do objeto novoEndPf dentro do endereço do objeto novaPessoaFisica
                        novaPessoaFisica.Endereco = novoEnderecoPf;

                        //adicionamos a pessoa cadastrada dentro da lista
                        listaPf.Add(novaPessoaFisica);

                        
                        //enquanto estiver executando algo dentro das chaves
                        //o recurso passado como parametro estará disponível
                        using(StreamWriter sw = new StreamWriter($"{novaPessoaFisica.Nome}.txt"))//using statement
                        {
                            sw.WriteLine(novaPessoaFisica.Nome);                            
                        }
                        
                        //finalizando com uma mensagem
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        break;

                    case "2":       

                        //agora usaremos StreamReader para lermos o 
                        //arquivo txt que criamos
                        using(StreamReader sr = new StreamReader("Jose.txt"))
                        {
                            string? linha;//variavel armazenar a leitura

                            //enquanto o conteudo da linha for diferente de null, então mostre o conteúdo da linha
                            while((linha = sr.ReadLine()) != null)
                            {
                                 Console.WriteLine($"{linha}");                                       
                            }
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();                        

                        break;
                    case "0":
                        //caso 0  - voltar para o menu anterior
                        break;
                    default:
                        //mensagem genérica
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            } while (opcaoPf != "0");

            break;

        case "2":
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
            Endereco novoEndereco = new Endereco();
            PessoaJuridica metodosPj = new PessoaJuridica();

            novoEndereco.Logradouro = "Rua Niterói";
            novoEndereco.Numero = 180;
            novoEndereco.Complemento = "São Caetano do Sul - SP";
            novoEndereco.Comercial = true;

            novaPessoaJuridica.Nome = "Senai";
            novaPessoaJuridica.RazaoSocial = "Escola Senai de Informática Ltda";
            novaPessoaJuridica.Cnpj = "58352125000149";
            novaPessoaJuridica.Rendimento = 100000.99f;
            novaPessoaJuridica.Endereco = novoEndereco;

            //chamada do método para inserir os dados de novaPessoaJuridica dentro de um arquivo csv
            metodosPj.Inserir(novaPessoaJuridica);
            
            //chamada para listar os itens salvos dentro do csv
            List<PessoaJuridica> listaPj = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
                Console.WriteLine(@$"
                Nome Fantasia: {cadaItem.Nome}
                Cnpj: {cadaItem.Cnpj}
                Razão Social: {cadaItem.RazaoSocial}
                ");
                Console.WriteLine($"Aperte 'Enter' para continuar");
                Console.ReadLine();               
            }            
            break;

        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por utilizar nosso sistema !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida, escolha outra opção !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando", 300, 10);