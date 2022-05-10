/* 1) Escreva um programa em C# e no 
 * Visual Studio para calcular 
 *    a média aritmética entre 
 *    dois números quaisquer. 
 use /n para quebrar linha 
 */
Console.WriteLine("-- Exercicio 1 --");
float num1, num2, media_arit;

Console.Write("Digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine() );

Console.Write("Digite o segundo numero: ");
num2 = float.Parse(Console.ReadLine() );

media_arit = (num1 + num2) / 2;

Console.WriteLine("Media aritmetica dos 2 numeros: " + media_arit);

