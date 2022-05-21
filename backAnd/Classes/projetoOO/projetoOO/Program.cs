// Declaração de uma classe em C#
Lampada l = new Lampada(); //chamando o construtor da lampada
l.potencia = 9;
l.ligar();// chamando método
Console.WriteLine($"Ligada? = {l.ligado} Potência = {l.potencia}");
l.desligar();// chamando método
Console.WriteLine($"Ligada? = {l.ligado} Potência = {l.potencia}");
double n = 9;
n = l.retornaPotencia();
Console.WriteLine($"A potencia da lampada cadastrada = {n}");

Console.WriteLine($"Retorno da função estaLigado = {l.estalLigada()}");

l.ligar();
l.desligar();
if (l.estalLigada())
{
    Console.WriteLine("A lampada está ligada");
}
else
{
    Console.WriteLine("A lampada esta desligada");
}
public class Lampada
{
    public bool ligado; // aqui eu vou poder definir somente se é true ou false - atributo
    public double potencia; // atributo
    

    // métodos
    /// <summary>
    /// Métodos ligar desligar e estaligada
    /// </summary>
    public void ligar() 
    {
        Console.WriteLine("A lampada está sendo ligada!");
        ligado = true; 
    }
    public void desligar() 
    {
        Console.WriteLine("A lampada está sendo desligada!");
        ligado = false; 
    }
    public double retornaPotencia()
    {
        return potencia;
    }
    public bool estalLigada() 
    {
        Console.WriteLine("A lampada está ligada!");
        return ligado; 
    }

}


