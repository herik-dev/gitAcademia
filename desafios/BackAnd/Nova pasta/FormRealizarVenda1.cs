using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWFBD_Vendas
{
    public partial class FormRealizarVenda1 : Form
    {
        public FormRealizarVenda1()
        {
            InitializeComponent();
            // String de conexão
            SqlConnection conexao = new SqlConnection("Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True");

            try
            {
                //Conexão com o banco de dados
                conexao.Open();

                //Fechando conexao com o banco de dados
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void FormRealizarVenda1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSetCorreto1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSetCorreto.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSetCorreto.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.desafiovendas_dbDataSetCorreto.Venda);
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSet3.Produto'. Você pode movê-la ou removê-la conforme necessário.


        }
   
        private void btRealizarVenda_Click(object sender, EventArgs e)
        {

            // String de conexão
            SqlConnection conexao = new SqlConnection("Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True");
            // conexao.Open();

            //capturar valores das variáveis


            //gerar sentenças SQL
            string sqlTexto = "INSERT INTO Venda(valorTotal, nomeCliente, NomeProduto) VALUES (@valorTotal, @nomeCliente, @NomeProduto)";
            //Random numeroID = new Random();
            //numeroID.Next();
            
            try
            {

                // Cria um ojbeto do tipo comando passando como parametro a string sqlTexto e conexao
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);


                //Insere os dados no comando SQL
                comando.Parameters.Add(new SqlParameter("@valorTotal", float.Parse(nUpDQuantidade.Text)));
                comando.Parameters.Add(new SqlParameter("@nomeCliente", cbClienteVenda.Text));
                comando.Parameters.Add(new SqlParameter("@NomeProduto", cbProduto.Text));
                //comando.Parameters.Add(new SqlParameter("@ItemVenda_idItemVend", this.cbProduto.Text));

                //Abrindo conexao com o banco de dados
                conexao.Open();


                //executar sentença SQL no SGBD
                comando.ExecuteNonQuery();

                //Fechando conexao com o banco de dados
                conexao.Close();

                MessageBox.Show("Cadastro efetuado com sucesso!");
                //tbNome.Text = "";
                // tbTelefone.Text = "";
                //tbEmail.Text = "";
                //this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSet.Cliente);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void FormRealizarVenda1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSetCorreto.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.desafiovendas_dbDataSetCorreto.Produto);
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSetCorreto.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.desafiovendas_dbDataSetCorreto.Venda);
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSetCorreto.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSetCorreto.Cliente);

        }


    }
}


