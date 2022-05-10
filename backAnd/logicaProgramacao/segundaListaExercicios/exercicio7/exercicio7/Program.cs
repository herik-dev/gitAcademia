/*
 * 7) Escreva um programa em C# e no Visual Studio que leia o número 
 *    de um vendedor, ou seu salário fixo, o total de vendas por ele
 *    efetuado e o percentual que ganha sobre o total de vendas.
 *    Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
 */
Console.WriteLine(" --- Exercicio 7 --- ");

String nomeVendedor;
double salarioFixo, comissao, salarioTotal, totalVendas;

//Coletando informações do usuário
Console.WriteLine("Vendedor, informe seu nome: ");
nomeVendedor = Console.ReadLine();
Console.WriteLine("Informe o seu salario: ");
salarioFixo = double.Parse(Console.ReadLine());
Console.WriteLine("Gentileza, informe o seu total de vendas: ");
totalVendas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o percentual que ganha sobre o total das vendas: ");
comissao = double.Parse(Console.ReadLine());

//Calculando os dados do usuário
comissao = (comissao / totalVendas) * salarioFixo;
salarioTotal = salarioFixo + comissao;

//imprimindo informações para o usuário
Console.WriteLine("Salario total do vendedor " + nomeVendedor + " é de :" + salarioTotal);
