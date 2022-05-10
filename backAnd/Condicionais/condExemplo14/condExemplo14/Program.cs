// Exemplo 14 - Operadores logicos

int num;
Console.WriteLine("Digite um numero: ");
num=int.Parse(Console.ReadLine());
if(num == 10)
{
    Console.WriteLine("\n\nVoce acertou!\n");
    Console.WriteLine("O numero e igual a 10.\n");
}
else
{
    if(num > 10)
    {
        Console.WriteLine("O numero eh maior que 10.");
    }
    else
    {
        Console.WriteLine("O numero eh menor que 10.");
    }
}