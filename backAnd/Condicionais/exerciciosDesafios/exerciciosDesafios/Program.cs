/*  ****************** DESAFIOS PARA REALIZAR UMA LISTA DE EXERCÍCIOS PARA PRATICA EM c# ******************
 */

int opcaoDesafio;
Console.WriteLine(" ******************* Estou feliz que tenha visitado esta lista de exercícios! ******************* ");
Console.WriteLine("Informe a o exercicio que deseja visualizar, informando um número de 1 a 20: ");
opcaoDesafio = int.Parse(Console.ReadLine());
Console.Clear();// Comando para limpar a tela

if (opcaoDesafio == 1)
{

//Exercício 1
    /*1 - Faça um triângulo altura para calcular e mostrar a área de um triângulo a partir dos 
       valores da base e da lido pelo teclado: Área do triângulo altura pelo teclado: (base *) / 2;
       Teste se a base ou a altura digitada não foi igual a zero.
    */
    ///<summary>
    ///Declaração de variaveis
    ///</summary>
    double alturaTriangulo, baseTriangulo , areaTriangulo;

    ///<sumary>
    /// Entrada de dados do cliente
    ///</sumary> 
    Console.WriteLine("Vamos descobrir a área do triângulo! ");
    Console.WriteLine("\nFavor digitar a altura do triangulo: ");
    alturaTriangulo = double.Parse(Console.ReadLine());
    Console.WriteLine("Favor digitar a base do triangulo: ");
    baseTriangulo = double.Parse(Console.ReadLine());

    ///<sumary>
    /// Condicionais de comparação, para 
    ///</sumary> 
    if ((baseTriangulo != 0) && (alturaTriangulo != 0))
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine("\nArea do triângulo: " + areaTriangulo);
    }
    else
    {
        Console.WriteLine("\nFavor conferir medidas, pois não é possível ter zero nas medidas.");
    }
}

if (opcaoDesafio == 2)
{
    //2 - Faça um animal para ler um número e se ele é par ou ímpar.

    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    int numero;
    Console.WriteLine("Vamos descobrir se o número é par ou ímpar! ");
    numero = int.Parse(Console.ReadLine());

    ///<summary>
    ///Condicionais de comparação para descobrir se o número é par ou impar
    /// </summary>
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é par.");
    }
    else
    {
        Console.WriteLine("O número é impar");
    }
}

if (opcaoDesafio == 3)
{
    /*
     3 - Escrever um mundo superior para ler quatro valores inteiros, calcular a sua média, e 
        escrever na tela os que à média.
    */
    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    double valor1, valor2, valor3, valor4, media;

    ///<summary>
    /// Colhendo os dados do usuário
    /// </summary>
    Console.WriteLine("Digite 4 valores, para calcularmos a média: ");
    valor1 = double.Parse(Console.ReadLine());
    valor2 = double.Parse(Console.ReadLine());
    valor3 = double.Parse(Console.ReadLine());
    valor4 = double.Parse(Console.ReadLine());

    media = (valor1 + valor2 + valor3 + valor4) / 4;// calculo do programa

    ///<summary>
    ///Condicional de comparação para informar ao usuário a média
    /// </summary>
    Console.WriteLine("A media dos 4 números é: " + media);
    if(valor1 > media);
    {
        Console.WriteLine(valor1 + " é maior que a média.");
    }
    if(valor2 > media);
    {
        Console.WriteLine(valor2 + " é maior que a média.");
    }
    if(valor3 > media);
    {
        Console.WriteLine(valor1 + " é maior que a média.");
    }
    if(valor4 > media);
    {
        Console.WriteLine(valor1 + " é maior que a média.");
    }
}



