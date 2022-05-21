int opcaoExercicio;

Console.WriteLine("Informe o número do exercício que deseja testar: ");
opcaoExercicio = int.Parse(Console.ReadLine());


if(opcaoExercicio == 1)
{
    /*
    1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
    (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
    Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

    Exemplo:
    Digite um número inteiro positivo: -8
    Valor incorreto!
    Digite um número inteiro positivo: 8
    Numero digitado: 8
    Números inteiros pares entre 1 e 8: 2, 4, 6.
    */
    ///<summary>
    /// Declaração de Variáveis
    ///</summary>
    int numeros=0, i=0;
    
    ///<summary>
    /// Estrutura de repetição para que irá se repetir enquanto o a entrada do usuário for menor que 0
    ///</summary>
    do
    {
            Console.WriteLine("Digite um número inteiro positivo correto!: ");
            numeros = int.Parse(Console.ReadLine());
        ///<summary>
        /// Estrutura de comparação para que faça a função for enquanto o contador i for menor que a entrada do usuário
        ///</summary>
        Console.Clear();
        Console.WriteLine($"O número escolhido foi: {numeros}");
        if (i < numeros)
            {
                for (i = 0; i <= numeros; i++)
                {
                    ///<summary>
                    /// Imprimindo todos os números pares de 0 até o número inteiro informado pelo usuário
                    /// </summary> 
                    if (i % 2 == 0)
                    { 
                        Console.Write($"\nNúmero inteiro par: {i}");
                    }
                }

            }
    } while (numeros < 0);
}

if (opcaoExercicio == 2)
{
    /*
    2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
    informar um outro número. Caso positivo, o programa em VS deve ser repetido.

    Exemplo:
    Digite um número inteiro positivo: 8
    Numero digitado: 8
    Números inteiros pares entre 1 e 8: 2, 4, 6.

    Deseja informar outro número (s/n)? S

    Digite um número inteiro positivo: 12
    Numero digitado: 20
    Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

    Deseja informar outro número (s/n)? N  
    */

    ///<summary>
    /// Declaração de Variáveis
    ///</summary>
    int numeros = 0, i = 0;
    string escolha = "a";
    ///<summary>
    /// Estrutura de repetição para que irá se repetir enquanto o a entrada do usuário for menor que 0
    ///</summary>
    do
    {
        Console.WriteLine("Digite um número inteiro positivo correto!: ");
        numeros = int.Parse(Console.ReadLine());
        ///<summary>
        /// Estrutura de comparação para que faça a função for enquanto o contador i for menor que a entrada do usuário
        ///</summary>
        Console.Clear();
        Console.WriteLine($"O número escolhido foi: {numeros}");
        if (i < numeros)
        {
            for (i = 0; i <= numeros; i++)
            {
                ///<summary>
                /// Imprimindo todos os números pares de 0 até o número inteiro informado pelo usuário
                /// </summary> 
                if (i % 2 == 0)
                {

                    Console.Write($"\nNúmero inteiro par: {i}");
                }
            }

        }
        Console.Write("\nDeseja informar outro número (s/n)?");
        escolha = Console.ReadLine();
    } while (escolha.ToLower() != "n");//tolower transforma string em minusculo

}
if (opcaoExercicio == 3)
{
    /*
    3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
    Se o usuário digitar 0 o programa em VS deve parar. 
    Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
    */
    ///<summary>
    /// Declaração de Variáveis
    ///</summary>
    int numeros = 0;

    ///<summary>
    /// Estrutura de repetição para que irá se repetir enquanto o a entrada do usuário não for 0
    ///</summary>
    do
    {
        Console.Write("Digite um número ou 0 para fechar: \n");
        numeros = int.Parse(Console.ReadLine());
        Console.Clear();
        if(numeros % 2 == 0)
        {
            Console.Write($"\n{numeros} é um número par.\n");
        }else if(numeros %2 == 1)
        {
            Console.WriteLine($"\n{numeros} é um número impar.\n");
        }else if(numeros % 2 == 1 && numeros > 1)
        {
            Console.WriteLine($"\n{numeros} é um número impar primo.\n");
        }
    } while (numeros != 0);
      
}

