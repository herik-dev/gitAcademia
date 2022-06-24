using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace usuarioFormsBD
{
    public partial class Adicionar : Form
    {
        Thread add;
        public Adicionar()
        {
            InitializeComponent();
        }

        private void button_voltarConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
            add = new Thread(voltarJanela);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void voltarJanela(object obj)
        {
            Application.Run(new Consulta());
        }


        private void button_Cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_nomeCompleto.Clear();
        }
        /*private void Limpar()
        {
            Action<Control.ControlCollection> funcao = null;
            funcao = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        funcao(control.Controls);
            }
            funcao(Controls);
        }
        */
    }
}
