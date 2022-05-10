// Exemplo 4 - Condicionais - Informar se o número é divisível 2, 4 e 8
int num,num4,num8;

Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Divisível por 2");
}
if (num % 4 == 0)
{
    Console.WriteLine("Divisível por 4");
}
if (num % 8 == 0)
{
    Console.WriteLine("Divisível por 8");
}
