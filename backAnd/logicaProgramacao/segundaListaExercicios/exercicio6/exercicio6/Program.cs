/*  
 *  6) Escreva um programa em C# e no Visual Studio que leia os 
 *  dados para o parafuso A e para o parafuso B, 
 *  isto é, o código, a quantidade de peças e o valor 
 *  unitário de cada parafuso e a porcentagem 
 *  de IPI (única) a ser acrescentada.
 */
Console.WriteLine(" --- Exercicio 6 --- ");
// código, quantidade, valor
//declaração de variaveis
int codA, codB;
double valorA, valorB, calcA, novo, calcB, quantA, quantB, multiplicacao;


//entrada de dados A
Console.WriteLine("Favor o código do parafuso A: ");
codA = int.Parse(Console.ReadLine());
Console.WriteLine("Favor informar a quantidade de parafusos: ");
quantA = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor do parafuso: ");
valorA = double.Parse(Console.ReadLine());

//Calculando
calcA = (0.05*valorA);
novo = valorA + calcA;
multiplicacao = quantA * novo;
Console.WriteLine("Valor total com imposto IPI sobre o parafuso A: " +multiplicacao);

//zerando variáveis de apoio
novo = 0;
multiplicacao = 0;

//entrada de dados B
Console.WriteLine("Favor o código do parafuso B: ");
codB = int.Parse(Console.ReadLine());
Console.WriteLine("Favor informar a quantidade de parafusos: ");
quantB = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor do parafuso: ");
valorB = double.Parse(Console.ReadLine());

//Calculando
calcB = (0.05 * valorB);
novo = valorB + calcB;
multiplicacao = quantB * novo;
Console.WriteLine("Valor total com imposto IPI sobre o parafuso A: " + multiplicacao);

