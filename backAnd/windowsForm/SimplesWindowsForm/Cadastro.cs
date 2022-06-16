using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesWindowsForm
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            /*String nome tbnome
              * int idade = tbidade
             * string cpf = tbcpf
             * string end = tbend
             * string bairro tbbairro
             * string cep tbcep
             * string cidade tbcidade
             * */
            Pessoa p = new Pessoa(textBox_Nome.Text, int.Parse(textBox_Idade.Text), textBox_CPF.Text, textBox_Endereco.Text, textBox_Bairro.Text, textBox_CEP.Text, textBox_Cidade.Text);
            MessageBox.Show("Nome do individuo: " + p.nome + " CPF: " + p.cpf);
            textBox_Nome.Text = "";
            textBox_Idade.Text = "";
            textBox_CPF.Text = "";
            textBox_Endereco.Text = "";
            textBox_Bairro.Text = "";
            textBox_CEP.Text = "";
            textBox_Cidade.Text = "";
            p.gravarPessoa();
        }
    }
}
