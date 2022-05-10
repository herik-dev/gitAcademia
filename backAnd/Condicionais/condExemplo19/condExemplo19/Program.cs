// Exemplo 19
double a, b, c;
Console.WriteLine("\nInforme tres numeros: ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
if(a < (b + c) && b < (a + c) && c < (a + b))
{
    Console.WriteLine("\nE um algoritmno");
    if(a == b && b == c)
    {
        Console.WriteLine("equilatero"); 
    }
    else if(a == b || a == c || b == c)
    {
        Console.WriteLine("Isosceles");
    }
    else
    {
        Console.WriteLine("escaleno");
    }
}
else
{
    Console.WriteLine("\nNao e um triangulo");
}