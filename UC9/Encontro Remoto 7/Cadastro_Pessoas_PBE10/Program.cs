using System.Globalization;
using System.Text.RegularExpressions;
using Cadastro_Pessoas_PBE10.Classes;


Console.WriteLine(@$"
===========================================
|   Bem vindo ao sistema de cadastro de   |
|      Pessoas Físicas e Jurídicas        |
===========================================
");

Utils.BarraCarregamento("Iniciando", 300, 10);

//lista para armazenar as pessoas físicas cadastradas
List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
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

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
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

                        bool dataValida;//variável que guarda a informação se a data é válida ou não

                        //laço de repetição
                        do
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
                                Console.WriteLine($"Data inválida, favor digitar uma data válida!");
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

                        //finalizando com uma mensagem
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        break;

                    case "2":

                        //aqui listar pf
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica pf in listaPf)
                            {
                                Console.WriteLine(@$"
                                Nome: {pf.Nome}
                                Endereço: {pf.Endereco.Logradouro}, {pf.Endereco.Numero}, {pf.Endereco.Complemento}, {pf.Endereco.Comercial}
                                Data de nascimento: {pf.DataNascimento}
                                Rendimento: {pf.Rendimento}
                                Imposto á pagar: {metodosPf.PagarImposto(pf.Rendimento)}
                                ");                                
                            }
                            Console.WriteLine($"Aperte ENTER para continuar..");
                            Console.ReadLine();                            
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia !!!");   
                        }
                        break;
                    case "0":
                        //voltar para o menu anterior
                        break;
                    default:
                        //mensagem genérica
                        Console.WriteLine($"Opção inválida, por favor digite outra opção !");                        
                        break;
                }
            } while (opcaoPf != "0");
         
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case "2":
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

            Endereco novoEndereco = new Endereco();
            novoEndereco.Logradouro = "Rua Niterói";
            novoEndereco.Numero = 180;
            novoEndereco.Complemento = "São Caetano do Sul - SP";
            novoEndereco.Comercial = true;


            novaPessoaJuridica.Nome = "Senai";
            novaPessoaJuridica.RazaoSocial = "Escola Senai de Informática Ltda";
            novaPessoaJuridica.Cnpj = "58352125000149";
            novaPessoaJuridica.Rendimento = 100000.99f;
            novaPessoaJuridica.Endereco = novoEndereco;

            PessoaJuridica metodosPj = new PessoaJuridica();


            Console.WriteLine(@$"
Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Cnpj válido : {(metodosPj.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato válido!" : "Cnpj fora do padrão esperado!")}
Rendimento Mensal : $ {novaPessoaJuridica.Rendimento}
Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))} 
");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
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


// //exemplo de expressão regular(Regex) para validar um formato de data
// string data = "2609/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido ? "Dentro do padrão!" : "Fora do padrão, insira novamente uma data!");


// //exemplo de Substring com dois argumentos
// //startIndex : da onde vamos partir
// //lenght : quantos caracteres vamos obter
// string nome = "Pindamonhangaba";
// string substring = nome.Substring(3, 5);
// Console.WriteLine(substring);