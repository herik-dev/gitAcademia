using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1_03_06_2022
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmCadastro fcadastro = new fmCadastro();
            fcadastro.ShowDialog();
        }

        private void configurePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCadastro fcadastro = new fmCadastro();
            fcadastro.ShowDialog();
        }
    }
}
