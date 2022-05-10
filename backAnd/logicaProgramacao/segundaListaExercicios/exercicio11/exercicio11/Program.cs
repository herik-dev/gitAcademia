/*  
 *  11 escreveu um branco para ler o número de votos de um município, o número, nulos e válidos. 
 *  Calcule e escreva o percentual que cada um representa em relação ao total de energia.
 */
Console.WriteLine("             --- Exercicio 11 ---");
Console.WriteLine("Bem vindo ao municipio da loucura e corrupção! ");
Console.WriteLine("Hoje é dia de eleger o seu corrupto favorito!");
// Declaração de variáveis
string voto = "sim";
int nulo = 0, valido = 0, result = 0;
double porcentagemn = 0, porcentagemv = 0;
// Laço de repetição para calculo de votos
while (voto != "sair")
    {
    Console.WriteLine("Digite [VOTAR] para votar, [NULO] para anular o voto ou digite sair : ");
    voto = Console.ReadLine();

    if(voto == "nulo" || voto == "NULO")
    {
        nulo++;
    }
    if(voto == "votar" || voto == "VOTAR")
    {
        valido++;
    }

}
Console.Clear();//comando para limpar a tela
result = (nulo + valido); // descobrindo o total de votos

//variáveis para calcular
double calc_nulo = nulo;
double calc_valido = valido;

//calculo de porcentagem dos votos
calc_nulo = (calc_nulo / result)*100;
calc_valido = (calc_valido / result)*100;


//Informando ao usuario o resultado da eleição
Console.WriteLine("Total de votos: " + result);// V
    Console.WriteLine("porcentagem de votos nulos : " + calc_nulo + "%");
    Console.WriteLine("porcentagem de votos válidos : " + calc_valido + "%");