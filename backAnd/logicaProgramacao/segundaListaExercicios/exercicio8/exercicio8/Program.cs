/*
 * 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
 *    A fórmula de conversão é F=(9*C+160)/5.
 */
Console.WriteLine(" --- Exercicio 8 --- ");

// variáveis
double celsius, fahrenheit;

// colhendo dados
Console.WriteLine("Informe a temperatura em celsius: ");
celsius = double.Parse(Console.ReadLine());

Console.WriteLine("Calculando ...");
fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine("A Convertida para fahrenheit: " + fahrenheit);
