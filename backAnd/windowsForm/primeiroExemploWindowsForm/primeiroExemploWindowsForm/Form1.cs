using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroExemploWindowsForm
{
    public partial class btOk : Form
    {
        public btOk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão OK");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Cliquei no botão OK");
            MessageBox.Show($"Nome digitado: {tbNome.Text}\n" +
                            $"E-mail digitado: {tbEmail.Text}\n" +
                            $"Endereço digitado: {tbEndereco.Text}\n" +
                            $"Telefone digitado: {tbTelefone.Text}\n" +
                            $"Bairro digitado: {tbBairro.Text}\n" +
                            $"Cidade digitada: {tbCidade.Text}\n" +
                            $"Sexo digitado: {tbSexo.Text}");

            MessageBox.Show("Cadastro efetuado");

            tbNome.Clear();
            tbEmail.Clear();
            tbEndereco.Clear();
            tbTelefone.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbSexo.Clear();


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão cancelar");
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_Load(object sender, EventArgs e)
        {

        }

        private void tbNome_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subtracao_Click(object sender, EventArgs e)
        {

        }

        private void adicao_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void numero9_Click(object sender, EventArgs e)
        {

        }

        private void numero4_Click(object sender, EventArgs e)
        {

        }

        private void numero5_Click(object sender, EventArgs e)
        {

        }

        private void numero6_Click(object sender, EventArgs e)
        {

        }

        private void numero7_Click(object sender, EventArgs e)
        {

        }

        private void numero3_Click(object sender, EventArgs e)
        {

        }
    }
}
