/* 3) Escreva a seqüência de atribuições,
 * em forma de programa em C# e no 
 * Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.
*/
Console.WriteLine(" --- Exercicio 3 ---");

int A = 90;
int B = 45;

Console.WriteLine("Valor inicial de A: " + A);
Console.WriteLine("Valor inicial de B: " + B);

//Console.Write("Informe o valor do A: ");
//A = int.Parse(Console.ReadLine());

//Console.Write("Informe o valor do B: ");
//B = int.Parse(Console.ReadLine());

int troca = A;
A = B;
B = troca;

Console.WriteLine("Novo valor para A: " + A);
Console.WriteLine("Novo valor para B: " + B);
