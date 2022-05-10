/*
 * 12) Um motorista de táxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que 
 *     o preço do combustível é de R$6,90, escreva um animal para ler a marcação do odômetro 
 *     (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de 
 *     litros de combustível gasto e o valor total (R$) recebido dos passageiros. 
 *     Calcule e escreva a média do consumo em Km/l
 *     lucro líquido do dia.
 *
 *     Fórmulas: 
 *     Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
 *     Média do consumo = Total quilometragem/quantidade de combustível gasto
 *     Lucro do dia = Valor total recebido - (quantidade de combustível combustível * 6,90)
 */
Console.WriteLine(" --- Exercicio 12 --- ");

// declaração das variáveis
double litros_gasto = 0, total_km = 0, total_recebido = 0, media_consumo = 0, lucro_dia = 0;

// Entrada de dados informados pelo usuário no início do dia
Console.WriteLine("Informe a quilometragem do início do dia: ");
double inicio_dia = double.Parse(Console.ReadLine());//declaração de variável com entrada de dados

// Entrada de dados informados pelo usuário no fim do dia
Console.WriteLine("Informe a quilometragem do fim do dia: ");
double fim_dia = double.Parse(Console.ReadLine());//declaração de variável com entrada de dados
Console.WriteLine("Informe quantos litros de combustível gastou: ");//gasto de combustivel
litros_gasto = double.Parse(Console.ReadLine());
Console.WriteLine("Informe quanto recebeu dos passageiros no total: ");
total_recebido = double.Parse(Console.ReadLine());

// calculo de kilomentragem 
total_km = (inicio_dia - fim_dia)*1;

//calculo da media de consumo
media_consumo = 1*(total_km / litros_gasto);

//calculo do lucro do dia
lucro_dia = ((litros_gasto * 6.90) - total_recebido);

//impressão de informações para o usuário final
Console.WriteLine("Kilometragem gasta hoje: " + total_km + "km/l");
Console.WriteLine("Media de consumo: " + media_consumo);
Console.WriteLine("Lucro do dia: " + lucro_dia);
