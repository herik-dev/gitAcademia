/*
 * 4) Faça um programa em C# e no Visual Studio
 *    que receba a data na forma DDMMAAAA e imprima
 *    na forma AAAAMMDD e AAMMDD. Note que o dia, o 
 *    mês e o ano devem ser lidos em variáveis diferentes.
 */
Console.WriteLine(" --- Exercicio 4 --- ");
Console.WriteLine(" -------------------");
string ano, mes, dia;
//Colhendo informações do usuario
Console.WriteLine("Informe o dia: ");
dia = Console.ReadLine();
Console.WriteLine("Informe o mes: ");
mes = Console.ReadLine();
Console.WriteLine("Informe o ano: ");
ano = Console.ReadLine();
Console.WriteLine("Alterando a ordem!");
//imprimindo informações para o usuário
Console.WriteLine(ano + mes + dia);
//cortando uma parte do ano
int inicial = 2;
int final = 2;
string sub = ano.Substring(inicial, final);
Console.WriteLine(sub + mes + dia);

