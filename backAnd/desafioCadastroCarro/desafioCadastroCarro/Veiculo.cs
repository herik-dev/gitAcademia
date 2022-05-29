using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioCadastroCarro
{
    internal class Veiculo
    {
        string placa;
        DateTime dataHoraEntrada;

        public Veiculo() { }
        public Veiculo(string placa, DateTime data)
        {
            this.Placa = placa;
            this.DataHoraEntrada = data;
        }

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }
    }
}

