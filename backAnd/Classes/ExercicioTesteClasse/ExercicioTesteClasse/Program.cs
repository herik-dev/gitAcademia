
    /* 1) Crie uma classe Carro com os atributos: modelo, marca, cor e placa. 
          Crie um método para definir os atributos, outro método para ligar
          o carro e outro método para desligar o carro.
    */

    Carro carro = new Carro();
    carro.modelo();
    carro.marca();
    carro.cor();
    carro.placa();

    Console.WriteLine("Você deseja ligar ou desligar o carro?");
    string opcao = Console.ReadLine();

    if (opcao.ToLower() == "ligar")
    {
        carro.ligarCarro();
    }
    if (opcao.ToLower() == "desligar")
    {
        carro.desligarCarro();
    }


    public class Carro
    {
    
    /*
    public string modelo;
    public string marca;
    public string cor;
    public string placa;
    */
        public void ligarCarro()
        {
            Console.WriteLine("O carro está sendo ligado");
        }
        public void desligarCarro()
        {
            Console.WriteLine("O carro está sendo desligado");
        }   

        public void modelo()
        {
            Console.WriteLine("CIVIC");
        }

        public void marca()
        {
            Console.WriteLine("TOYOTA");
        }

        public void cor()
        {
            Console.WriteLine("PRATA");
        }
        public void placa()
        {
            Console.WriteLine("MXQ-9899");
        }
    }