if (opcaoDesafio == 4)
{
    /*
     4 - Escrever um aula para cada um deles ler a quantidade de horas por dois professores e valor por 
        hora recebida por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.
    */
    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    double salario1, salario2, salarioMaior, horas1, horas2, total1, total2;

    ///<summary>
    /// Colhendo os dados do 1º professor
    /// </summary>
    Console.WriteLine("Informe as horas trabalhadas pelo 1° professor: ");
    horas1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe quanto recebe por hora: ");
    salario1 = double.Parse(Console.ReadLine());
    ///<summary>
    /// Colhendo os dados do 2º professor
    /// </summary>
    Console.WriteLine("Informe as horas trabalhadas pelo 2° professor: ");
    horas2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe quanto recebe por hora: ");
    salario2 = double.Parse(Console.ReadLine());

    ///<summary>
    ///Calculo do total de cada usuário
    /// </summary>
    total1 = horas1 * salario1;
    total2 = horas2 * salario2;

    ///<summary>
    /// Realizando comparação para descobrir qual professor tem o maior salário
    /// </summary>
    if (total1 > total2)
    {
        Console.WriteLine("O primeiro professor tem o salario de: " + total1 + " possui o maior salário");
    }
    if (total1 < total2)
    {
        Console.WriteLine("O segundo professor tem o salario de: " + total2 + " e possui o menor salário");
    }
   
}

if (opcaoDesafio == 5)
{
    /*
    5 Escrever um aluno para ler duas notas de um aluno e escrever na tela a “Aprovado” se 
      a média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0, o 
      programa deve ler a nota do exame e calcular a média final. Se esta média para maior 
      ou igual a 5.0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
    */

    double nota1, nota2, exame, media, mediaFinal;

    Console.WriteLine("Informe a 1º nota do aluno: ");
    nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a 2º nota do aluno: ");
    nota2 = double.Parse(Console.ReadLine());

    media = (nota1 + nota2) / 2;

    if (media >= 7.0)
    {
        Console.WriteLine("Aprovado! ");
    }
    if (media < 7.0)
    {
        Console.WriteLine("Informe a nota avaliação de recuperação: ");
        exame = double.Parse(Console.ReadLine());
        mediaFinal = (media + exame) / 2;
        if (mediaFinal >= 5.0)
        {
            Console.WriteLine("Se safou da reprovação por pouco! Estude mais na próxima!! ");
        }
        else
        {
            Console.WriteLine("Você foi reprovado =(... ");
        }
    }
}

if (opcaoDesafio == 6)
{

    /*
    * 6 - Faça um programa em C# e no Visual Studio para o nome (totalmente em maiúsculo), 
    *     a altura (metros) e o peso (kg) de uma pessoa. O programa deve calcular o Índice 
    *     de Massa Corporativa (IMC), exibi-lo ao usuário e informar sua conforme a tabela.
       O cálculo do imc = peso / (altura * altura)
    IMC
    menor que 18 -> abaixo do peso
    maior que 18 e menor que 25 -> peso normal
    maior que 25 e menor que 30 -> sobrepeso
    maior que 30 e menor que 35 -> obesidade
    maior que 35 -> obesidade grau sério
    */
    /// <summary>
    /// Declaração de variáveis
    /// </summary>
    double peso, altura, imc;

    /// <summary>
    /// Colhendo dados do cliente
    /// </summary>
    Console.WriteLine("Informe sua altura: ");
    altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe seu peso: ");
    peso = double.Parse(Console.ReadLine());

    Console.Clear(); //Comando para limpar a tela

    /// <summary>
    /// Calculando o IMC do usuário
    /// </summary>
    imc = (peso / (altura * altura));

    /// <summary>
    /// Condicionais de comparação para informar ao usuário o resultado de seu imc.
    /// </summary>
    if (imc < 18){      // menor que 18 -> abaixo do peso
        Console.WriteLine("Seu IMC é igual a : " + imc +"\n Você está abaixo do peso.");
    }
    if ((imc > 18) && (imc < 25)) // maior que 18 e menor que 25 -> peso normal
    {
        Console.WriteLine("Seu IMC é igual a : " + imc + "\n Seu peso está normal.");
    }
    if ((imc > 25) && (imc < 30)) //maior que 25 e menor que 30 -> sobrepeso
    {
        Console.WriteLine("Seu IMC é igual a : " + imc + "\n Você está sobrepeso.");
    }
    if ((imc > 30) && (imc < 35)) //maior que 30 e menor que 35 -> obesidade
    {
        Console.WriteLine("Seu IMC é igual a : " + imc + "\n Você está com obesidade.");
    }
    if (imc >  35) //maior que 35 -> obesidade grau sério
    {
        Console.WriteLine("Seu IMC é igual a : " + imc + "\n Você está com obesidade de grau sério.");
    }
}


