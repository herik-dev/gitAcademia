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
        public int contadorGato;

        /// <summary>
        ///  Atributo que Armazena o contador dos cachorros
        /// </summary>
        public int contadorCachorro;

        /// <summary>
        ///  Atributo que Armazena o  contador dos peixes
        /// </summary>
        public int contadorPeixe;

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
            this.nomeAnimal = nomeAnimal;
            this.tipoAnimal = tipoAnimal;
            this.contadorGato = contadorGato;
            this.contadorCachorro = contadorCachorro;
            this.contadorPeixe = contadorPeixe;
        }
        /// <summary>
        /// Método
        /// </summary>
        public void mostraAnimal()
        {
            Console.WriteLine($"São:\n{contadorGato} gatos \n{contadorCachorro} cachorros\n{contadorPeixe} peixes.");
        }
    }
}
