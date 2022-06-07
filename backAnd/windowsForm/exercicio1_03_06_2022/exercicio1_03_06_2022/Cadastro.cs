//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace exercicio1_03_06_2022
{
    internal class Cadastro
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string status { get; set; }
        public string tipo { get; set; }
        public Cadastro(string nome, string telefone, string cpf, string login, string senha, string status, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.login = login;
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
        }
   
        public void MostrarDadosCadastrados()
        {
            
            MessageBox.Show($"Nome: {this.nome}\nTelefone: {this.telefone}\nCPF: {this.cpf[0]}{this.cpf[1]}{this.cpf[2]}" +
                $".{this.cpf[3]}{this.cpf[4]}{this.cpf[5]}.{this.cpf[6]}{this.cpf[7]}{this.cpf[8]}-{this.cpf[9]}{this.cpf[10]}" +
                $"\nLogin: {this.login}\nSenha: {this.senha}\nStatus: {this.status}\nTipo: {this.tipo}");
        }

    }
}
/*                                              tbNome;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;*/