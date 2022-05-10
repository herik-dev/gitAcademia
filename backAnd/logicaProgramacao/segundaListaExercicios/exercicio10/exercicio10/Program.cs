/*
 * 10) Um programa para gerenciar os mecanismos de saque de uma caixa eletrônica deve possuir algum
 *     para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
 *     testado o saque. Um conceito possível seria da “distribuição ótima” no sentido de que as
 *     notas de menor valor foram distribuídas em número mínimo possível.
 *     Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa Deveria indicar uma nota de R$ 50,00,
 *     três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
 *     Escreva um programa que receba o valor da quantia solicitada e restitua a distribuição das notas
 *     de acordo com o critério da “distribuição ótima”.
 */
Console.WriteLine("         --- Exercicio 10 ---");
Console.WriteLine(" --- Bem vindo ao banco criativo --- ");
Console.WriteLine("    Valor mínimo para saque é 2,00");
Console.WriteLine("");
//declaração de variáveis
int dinheiro;
Console.Write("Qual valor deseja sacar? ");
dinheiro = int.Parse(Console.ReadLine());

if (dinheiro % 2 == 0)
{
    int n100 = dinheiro / 100; //contagem das notas de 100R$
    int resto = dinheiro - (n100 * 100); //valor menos as notas de 100.
    int n50 = resto / 50;//contagem das notas de 50R$
    resto = resto - (n50 * 50);
    int n20 = resto / 20;//contagem das notas de 20R$
    resto = resto - (n20 * 20);
    int n10 = resto / 10;//contagem das notas de 10R$
    resto = resto - (n10 * 10);
    int n5 = resto / 5;//contagem das notas de 5R$
    resto = resto - (n5 * 5);
    int n2 = resto / 1;//contagem das notas de 2R$
    resto = resto - (n2 * 2);
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Seu saque ficará da seguinte forma:");
    Console.WriteLine();
    if ((n100 != 0))
    {
        Console.WriteLine("Notas de 100R$:  " + n100);
        Console.WriteLine();        
    }
    if ((n50 != 0))
    {
        Console.WriteLine("Notas de 50R$:  " + n50);
        Console.WriteLine();
    }
    if ((n20 != 0))
    {
        Console.WriteLine("Notas de 20R$:  " + n20);
        Console.WriteLine();
    }
    if ((n10 != 0))
    {
        Console.WriteLine("Notas de 10R$:  " + n10);
        Console.WriteLine();
    }
    if ((n5 != 0))
    {
        Console.WriteLine("Notas de 5R$:  " + n5);
        Console.WriteLine();
    }
    if ((n2 != 0))
    {
        Console.WriteLine("Notas de 2R$:  " + n2);
        Console.WriteLine();
    }
    Console.ReadKey();
}
else
{
    Console.WriteLine("Valor inválido, efetue a operação novamente.");        
}