// See https://aka.ms/new-console-template for more information

int exemplosFor;

Console.WriteLine("Informe o exemplos de condicinais utilizando For que deseja testar");
exemplosFor = int.Parse(Console.ReadLine());

//exemplo 1
if (exemplosFor == 1)
{
    int i;

    for (i = 0; i > 11; i--)
    { //i=i+1;
        Console.WriteLine($"{i}");
    }
}

//exemplo 2
if (exemplosFor == 2)
{
    int i;

    for (i = 20; i > 4; i--)
    { //i=i+1;
        Console.WriteLine($"{i}");
    }
}

if (exemplosFor == 4)
{
    //exemplo4 
    /*
     Escreva um algoritmo que leia pelo teclado
     dois valores inteiro chamados inicio e fim
     e então mostre todos os números entre inicio 
     e fim
     */
    int inicio, fim, i;

    Console.Write("Informe o primeiro numero de inicio: ");
    inicio = int.Parse(Console.ReadLine());

    Console.Write("Informe o segundo numero do fim: ");
    fim = int.Parse(Console.ReadLine());

    if (inicio < fim)
    {
        for (i = inicio; inicio <= fim; inicio++)
        {
            Console.WriteLine($"{inicio}");
        }
    }
    else if (fim < inicio)
    {
        for (i = fim; fim <= inicio; fim++)
        {
            Console.WriteLine($"{fim}");
        }
    }
    else
    {
        Console.WriteLine("Os valores são iguais.");
    }
}

//exemplo5
if(exemplosFor == 5)
{
    /*
     Escreva um algoritmo que leia pelo teclado
     um valor inteiro chamado x, e entao mostre
     na tela todos os numero de 0 a 100 de x em x.
     */
    int x, i;

    Console.WriteLine("Informe o numero x:");
    x = int.Parse(Console.ReadLine());

    for(i = 0; i <= 100; i = i + x)
    {
            Console.WriteLine(i);
      
    }
}

//exemplo6
if (exemplosFor == 6)
{
    /*
     Escreva um algoritmo leia pelo teclado um valor
     inteiro chamado x, e então mostre na tela todos 
     os números de 0 a 100 que são divisíveis por x.
     */
    int x, i;

    Console.WriteLine("Informe o numero x:");
    x = int.Parse(Console.ReadLine());

    for (i = 0; i <= 100; i++)
    {
        if (i % x == 0)
        {
            Console.WriteLine(i);
        }
    }
}
if (exemplosFor == 7)
{
    /*
     Escreva um algoritmo leia pelo teclado um valor
     inteiro chamado x, e então mostre na tela todos 
     os números de 0 a 100 que são divisíveis por x.
     */
    int x, i, taboada;
    string operador = ;

    Console.WriteLine("Informe o numero  que deseja saber a taboada:");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite M para multiplicacao, D para divisão e S para subtração");
    operador.ToUpper() = Console.ReadLine();

    if(operador == "M")
    for (i = 0; i <= 10; i++)
    {
        taboada = i * x;
            Console.WriteLine($"taboada de multiplicação de {x} é:");
        Console.WriteLine($"{x} x {i} = {taboada}");
    } 
    else if (operador == "D")
        for (i = 0; i <= 10; i++)
        {
            taboada = i / x;
            Console.WriteLine($"taboada de divisão de {x} é:");
            Console.WriteLine($"{x} / {i} = {taboada}");
        }
    else if (operador == "S")
        for (i = 0; i <= 10; i++)
        {
            taboada = i - x;
            Console.WriteLine($"taboada de subtração de {x} é:");
            Console.WriteLine($"{x} - {i} = {taboada}");
        }
    else
    {
        Console.WriteLine("Operador invalido, digite M, D ou S.");
    }
}

