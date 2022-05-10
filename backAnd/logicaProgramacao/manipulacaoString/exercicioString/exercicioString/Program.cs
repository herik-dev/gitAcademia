/*
 Exercícios desafio de manipulação de string's
 
 1º Fazer um programa que receba o nome completo
 de uma pessoa e exiba em maiúsculo o primeiro
 nome e o último sobrenome dessa pessoa

 2º Fazer um programa que receba o nome completo 
 de uma pessoa e o exiba abreviado
 */
/// <summary>
/// Armazena o nome completo informado pelo usuario
/// </summary>
string nomeCompleto;


///summary
///vetor de string que recebe o split das palavras do nomeCompleto
///</summary>
string palavras;

string primeiroNome;

///Summary
///armazena o último sobrenome de um nome completo
///</summary>
string ultimoSobreNome;

//receber um nome completo
Console.WriteLine("Digite um nome completo: ");
nomeCompleto = Console.ReadLine();
nomeCompleto = nomeCompleto.ToUpper();

//splitar o nome completo por espaço em branco
palavras = nomeCompleto.Split(" ");

primeiroNome = palavras[0];
ultimoSobreNome = palavras[ palavras.Length - 1 ];

Console.WriteLine("Seu primeiro nome " + primeiroNome);
Console.WriteLine("Seu último sobrenome " + ultimoSobreNome);


