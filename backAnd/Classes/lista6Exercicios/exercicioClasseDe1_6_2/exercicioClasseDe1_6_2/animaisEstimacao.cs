using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 #2
Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

*Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
*Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
*É obrigatório criar uma classe para representar o Animal.
*A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
*A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o 
usuário armazene/leia os dados dos dois dados privados (propriedades).
 */
namespace exercicioClasseDe1_6_2
{
    internal class AnimaisEstimacao
    {   
        /// <summary>
        /// Atributo que Armazena o nome do animal
        /// </summary>
        private string nomeAnimal;

        /// <summary>
        ///  Atributo que Armazena o tipo de animal
        /// </summary>
        private string tipoAnimal;

        /// <summary>
        ///  Atributo que Armazena o contador dos gatos
        /// </summary>
        private int contadorGato;

        /// <summary>
        ///  Atributo que Armazena o contador dos cachorros
        /// </summary>
        private int contadorCachorro;

        /// <summary>
        ///  Atributo que Armazena o  contador dos peixes
        /// </summary>
        private int contadorPeixe;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nomeAnimal"></param>
        /// <param name="tipoAnimal"></param>
        /// <param name="contadorGato"></param>
        /// <param name="contadorCachorro"></param>
        /// <param name="contadorPeixe"></param>
        public AnimaisEstimacao(string nomeAnimal, string tipoAnimal, int contadorGato, int contadorCachorro, int contadorPeixe)
        {
            this.NomeAnimal = nomeAnimal;
            this.TipoAnimal = tipoAnimal;
            this.ContadorGato = contadorGato;
            this.ContadorCachorro = contadorCachorro;
            this.ContadorPeixe = contadorPeixe;
        }

        public string NomeAnimal { get => nomeAnimal; set => nomeAnimal = value; }
        public string TipoAnimal { get => tipoAnimal; set => tipoAnimal = value; }
        public int ContadorGato { get => contadorGato; set => contadorGato = value; }
        public int ContadorCachorro { get => contadorCachorro; set => contadorCachorro = value; }
        public int ContadorPeixe { get => contadorPeixe; set => contadorPeixe = value; }

        /// <summary>
        /// Método
        /// </summary>
        public void mostraAnimal()
        {

            for (int i = 1; i <= 5; i++)
            {
                ///<summary>
                /// Entrada de dados do nome de cada animal
                /// </summary>
                Console.WriteLine("Digite o nome do bicho: ");
                NomeAnimal = Console.ReadLine();

                ///<summary>
                /// Entrada de tipo cada animal
                /// </summary>
                Console.WriteLine("Digite a espécie do bicho: ");
                TipoAnimal = Console.ReadLine().ToLower();


                if (TipoAnimal == "gato" || TipoAnimal == "cachorro" || TipoAnimal == "peixe")
                {
                    if (TipoAnimal == "gato")
                    {
                        ContadorGato++;
                    }
                    else if (TipoAnimal == "cachorro")
                    {
                        ContadorCachorro++;
                    }
                    else if (TipoAnimal == "peixe")
                    {
                        ContadorPeixe++;

                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Digite uma espécie válida (cachorro/gato/peixe).");
                    i--;
                }


            }

            Console.WriteLine($"São:\n{ContadorGato} gatos \n{ContadorCachorro} cachorros\n{ContadorPeixe} peixes.");
        }
    }
}
