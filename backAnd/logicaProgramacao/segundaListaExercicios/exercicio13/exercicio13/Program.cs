/*
 * 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. 
 * Ela paga a cada vendedor 2 contratar, mais uma contratação de 15% sobre o vendedor
 * preço de custo de cada bicicleta vendida. Desenvolva um animal que leia o valor do 
 * salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
 * pelo vendedor, calcule e mostre: o salário do empregado
 */
Console.WriteLine(" --- Exercicio 13 ---");

// Entrada do preço do salário mínimo
Console.WriteLine("Informe seu salario: ");
double salario = double.Parse(Console.ReadLine()); //entrada no teclado

// Entrada do valor de custo de cada bicicleta
Console.WriteLine("Informe o preço de custo de cada bicicleta: ");
double precoBike = double.Parse(Console.ReadLine()); //entrada no teclado

//Entrada da quantidade de bicicletas por funcionário
Console.WriteLine("Informe quantas bicicletas vendeu: "); 
int quantidadeBike = int.Parse(Console.ReadLine()); //entrada no teclado

// variáveis auxiliares
double novoSalario=0, reajusteBike=0, comissao = 0, calcular = 0;

// calculo do preço da bicicleta com seu devido reajuste
reajusteBike = (precoBike / 2);
precoBike = (precoBike + reajusteBike);//aumento de 50% do valor

// calculo de comissao sobre cada bicicleta vendida
comissao = (0.15*precoBike);

// calculo do salario comissionado
calcular = (quantidadeBike * comissao);
novoSalario = (calcular + salario);


// Saída de informações para o usuário
Console.WriteLine("O salario comissionado do funcionario é de: " + novoSalario);