if (opcaoExercicio == 4)
{
    /* 
    4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
    Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
    Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
    Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
    escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
    de votos em branco. 
    */
    Console.Clear();//comando para limpar a tela
    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    int votosJoao = 0, votosZeca = 0, votosbranco = 0;
    string final = "", voto = "";

    ///<summary>
    ///Laços de repetição para cotar os votos, o mesmo encerrará quando o usuário digitar "fim"
    /// </summary>
    do
    {
        Console.WriteLine("Caso deseja encerrar a eleição, digite fim");
        final = Console.ReadLine();
        if (final.ToUpper() != "FIM")
        {

            Console.Clear();
            Console.Write("Opções de voto: \nPara votar em JOAO, tecle 12 \nPara votar em ZECA, tecle 14 \nPara votar em branco, digite branco\n-----------------\n");
            voto = Console.ReadLine();
            Console.Clear();
            if (voto.ToUpper() == "12")
            {
                votosJoao++;
            }
            if (voto.ToUpper() == "14")
            {
                votosZeca++;
            }
            if (voto.ToUpper() == "BRANCO")
            {
                votosbranco++;
            }
            else
            {
                Console.WriteLine("Digito incorreto. Repita a operação.");
            }
        }

        Console.Clear();//comando para limpar a tela
        ///<summary>
        /// Condicionais de comparação para descobrir quem teve mais votos.
        /// </summary>
    } while (final.ToUpper() != "FIM");
    if(votosJoao > votosZeca && votosJoao > votosbranco)
    {
        Console.Write($"\nJoão venceu a eleição com {votosJoao}");
    }
    if (votosZeca > votosJoao && votosZeca > votosbranco)
    {
        Console.Write($"\nZeca venceu a eleição com {votosZeca}");
    }
    if (votosJoao == votosZeca && votosJoao != votosbranco)
    {
        Console.Write($"\nHouve empate entre Joao e Zeca");
    }
    else
    {
        Console.WriteLine("\nEleição teve números de votos em branco maior que os candidatos.\n");
    }
        Console.WriteLine($"\nResultado das eleições: \nVotos em Joao: {votosJoao}.\nVotos no Zeca: {votosZeca}.\nVotos em Branco{votosbranco}.");
        

}