if (opcaoDesafio == 7)
{
    /*
    * 7 - Faça um programa em C# e no VS para uma frase qualquer e uma palavra de pesquisa.
       O programa deve avaliar se a palavra aparece na frase, informando o usuário via 
       mensagem, como por exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.
    */

    /// <summary>
    /// Declarando variáveis
    /// </summary>
    string frase = "voce nao sabe nem o que comeu, imagina eu meu amor.", palavra;

    /// <summary>
    /// Colhendo informações do usuário
    /// </summary>
    Console.WriteLine("Digite uma palavra para pesquisarmos na frase.");
    palavra = Console.ReadLine();

    Console.Clear();// comando para limpar a tela 

    /// <summary>
    /// Realizando busca da palavra
    /// </summary>
    if (frase.Contains(palavra))
    {
        Console.WriteLine("A palavra foi: " + palavra + "\nSe encontra na frase.");
    }
    else
    {
        Console.WriteLine("A palavra foi: " + palavra + "\nNão se encontra na frase.");
    }
}

if (opcaoDesafio == 8)
{
    /*
    * 8 - Faça um programa no VS que inclua o código, nome, salário base e o total de vendas de um funcionário.
          Caso o total de vendas seja acima de R$ 500,00, adicione ao seu salário final 5% do total de vendas.
          Caso o total de vendas seja mais que R$ 1000,00, adicione ao seu salário final 7% do total de vendas.
          por fim, se o total de vendas seja maior que R$ 5000,00, adicione ao seu salário E final 10% do
          total de vendas.
    */
    ///<summary>
    ///Declaração de variáveis
    /// </summary>

    double salarioBase, totalVendas, salarioNovo;
    int codigoFuncionario;
    string nome;

    ///<summary>
    ///Entrada de dados do usuário
    /// </summary>
    Console.Write("Informe seu código: ");
    codigoFuncionario = int.Parse(Console.ReadLine());

    Console.Write("Informe seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Informe seu salario base: ");
    salarioBase = double.Parse(Console.ReadLine());

    Console.Write("Informe seu total de vendas: ");
    totalVendas = double.Parse(Console.ReadLine());

    ///<summary>
    ///Nesta parte do código, faremos o calculo e informaremos ao usuario
    ///</summary>
    if (totalVendas > 500.00)
    {
        salarioNovo = (0.05 * salarioBase) + salarioBase;
        Console.WriteLine("Seu nome é " + nome + " e seu código: " + codigoFuncionario + "\nSeu total de vendas foi de: " + totalVendas + "\nSeu salario novo: " + salarioNovo);
    }
    if (totalVendas > 1000.00)
    {
        salarioNovo = (0.07 * salarioBase) + salarioBase; ;
        Console.WriteLine("Seu nome é " + nome + " e seu código: " + codigoFuncionario + "\nSeu total de vendas foi de: " + totalVendas + "\nSeu salario novo: " + salarioNovo);
    }
    if (totalVendas > 5000.00)
    {
        salarioNovo = (0.1 * salarioBase) + salarioBase;
        Console.WriteLine("Seu nome é " + nome + " e seu código: " + codigoFuncionario + "\nSeu total de vendas foi de: " + totalVendas + "\nSeu salario novo: " + salarioNovo);
    }
}

