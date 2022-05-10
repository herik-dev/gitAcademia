/* 2) Escreva um programa em C# e no 
 * Visual Studio para calcular 
 *    a média aritmética entre 
 *    quatro números quaisquer. 
 use /n para quebrar linha 
 */
Console.WriteLine("-- Exercicio 2 --");
float num1, num2, num3, num4, media_arit;

Console.Write("Digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
num2 = float.Parse(Console.ReadLine());

Console.Write("Digite o terceiro numero: ");
num3 = float.Parse(Console.ReadLine());

Console.Write("Digite o quarto numero: ");
num4 = float.Parse(Console.ReadLine());

media_arit = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("Media aritmetica dos 4 numeros: " + media_arit);