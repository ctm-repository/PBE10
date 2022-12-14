using System.Globalization;
using Cadastro_Pessoas_PBE10.Classes;

// //imprime no console o Hello World
// Console.WriteLine("Hello, World!");

// //instanciamos um objeto do tipo pessoa fisica
// //ou seja, estamos criando um objeto
// PessoaFisica novaPessoaFisica = new PessoaFisica();

// //atribuimos um valor para as propriedades
// novaPessoaFisica.Nome = "Fabi";
// novaPessoaFisica.Cpf = "02536998744";
// novaPessoaFisica.DataNascimento = new DateTime(2001, 12, 09);
// novaPessoaFisica.Rendimento = 15000.55f;

// //imprimimos os valores do objeto no console
// Console.WriteLine(novaPessoaFisica.Nome);
// Console.WriteLine(novaPessoaFisica.Cpf);
// Console.WriteLine(novaPessoaFisica.DataNascimento);
// Console.WriteLine(novaPessoaFisica.Rendimento);

// //imprimimos no console os valores do objeto utilizando a concatenação
// System.Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// System.Console.WriteLine("Cpf: " + novaPessoaFisica.Cpf);
// System.Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// System.Console.WriteLine("Rendimento: $ " + novaPessoaFisica.Rendimento);

// //imprimimos no console os valores do objeto utilizando a interpolação
// Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// Console.WriteLine($"Cpf: {novaPessoaFisica.Cpf}");
// Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento}");
// Console.WriteLine($"Rendimento: $ {novaPessoaFisica.Rendimento}");

// //imprimimos no console os valores do objeto utilizando interpolação e quebra de linhas
// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Data de Nascimento : {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// Rendimento: $ {novaPessoaFisica.Rendimento}
// ");

//intanciado um objeto do tipo pessoa juridica
PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//instanciamos um objeto do tipo endereço
//atribuimos valores para os atributos
Endereco novoEndereco = new Endereco();
novoEndereco.Logradouro = "Rua Niterói";
novoEndereco.Numero = 180;
novoEndereco.Complemento = "São Caetano do Sul - SP";
novoEndereco.Comercial = true;

//atribuimos valores para os atributos do objeto pessoa juridica
novaPessoaJuridica.Nome = "Senai";
novaPessoaJuridica.RazaoSocial = "Escola Senai de Informática Ltda";
novaPessoaJuridica.Cnpj = "58352125000149";
novaPessoaJuridica.Rendimento = 100000.99f;
novaPessoaJuridica.Endereco = novoEndereco;

//instanciamos um objeto do tipo pessoa juridica que servirá para manipularmos os métodos
PessoaJuridica metodosPj = new PessoaJuridica();

//imprimimos os valores do objeto pessoa juridica
Console.WriteLine(@$"
Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Rendimento Mensal : $ {novaPessoaJuridica.Rendimento}
Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}
");

// ToString
//   9.000,9
//  "9.000,9" 

