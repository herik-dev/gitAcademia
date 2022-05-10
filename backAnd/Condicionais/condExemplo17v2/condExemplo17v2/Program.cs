// Exemplo 17v2 - Número positivo e impar
int val;
Console.WriteLine("Digite um número: ");
val = int.Parse(Console.ReadLine());

if (val > 0 && !(val % 2 == 0))
{
    Console.WriteLine("O número é impar e positivo");
}
