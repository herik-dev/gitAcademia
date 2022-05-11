// See https://aka.ms/new-console-template for more information
Console.WriteLine("A ideia é trabalhar com métodos/funções de algumas classe importantes: string, Random, DateTime, List");
/// <summary>
/// Classe string e seus principais métodos/atributos: atributo -- Length, ToUpper(), ToLower(), split(), Contains(), IndexOf()
/// </summary>
string frase = "Excelente turma de dotNet da Academia Atos";
int tamanhoFrase = frase.Length;// associa o tamanho da frase
string fraseEmMaiusculo = frase.ToUpper();//transforma frase em maiusculo
string fraseEmMinusculo = frase.ToLower();//transforma frase em minusculo

string[] palavrasNaFrase = frase.Split(""); // separa cada palavra da frase em uma posicao do vetor palavrasNaFrase


// string frasePadrao = "SVC";//área da IA conhecida como Processamento da Língua Natural


bool estaContido = frase.Contains("Atos"); // retorna se uma substring está ou não contida numa outra string
int posicao = frase.IndexOf("Atos"); // retorna a posicao em índice da primeira ocorrencia uma substring na frase


//Classe Random
Random rnd = new Random();//declarando uma 'variável' chamada rnd e instanciando em memória - new()

int sorteio = rnd.Next(1, 11);
Console.WriteLine(sorteio);

char letra = (char)rnd.Next(65, 91); //A..Z a
Console.WriteLine(letra);

//Classe DateTime
DateTime datalocal = DateTime.Now;
Console.WriteLine(datalocal.ToString());

String[] dataHora = datalocal.ToString().Split(" ");
Console.WriteLine("So a data: " + dataHora[0]);
Console.WriteLine("Soa a hora: " + dataHora[1]);

//Classe List - estrutura de dados que armazena outros objetos de maneira dinamica

List<string> listaAlunos = new List<string>();//declarando uma 'variável' chamada lista