/*
 #2
Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o 
usuário armazene/leia os dados dos dois dados privados (propriedades).
*/

using exercicioClasseDe1_6_2;


Console.WriteLine("----------- Apresentando bicho de estimação -----------");
string nomeAnimal = "", tipoAnimal = "";
int contadorGato=0, contadorCachorro=0, contadorPeixe=0;

AnimaisEstimacao m = new AnimaisEstimacao(nomeAnimal, tipoAnimal, contadorGato, contadorCachorro, contadorPeixe);
m.mostraAnimal();

/*
for (int i = 1; i <= 5; i++)
{
    ///<summary>
    /// Entrada de dados do nome de cada animal
    /// </summary>
    Console.WriteLine("Digite o nome do bicho: ");
    nomeAnimal = Console.ReadLine();

    ///<summary>
    /// Entrada de tipo cada animal
    /// </summary>
    Console.WriteLine("Digite a espécie do bicho: ");
    tipoAnimal = Console.ReadLine().ToLower();
    

    if (tipoAnimal == "gato" || tipoAnimal == "cachorro" || tipoAnimal == "peixe")
    {
            if (tipoAnimal == "gato")
            {
                contadorGato++;
            }
            else if(tipoAnimal == "cachorro")
            {
                contadorCachorro++;
            }
            else if (tipoAnimal == "peixe")
            {
                contadorPeixe++;

            }
            Console.Clear();
    }
    else
    {
        Console.WriteLine("Digite uma espécie válida (cachorro/gato/peixe).");
        i--;
    }


}
*/


