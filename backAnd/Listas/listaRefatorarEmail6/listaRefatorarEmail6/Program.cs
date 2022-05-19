/*
 Programa em VS que recebe emails de um
usuário e que são gravados em arquivo.
nome;email
 */

using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

try
{
    string nome = "";
    string email = "";
    string nomeArquivo = "nomeEmail.dat";
    StreamWriter escritor;

    escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

    do
    {
        Console.Write("Informe seu nome ou 'sair': ");
        nome = Console.ReadLine();
        Console.Write("Informe seu nome e-mail: ");
        email = Console.ReadLine();
        nome.ToLower(); //nome.toUpper();
        email.ToLower(); //email.toUpper();
        if (nome.Equals("sair"))
        {
            break;
        }
        escritor.WriteLine($"{nome};{email}"); //literalmente escreve no arquivo
        escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo
    } while (true);
    escritor.Close(); //fecha o objeto que representa o arquivo
}
catch (IOException e)
{
    Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
}