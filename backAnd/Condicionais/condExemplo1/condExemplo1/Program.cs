// Exemplo 1,2 e 3 - condicional
// Informar se número é negativo

int num;
Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Positivo!");
}
else if (num < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Zero");
}