if (opcaoExercicio == 5)
{
    /*
    5. Modifique o programa em VS anterior para aceitar votos nulos 
    (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
    Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.
    */

    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    Console.Clear();
    int votosJoao = 0, votosZeca = 0, votosbranco = 0, votosnulo = 0, totalvotos=0;
    string final = "", voto = "";
    
    ///<summary>
    ///Laços de repetição para cotar os votos, o mesmo encerrará quando o usuário digitar "fim"
    /// </summary>
    do
    {
            Console.WriteLine("Caso deseja encerrar a eleição, digite fim");
            final = Console.ReadLine();
            if (final.ToUpper() != "FIM")
            {

                Console.Clear();
                Console.Write("Opções de voto: \nPara votar em JOAO, tecle 12 \nPara votar em ZECA, tecle 14 \nPara votar em branco, digite branco\nPara anular o voto, digite nulo\n-----------------\n");
                voto = Console.ReadLine();
                Console.Clear();
                if (voto.ToUpper() == "12")
                {
                    votosJoao++;
                }
                if (voto.ToUpper() == "14")
                {
                    votosZeca++;
                }
                if (voto.ToUpper() == "BRANCO")
                {
                    votosbranco++;
                }
                if (voto.ToUpper() == "NULO")
                {
                    votosnulo++;
                }
                else
                {
                    Console.WriteLine("Digito incorreto. Repita a operação.");
                }
            }

            Console.Clear();//comando para limpar a tela
        
        ///<summary>
        /// Condicionais de comparação para descobrir quem teve mais votos ou se a eleição foi anulada.
        /// </summary>
    } while (final.ToUpper() != "FIM");
        if (votosJoao > votosZeca && votosJoao > votosbranco && votosJoao > votosnulo)
        {
            Console.Write($"\nJoão venceu a eleição com {votosJoao}");
        }
        if (votosZeca > votosJoao && votosZeca > votosbranco && votosZeca > votosnulo)
        {
            Console.Write($"\nZeca venceu a eleição com {votosZeca}");
        }
        if (votosJoao == votosZeca && votosJoao != votosbranco && votosbranco > votosnulo)
        {
            Console.Write($"\nHouve empate entre Joao e Zeca");
        }
        if (votosbranco > votosZeca && votosbranco > votosJoao && votosbranco > votosnulo)
        {
            Console.WriteLine("\nEleição teve números de votos em branco maior que os candidatos.\n");
        }
        else
        {
        Console.WriteLine("\nEleição anulada, devido ao número de votos nulos ser o maior.\n");
        }
    totalvotos = (votosbranco + votosJoao + votosnulo + votosZeca);
    Console.WriteLine($"\nTotal de votos: {totalvotos}.");
    Console.WriteLine($"\nResultado das eleições: \nVotos em Joao: {votosJoao}.\nVotos no Zeca: {votosZeca}.\nVotos em Branco: {votosbranco}.\nVotos nulos: {votosnulo}.");
}


if (opcaoExercicio == 6)
{
    /* 
    6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
    ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
    Ao final, mostre a idade digitada.
    */
    ///<summary>
    ///Declaração de variável
    /// </summary>
    int idade;
    
    ///<summary>
    ///Condicional de repetição para repetir ate o usuario para de digitar 0
    /// </summary>
    do
    {
        Console.WriteLine("Qual e a sua idade? (caso informe 0, não vou parar de perguntar) ");
        idade = int.Parse(Console.ReadLine());
    } while (idade == 0);
    Console.Clear();
    Console.WriteLine($"A idade digitada foi: {idade}");
}

if(opcaoExercicio == 7)
{
    /* 
    7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
    A cada solicitação, teste se o usuário informou um valor válido. 
    Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
    informe que ele está incorreto e saia do programa em VS. 
    Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
    informe que está errada e saia. Se estiver correta, solicite o salário. 
    Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
    Se estiver correto, mostre todos os valores lidos.
    */
    
    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    string nome;
    int idade;
    double salario;

    ///<summary>
    ///Estruturas de repetição para forçar o usuário a informar as informações corretas
    /// </summary>
    do
    {
        Console.WriteLine("Informe seu nome corretamente: ");
        nome = Console.ReadLine();
    }while(nome == "");
    do
    {
        Console.WriteLine("Informe sua idade corretamente: ");
        idade = int.Parse(Console.ReadLine());
    } while (idade <= 0);
    do
    {
        Console.WriteLine("Informe seu salario corretamente: ");
        salario = int.Parse(Console.ReadLine());
    } while (salario <= 0);
    Console.Clear();
    Console.WriteLine($"Seu nome: {nome}\nSua idade: {idade}\nSeu salário: {salario}");
}
if(opcaoExercicio == 8) 
{
    /* 
    8. Faça um programa em VS que solicite um numero inteiro. 
    Se o numero não for inteiro, solicite-o até que seja. 
    após, informe se ele é par ou impar. 
    Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
    */
    int numero = 1;
    string opcao;

    ///<summary>
    ///Estrutura de repetição e comparação para descobrir se o numero informado pelo usuário é impar
    /// </summary>
    do
    {
        Console.WriteLine("Informe um número inteiro: ");
        numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é impar.");
        }
        ///<summary>
        ///Entrada de dados, para saber se o usuário quer repetir a operação
        /// </summary>
        Console.WriteLine("Deseja repetir? (s/n)");
        opcao = Console.ReadLine();
    } while (opcao.ToUpper() == "n");
}

