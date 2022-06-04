using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo0306Friday
{
    internal class Carro
    {
        public string modelo { get; set; }
        public string fabricante { get; set; }

        public bool ar;
        public bool dh;
        public bool abs;
        public bool airbag;
        public bool ve;
        public bool portas;
        public Carro(string modelo, string fabricante, bool ar, bool dh, bool abs, bool airbag, bool ve, bool portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ar = ar;
            this.dh = dh;
            this.abs = abs;
            this.airbag = airbag;
            this.ve = ve;
            this.portas = portas;
        }
        public void MostrarDadosCarro()
        {
            MessageBox.Show($"Carro {this.modelo}")
            MessageBox.Show($"Fabricante {this.fabricante}");
            MessageBox.Show($"Dh {this.dh}");
            MessageBox.Show($"Abs {this.abs}");
            MessageBox.Show($"AirBag {this.airbag}");
            MessageBox.Show($"Video Eletrico {this.ve}");
            MessageBox.Show($"Portas {this.portas}");
        }

    }
}
