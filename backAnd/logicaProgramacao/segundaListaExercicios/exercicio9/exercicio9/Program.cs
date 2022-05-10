/*  
 * 9) Uma vende seus produtos no sistema de entrada mais duas ofertas, sendo a entrada maior
 *    do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
 *    
 *    Por exemplo, se o valor da entrada é igual a R$ 27,0, e as duas prestações são iguais a R$ 27,0;
 *    se o valor da entrega 2 por R$ 30,75 a entrada é de R$ 1,75 e as duas 102 são iguais a R$ 100.
 *    Escreva um programa em C# e no Visual Studio que aceita o valor da entrega e entrega o valor
 *    da entrada e das duas regras, de acordo com as acima.
 *    Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção eo
 *    conseqüente pagamento dos boletos das duas prestações.
 */
Console.WriteLine(" --- Exercicio 9 --- ");
// declaração de variáveis
int entrada, entrega, auxiliar, valor;
string booleana;

// entrada de dados do usuário
Console.WriteLine("Informe o valor do produto(sem virgulas): ");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Deseja parcelar, você pode parcelar até 2 vezes? Sim ou não. ");
booleana = Console.ReadLine();

// estrutura de repetição para calculos
if (booleana == "sim")
{
    Console.WriteLine("O valor da entrada igual ou maior que as parcelas: ");
    entrada = int.Parse(Console.ReadLine());
    auxiliar = - entrada + valor;
    auxiliar = auxiliar / 2;
    Console.WriteLine("O valor das parcelas ficará em: " + auxiliar);

}
else {
    Console.WriteLine("Valor a pagar integral: " + valor);
}
Console.WriteLine("Obrigado pela visita, volte sempre");