if (opcaoExercicio == 9)
{
    /*
    9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
    o zoológico num determinado dia, imprimindo:
    Quantas pessoas tem entre 1 e 3 filhos.
    Quantas pessoas tem entre 4 e 7 filhos.
    Quantas pessoas tem mais de 8 filhos.
    Quantas pessoas não tem filhos.
    */
    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    int i, filhos, pessoas1Filhos = 0, pessoas4Filhos = 0, pessoas8Filhos = 0, pessoasSemFilhos = 0;
    
    ///<summary>
    ///Laço de repetição para repetir o procedimento de calculo 30 vezes, conforme o usuario informa
    /// </summary>
    for (i = 0; i <= 30; i++)
    {
        Console.WriteLine("Em forma numérica, informe quantos filhos tem: ");
        filhos = int.Parse(Console.ReadLine());
        ///<summary>
        ///Estrutura de comparação para descobrir a contagem de filhos de cada pessoa
        /// </summary>
        if (filhos >= 1 && filhos <= 3)
        {
            pessoas1Filhos++;
        }
        if (filhos >= 4 && filhos <= 7)
        {
            pessoas4Filhos++;
        }
        if (filhos >= 8)
        {
            pessoas8Filhos++;
        }
        if (filhos == 0)
        {
            pessoasSemFilhos++;
        }
    }

    Console.Clear();
    ///<summary>
    ///Informando ao usuário a quantidade de filhos que 30 pessoas possuem
    /// </summary>
    Console.WriteLine($"{pessoas1Filhos} pessoas tem entre 1 e 3 filhos.");
    Console.WriteLine($"{pessoas4Filhos} pessoas tem entre 4 e 7 filhos.");
    Console.WriteLine($"{pessoas8Filhos} pessoas tem mais de 8 filhos.");
    Console.WriteLine($"{pessoasSemFilhos} pessoas não tem filhos.");
}

