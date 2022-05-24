/* 
 2) Escreva uma classe Pessoa contendo todos os atributos de uma pessoa.
    Faça métodos para apresentar os dados.
*/

Pessoa pessoa = new Pessoa();
pessoa.nome();
pessoa.idade();
pessoa.altura();
pessoa.peso();

Console.WriteLine("Atributos da pessoa: ");
public class Pessoa
{
    public void nome()
    {
        Console.WriteLine("Herik");
    }
    public void idade()
    {
        Console.WriteLine("26");
    }
    public void altura()
    {
        Console.WriteLine("1,64");
    }
    public void peso()
    {
        Console.WriteLine("80,00 kg");
    }
   
}