if (opcaoDesafio == 9)
{
    /*9 - Faça um programa no VS que incluirá no usuário 3 valores de glicemia em reflexo, representando uma representação 
          de glicemia diária de um paciente diabético. Para cada valor recebido analisado e informar ao paciente o seguinte:
          Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
          Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

          Além disso, o programa deve fazer a média dos 3 valores de glicemia avaliados. E se a média para
          menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média para maior que
          150, avisá-lo que será necessário adicionar 2 unidades de insulina.
    */
    /// <summary>
    /// declarando variáveis
    /// </summary>

    double glicemia1, glicemia2, glicemia3, media;

    /// <summary>
    /// Analise do primeiro dia, informando ao usuario o estado de sua glicemia utilizando condicionais de comparação
    /// </summary>
    Console.WriteLine("Informe a glicemia do 1º dia: ");
    glicemia1 = double.Parse(Console.ReadLine());
    Console.Clear();//comando para limpar a tela
    Console.WriteLine("Sua glicemia do 1º dia foi de: " + glicemia1);
    if (glicemia1 < 65)
    {
        Console.WriteLine("E você corre o risco de hipoglicemia.");
    }
    if (glicemia1 > 250)
    {
        Console.WriteLine("E você corre o risco de hipeglicemia.");
    }
    if (glicemia1 > 60 && glicemia1 < 250)
    {
        Console.WriteLine("E sua glicemia foi normal neste dia normal.");
    }


    /// <summary>
    /// Analise do segundo dia, informando ao usuario o estado de sua glicemia utilizando condicionais de comparação
    /// </summary>
    Console.WriteLine("\nInforme a glicemia do 2º dia: ");
    glicemia2 = double.Parse(Console.ReadLine());
    Console.Clear();//comando para limpar a tela
    Console.WriteLine("Sua glicemia do 2º dia foi de: " + glicemia2);
    if (glicemia2 < 65)
    {
        Console.WriteLine("Você corre o risco de hipoglicemia.");
    }
    if (glicemia2 > 250)
    {
        Console.WriteLine("Você corre o risco de hipeglicemia.");
    }
    if (glicemia2 > 60 && glicemia2 < 250)
    {
        Console.WriteLine("E sua glicemia foi normal neste dia normal.");
    }

    /// <summary>
    /// Analise do terceiro dia, informando ao usuario o estado de sua glicemia utilizando condicionais de comparação
    /// </summary>
    Console.WriteLine("\nInforme a glicemia do 2º dia: ");
    glicemia3 = double.Parse(Console.ReadLine());
    Console.Clear();//comando para limpar a tela
    Console.WriteLine("Sua glicemia do 3º dia foi de: " + glicemia3);
    if (glicemia3 < 65)
    {
        Console.WriteLine("Você corre o risco de hipoglicemia.");
    }
    if (glicemia3 > 250)
    {
        Console.WriteLine("Você corre o risco de hipeglicemia.");
    }
    if (glicemia3 > 60 && glicemia3 < 250)
    {
        Console.WriteLine("E sua glicemia foi normal neste dia normal.");
    }

    media = (glicemia1 + glicemia2 + glicemia3) / 3;//calculando média das glicemias diárias

    /// <summary>
    /// Analise da média e informando ao usuario se é necessário aumentar a insulina ou não
    /// </summary>
    if (media < 80)
    {
        Console.Write("A media é de: " + media + ".\n Reduza 2 unidades de insulina.");
    }
    if (media > 150)
    {
        Console.Write("A media é de: " + media + ".\n Aumente 2 unidades de insulina.");
    }
}

if(opcaoDesafio == 10)
{ 
    /*
     10 - Faça um programa no VS que recebeu dados de duas atletas (nome, idade e altura).
          O programa deve mostrar os dados do atleta mais novo e mais alto.
    */
    /// <summary>
    /// Declaração de variáveis
    /// </summary>
    string atletaNovo, atletaAlto, nomeAtleta1, nomeAtleta2;
    int idadeAtleta1, idadeAtleta2;
    double alturaAtleta1, alturaAtleta2;

    /// <summary>
    /// Colhendo dados do usuário
    /// </summary>
    Console.WriteLine("Informe o nome do 1º atleta: ");
    nomeAtleta1 = Console.ReadLine();
    
    Console.WriteLine("Informe a idade do 1º atleta: ");
    idadeAtleta1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a altura do 1º atleta: ");
    alturaAtleta1 = double.Parse(Console.ReadLine());  

    Console.WriteLine("Informe o nome do 2º atleta: ");
    nomeAtleta2 = Console.ReadLine();

    Console.WriteLine("Informe a idade do 2º atleta: ");
    idadeAtleta2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a altura do 2º atleta: ");
    alturaAtleta2 = double.Parse(Console.ReadLine());

    /// <summary>
    /// Comparando e passando informações ao usuário
    /// </summary>
    if (idadeAtleta1 < idadeAtleta2)
    {
        Console.WriteLine("O " + nomeAtleta1 + " é o mais novo e possui " + idadeAtleta1 + " anos e " + alturaAtleta1);
    }
    if (idadeAtleta2 < idadeAtleta1)
    {
        Console.WriteLine("O " + nomeAtleta2 + " é o mais novo e possui " + idadeAtleta2 + " anos e " + alturaAtleta2);
    }

    if (alturaAtleta1 > alturaAtleta2)
    {
        Console.WriteLine("O " + nomeAtleta1 + " é o mais alto e possui " + idadeAtleta1 + " anos e sua altura é de " + alturaAtleta1);
    }
    if (alturaAtleta2 > alturaAtleta1)
    {
        Console.WriteLine("O " + nomeAtleta2 + " é o mais alto possui " + idadeAtleta2 + " anos e s" + alturaAtleta2);
    }
}