if (opcaoExercicio == 10)
{
    /*
    10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
    Número de pessoas do sexo masculino.
    Número de pessoas do sexo feminino.
    Número de pessoas com idade inferior a 30 anos.
    Número de pessoas com idade superior a 60 anos.
    Média de idade das mulheres.
    */
    string nome = "", sexo = "";
    int idade = 0, i, contadorM = 0, contadorF = 0, idade30 = 0, idade60 = 0, media = 0, idadeMulheres = 0;

    for (i = 1; i < 3; i++)
    {
        Console.WriteLine($"Informe o {i} nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe seu sexo(masculino ou feminino): ");
        sexo = Console.ReadLine();
        Console.WriteLine("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());
        ///<summary>
        /// Contador de pessoas pelo sexo
        /// </summary>
        if (sexo == "masculino")
        {
            contadorM++;
        }
        if (sexo == "feminino")
        {
            idadeMulheres = idade + idadeMulheres;
            contadorF++;
        }
        ///<summary>
        /// Contador de pessoas pela idade
        /// </summary>
        if (idade < 30)
        {
            idade30++;
        }
        if (idade < 60)
        {
            idade60++;
        }
    }
    media = (idade / contadorF);
    Console.Write($"\n{contadorM} pessoas do sexo masculino.");
    Console.Write($"\n{contadorF} pessoas do sexo feminino.");
    Console.Write($"\n{idade30} pessoas com idade inferior a 30 anos.");
    Console.Write($"\n{idade60} pessoas com idade superior a 60 anos.");
    Console.Write($"\n Média de idade das mulheres é de {media}");

}

if (opcaoExercicio == 11)
{
    /*
    11: Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
    a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.
    */

    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    float notaMaisAlta = 0, notaMaisBaixa = 400, media, nota, calculo = 0;
    int i, quantAlunos, aprovados = 0, reprovados = 0;
    string nome, nomeMaiorNota="", nomeMenorNota="";

    ///<summary>
    /// Descobrindo quantos alunos a sala tem
    /// </summary>
    Console.WriteLine("Informe quantos alunos possui a turma: ");
    quantAlunos = int.Parse(Console.ReadLine());
    Console.Clear();

    ///<summary>
    /// Laço de repetição para colher dados de todos os alunos da turma
    /// </summary>
    for (i=1; i <= quantAlunos; i++)
    {
        Console.WriteLine($"Informe o nome do {i} aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine("Infome sua nota: ");
        nota = float.Parse(Console.ReadLine());

        ///<summary>
        /// Somatoria de todas as notas
        /// </summary>
        calculo = nota + calculo;

        ///<summary>
        /// Estrutura de comparação para descobrir a maior e a menor nota
        /// </summary>
        if(nota > notaMaisAlta)
        {
            notaMaisAlta = nota;
            nomeMaiorNota = nome;
        }
        if(nota < notaMaisBaixa)
        {
            notaMaisBaixa = nota;
            nomeMenorNota = nome;
        }
        if(nota < 12)
        {
            reprovados++;
        }
        else if(nota >= 12)
        {
            aprovados++;
        }
    }
    ///<summary>
    /// Entregando informações ao usuário
    /// </summary>
    Console.Clear();
    media = (calculo/quantAlunos);
    Console.WriteLine($"O aluno {nomeMaiorNota}, tirou {notaMaisAlta}. É a nota mais alta!");
    Console.WriteLine($"O aluno {nomeMenorNota}, tirou {notaMaisBaixa}. É a nota mais baixa...");
    Console.WriteLine($"A média aritmética da turma é: {media}");
    Console.WriteLine($"A turma possui: {quantAlunos}");
}

if (opcaoExercicio == 12)
{
    /*
    12: Apresentar o total da soma dos cem primeiros números inteiros.
    */

    ///<summary>
    /// Declaração de variáveis
    /// </summary>
    int i, auxiliar=0;

    ///<summary>
    ///Informando ao usuário a soma de todos os números inteiros até 100
    /// </summary>
    for (i=1; i <= 100; i++)
    {
        auxiliar = i + auxiliar;
    }
    Console.WriteLine($"Soma dos 100 primeiros números inteiros: {auxiliar}");
}

if (opcaoExercicio == 13)
{
    /*
    13: Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.
    */
    ///<summary>
    ///Declaração de variáveis
    /// </summary>
    int i, auxiliar = 0;

    for(i=1; i < 500; i++)
    {
        if(i % 2 == 0)
        {
            auxiliar = i + auxiliar;
            Console.WriteLine(i);
            Console.WriteLine($"Novo valor: {auxiliar}");
        }
    }
    Console.WriteLine($"A soma de todos o valores entre 1 e 500 é de: {auxiliar}");
}

if (opcaoExercicio == 14)
{
    /*
    14: Mostrar as potências de 2 variando de 0 a 10.
    */
    int valor2 = 2, i;
    for (i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{valor2}^{i} = {(long)Math.Pow(valor2, i)} ");
    }
}
if (opcaoExercicio == 15)
{
    /*
    15: Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
    ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
    Considerar nota 7,0 como mínima para aprovação.
    */
    float nota,notaTotal=0, media;
    int i;

    for (i = 1; i <= 4; i++)
    {
        Console.WriteLine($"informe a {i}º nota:");
        nota = float.Parse(Console.ReadLine());
        notaTotal = nota + notaTotal;
    }
    media = i / notaTotal;
    if (media >= 7)
    {
        Console.WriteLine("Aprovado!");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
    
}


if (opcaoExercicio == 16)
{
    /*
    16: Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação sucessiva de N 
    por 3 enquanto o produto for menor que 250 (N*3; N*3*3; N*3*3*3; etc).
    */
    int numero, calculadora=0;
    int i;

    Console.WriteLine("Informe um número igual ou menor que 50: ");
    numero = int.Parse(Console.ReadLine());

    for (i=3; calculadora < 250; i= i + 3)
    {
        if (numero <= 50)
        {
            calculadora = numero * i;
            Console.WriteLine($"{numero} * 3 = {calculadora}");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    } 
}

if (opcaoExercicio == 17)
{
    /*
    17: Apresentar os quadrados dos números inteiros de 15 a 200.
    */
    double i;
    for (i=15; i <= 200; i++)
    {
        Console.WriteLine($"{i} ao quadrado: {Math.Sqrt(i)}");
    }
}
if(opcaoExercicio == 18)
{
    /*
    18: Elaborar um programa que apresente o valor de uma potência de uma base qualquer elevada a um expoente 
    qualquer, ou seja, NM.
*/
    double numeroBase, numeroExpoente, i, calculo=1;

    Console.WriteLine("Informe o número base que deseja descobrir a potencia: ");
    numeroBase = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe o expoente");
    numeroExpoente = double.Parse(Console.ReadLine());

    for(i=0; i <= numeroExpoente; i++)
    {
        calculo = numeroBase * calculo;
    }
    Console.WriteLine($"O resultado é: {calculo}");
}

if(opcaoExercicio == 19)
{
    /*
    19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
        coletando dados sobre o salário e número de filhos. 
        A prefeitura deseja saber: 
 
    a) média do salário da população;

    b) média do número de filhos;
    
    c) maior salário; v
    
    d) percentual de pessoas com salário até R$ 100,00.

    O final da leitura de dados se dará com a entrada de um salário negativo.
    */

    ///<summary>
    ///Variáveis separada com suas determinadas funções
    /// </summary>
    double salario = 0, salarioMaior = 0, totalSalario = 0;
    double numeroFilhos = 0, totalFilhos = 0;
    double contadorSalario100 = 0, percentual100 = 0;
    double media, mediaFilhos = 0;
    int contadorPessoas = 0, contadorFilhos = 0;
    do
    {
        Console.WriteLine($"Infome o salário do {contadorPessoas}º habitante: ");
        salario = double.Parse(Console.ReadLine());
        contadorPessoas++;
        totalSalario = salario + totalSalario;

        ///<summary>
        ///Descobrindo o maior salário
        /// </summary>
        if (salario > salarioMaior)
        {
            salarioMaior = salario;
        }
        
        if(salario < 100)
        {
            contadorSalario100++;
        }




        Console.WriteLine($"Informe quantos filhos {numeroFilhos}");
        numeroFilhos = double.Parse(Console.ReadLine());

        contadorFilhos++;//contador da quantidade de filhos
        totalFilhos = numeroFilhos + totalFilhos;//descobrindo o total de filhos da população

    } while (salario < 0);

    media = contadorPessoas / salario; // calculo para descobrir a média do salario da população
    mediaFilhos = contadorFilhos / totalFilhos;
    percentual100 = (contadorSalario100/100)(conta);

    Console.Write($"\nA média do salário da população é: {media}");
    Console.Write($"\nA média do número de filhos da população é: {mediaFilhos}");
    Console.Write($"\nO maior salario é: {salarioMaior}");

}

if (opcaoExercicio == 20)
{
    /*
    20. Foi realizada uma pesquisa de algumas características físicas da população de uma certa região, 
    a qual coletou os seguintes dados referentes a cada habitante para serem analisados:
    - sexo (masculino e feminino)
    - cor dos olhos (azuis, verdes ou castanhos)
    - cor dos cabelos ( louros, castanhos, pretos)
    - idade 
    */
}

if (opcaoExercicio == 21)
{
    /*
    21. Faça um algoritmo que determine e escreva: 
 
    - a maior idade dos habitantes
    - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
    e que tenham olhos verdes e cabelos louros.
    O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
    */
}
