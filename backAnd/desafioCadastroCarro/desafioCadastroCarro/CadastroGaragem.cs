using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioCadastroCarro
{
    internal class CadastroGaragem
    {
        public static void exibirLista(List<Veiculo> listaV)
        {
            Console.WriteLine("Listando Veiculos...");
            foreach (Veiculo i in listaV)
            {
                Console.WriteLine(i.Placa + " - " + i.DataHoraEntrada);
            }
        }

        public static void carregarLista(List<Veiculo> listV)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";");
                } while (!leitor.EndOfStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veiculos com problemas ou inexistente\n" + e.Message);
            }
        }

        private static void gravarArquivo(Veiculo v)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(v.Placa + ";" + v.DataHoraEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veículos com problemas\n" + e.Message);
            }
        }

        public static void cadastrarVeiculo(List<Veiculo> lista)
        {
            string placa;
            DateTime data = DateTime.Now;
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            Console.WriteLine("Digite a data e horário de entrada do veiculo, conforme padrão brasileiro: ");
            data = DateTime.Parse(Console.ReadLine());

            Veiculo v = new Veiculo(placa, data);
            lista.Add(v);
            CadastroGaragem.gravarArquivo(v);
        }
    }
}