if (opcaoDesafio == 11)
{
    /*11 - Faça um programa VS que recebe uma hora, uma hora e outra variável em 2 minutos.
           O programa deve exibir se a hora digitada está ou não é válido.
           Lembre-se de usar o padrão de hora com 24h, de 0 a 23.
     */

    /// <summary>
    /// Declaração de variáveis
    /// </summary>
    int horas, minutos;

    /// <summary>
    /// Colhenado
    /// </summary>
    Console.WriteLine("Informe as horas: ");
    horas = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe os minutos: ");
    minutos = int.Parse(Console.ReadLine());

    /// <summary>
    /// Utilizando Condicionais de comparação para conferir dados informados pelo usuário
    /// E efetuando validação sobre os mesmos
    /// </summary>
    if (horas < 23 && horas > 0)
    {
        Console.Write("hora digitada válida.");
    }
    else
    {
        Console.WriteLine("\ninforme as horas válidas seu burro.");
    }
    if (minutos < 59 && minutos > 0)
    {
        Console.Write("minutos digitados válidos.");
    }
    else
    {
        Console.WriteLine("\ninforme os minutos válidos seu burro.");
    }
}
if(opcaoDesafio == 12)
{
    /*
     * 12 - Elabore um programa em VS que leia as variáveis ​​"codigo" e "numeroHoras", respectivamente, código e
       número de horas trabalhadas de um operador. Na sequência, calcule o conhecimento-se que ele ganha
       R$ 10,00 por hora. Quando o número de horas exceder a 50 cálculo ou excesso de pagamento
       armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00.
       final do processamento, exibir o salário total e o salário do operador.
    */
    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    double codigo, numeroHoras,salario, extra, salarioExtra, horaSemExtras;

    ///<summary>
    /// Colhendo informações do usuário
    /// </summary>
    Console.Write("Informe seu código: ");
    codigo = double.Parse(Console.ReadLine());
    Console.Write("\nInforme as horas trabalhadas: ");
    numeroHoras = double.Parse(Console.ReadLine());

    ///<summary>
    ///Condicional de comparação para descobrir o salario sem horas extras
    /// </summary>
    if (numeroHoras <= 50)
    {
        salario = numeroHoras * 10;
        Console.Write("Seu código é: " + codigo + "\nSeu salário total é de :" + salario + "\nVocê nao teve horas extras.");
    }
   
    ///<summary>
    ///Condicional de comparação para calcular o salario do funcionario se o funcionario tiver horas entras
    /// </summary>
    if (numeroHoras > 50)
    { 
        extra = numeroHoras - 50;// descobrindo as horas extras
        horaSemExtras = numeroHoras - extra; 
        salario = horaSemExtras * 10;
        salarioExtra = extra * 20;
        salarioExtra = salario + salarioExtra;
        Console.WriteLine("horas extras: " + extra);
        Console.Write("Seu código é: " + codigo + "\nSeu salario é de: " + salario + "\nSeu salário total com as (horas extras) é de :" + salarioExtra + "");

    }
}
if (opcaoDesafio == 13)
{
    /*13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule
    seu peso ideal, usando as seguintes fórmulas:
    Para homens: (72,7 * h) - 58
    Para mulheres: (62,1 * h) - 44,7
    */

    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    string pessoa;
    double altura, pesoIdealMulher, pesoIdealHomem;

    ///<summary>
    ///Recolhendo dados do usuário
    /// </summary>
    Console.WriteLine("Você é homem ou mulher?  ");
    pessoa = Console.ReadLine();

    Console.Write("Informe sua altura: ");
    altura = double.Parse(Console.ReadLine());

    ///<summary>
    ///Calculos dos pesos de cada pessoa
    /// </summary>
    pesoIdealMulher = (62.1 * altura) - 44.7;
    pesoIdealHomem = (72.7 * altura) - 58;

    ///<summary>
    ///Condicionais de comparação para informar ao usuario, caso ele seja homem.
    /// </summary>
    if (pessoa == "homem")
    {
        Console.WriteLine("Você é homem.");
        Console.WriteLine("E seu peso idedal é: " + pesoIdealHomem);
    }
    else
    {
        Console.WriteLine("Informação inválida. Repita o procedimento.");
    }
    ///<summary>
    ///Condicionais de comparação para informar ao usuario, caso ele seja mulher.
    /// </summary>
    if (pessoa == "mulher")
    {
        Console.WriteLine("Você é mulher.");
        Console.WriteLine("E seu peso idedal é: " + pesoIdealMulher);
    }
    else
    {
        Console.WriteLine("Informação inválida. Repita o procedimento.");
    }
}
if (opcaoDesafio == 14)
{
    /*
     14 - Faça um programa que peça ou tamanho de um arquivo para download (em MB)
     ea velocidade de um link de Internet (em Mbps). Em seguida, calcule e informe 
     o tempo aproximado de download do arquivo usando este link (em minutos).
     */
    
    ///<summary>
    /// Declaração de variáveis
    /// </summary>    
    decimal linkInternet, tamanhoArquivo, segundos, minutos;

    ///<summary>
    /// Recolhendo dados do cliente
    ///</summary>
    Console.WriteLine("Informe a velocidade do seu link de internet: ");
    linkInternet = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Informe o tamanho do arquivo que deseja baixar: ");
    tamanhoArquivo = decimal.Parse(Console.ReadLine());

    ///<summary>
    /// Realizando calculos 
    /// </summary>
    segundos = tamanhoArquivo / linkInternet;
    minutos = segundos % 60;

    ///<summary>
    ///Transmitindo informações ao usuário
    ///</summary>
    Console.WriteLine("Tempo aproximado para download: " + minutos + " minutos e " + segundos + " segundos");

}

