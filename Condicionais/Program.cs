// perguntar o nome da cliente
// perguntar se é cliente pessoa juridica ou pessoa fisica
// caso seja juridica, perguntar cnpj
// caso seja fisica, perguntar cpf
// escrever o resultado


Console.WriteLine("Qual o nome do cliente?");
String nomeDoCliente = Console.ReadLine();

Console.WriteLine("Para física digite 1 e para juridica digite 2");
String pessoaFisicaOuJuridica = Console.ReadLine();

String registroNacional;
String textoCpfOuCnpj;

if(pessoaFisicaOuJuridica == "2")
{
    Console.WriteLine("Digite seu CNPJ");
    registroNacional = Console.ReadLine();
    textoCpfOuCnpj = "CNPJ: ";
}
else
{
    Console.WriteLine("Digita seu CPF");
    registroNacional = Console.ReadLine();
    textoCpfOuCnpj = "CPF: ";
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Nome do cliente: " + nomeDoCliente);
Console.WriteLine("Pessoa Física ou Jurídica: " + pessoaFisicaOuJuridica);
Console.WriteLine(textoCpfOuCnpj + registroNacional);
