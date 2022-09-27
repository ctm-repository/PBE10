using System.Globalization;
using System.Text.RegularExpressions;
using Cadastro_Pessoas_PBE10.Classes;


// PessoaFisica novaPessoaFisica = new PessoaFisica();
// novaPessoaFisica.Nome = "Fabi";
// novaPessoaFisica.Cpf = "02536998744";
// novaPessoaFisica.DataNascimento = new DateTime(2001, 12, 09);
// novaPessoaFisica.Rendimento = 15000.55f;

// PessoaFisica metodosPf = new PessoaFisica();

// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Data de Nascimento : {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// Rendimento: $ {novaPessoaFisica.Rendimento}
// Imposto á pagar: {metodosPf.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
// Maior de idade - datetime : {metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
// Maior de idade - datetime : {(metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Não")}
// Maior de idade - string : {metodosPf.ValidarDataNascimento("01/05/1998")}
// ");

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