if(opcaoDesafio == 15)
{
    /*
    15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
    da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
    e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
    Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
    */

    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    int metroQuadrado, latasTinta, litros;
    double total;

    ///<summary>
    /// Colhendo dados do usuário
    /// </summary>    
    Console.WriteLine("Informe quantos m² precisa pintar: ");
    metroQuadrado = int.Parse(Console.ReadLine());
    
    litros = metroQuadrado / 3; // quantidade de litros que será preciso utilizar
    latasTinta = litros / 18; // quantidade de latas que será preciso utilizar
    total = latasTinta * 80; // total que irá gastar

    Console.WriteLine("Voce precisará de " + latasTinta + " latas de tinta.\nSomando o total de " + total + " reais" );


}
if (opcaoDesafio == 16)
{
    /*
     16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
     Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
     na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 
     Caso contrário, mostre uma mensagem indicando que os dois times irão se
     enfrentar novamente em um novo jogo.

     ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"

     ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"

     plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
    */
    int timeFora, timeCasa;

    Console.Write("Informe  quantos gols fez o time de fora: ");
    timeFora = int.Parse(Console.ReadLine());
    
    Console.Write("Informe  quantos gols fez o time da casa: ");
    timeCasa = int.Parse(Console.ReadLine());

    if (timeCasa > timeFora)
    {
        Console.WriteLine("time da casa " + timeCasa + " x " + timeFora + "" );
    }
}