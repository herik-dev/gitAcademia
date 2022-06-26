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
using System.Data.SqlClient;

namespace desafioWFBD_Vendas
{

    public partial class FormTelaPrincipal : Form
    {
        Thread add;
        public FormTelaPrincipal()
        {
            InitializeComponent();
            string stringConexao = "Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafioWFBD_Vendas;TrustServerCertificate=True;Integrated Security=True";

            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
        }

        /* Botão cadastro de clientes, chamando tela de cadastro do cliente */
        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            add = new Thread(abrirCadastro);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void abrirCadastro(object obj)
        {
            Application.Run(new FormCadastro());
        }



        /* Botão cadastro de produtos, chamando tela de cadastro de Produtos */
        private void btCadastarProdutos_Click(object sender, EventArgs e)
        {

            add = new Thread(abrirProdutos);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void abrirProdutos(object obj)
        {
            Application.Run(new FormCadastroVinhos());
        }

        /* Botão Realizar vendas, chamando tela para venda de produtos */
        private void btRealizarVendas_Click(object sender, EventArgs e)
        {

            add = new Thread(abrirRealizarVendas);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void abrirRealizarVendas(object obj)
        {
            Application.Run(new FormRealizarVendas());
        }
    }
}
