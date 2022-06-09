using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace exercicio1_03_06_2022
{
    public partial class fmCadastro : Form
    {
        public fmCadastro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para limpar conteudo do sistema
        /// </summary>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbCPF.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
            
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string status, tipo;
            if (cbStatus.Text == "Ativo")
            {
                status = "Ativo";
            }
            else
            {
                status = "Inativo";
            }
            if (cbTipo.Text == "Administrador")
            {
                tipo = "Administrador";
            }
            else
            {
                tipo = "Usuário";
            }

            Cadastro c = new Cadastro(tbNome.Text, tbTelefone.Text, tbCPF.Text, tbLogin.Text, tbSenha.Text, status, tipo);
            cadastro.Add(c);
            //c.MostrarDadosCadastrados();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*                                              tbNome;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;*/