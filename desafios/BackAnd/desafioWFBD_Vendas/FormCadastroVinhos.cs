using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace desafioWFBD_Vendas
{
    public partial class FormCadastroVinhos : Form
    {
        public FormCadastroVinhos()
        {
            InitializeComponent();
            this.produtoTableAdapter.Fill(this.desafiovendas_dbDataSet.Produto);

            string stringConexao = "Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True";

            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
        }
        Thread add;
        private void btCadastrar_Click(object sender, EventArgs e)
        {

            // String de conexão
            SqlConnection conexao = new SqlConnection("Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True");

            float teste = float.Parse(tbPreco.Text);

            //gerar sentenças SQL
            string sqlTexto = "INSERT INTO Produto(idProduto, nome, categoria, codEAN, preco, estoque) VALUES (@idProduto, @nome, @categoria, @codEAN, @preco, @estoque)";
            Random numeroID = new Random();
            numeroID.Next();
            try
            {

                // Cria um ojbeto do tipo comando passando como parametro a string sqlTexto e conexao

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                //Insere os dados dos TextBox no comando SQL
                comando.Parameters.Add(new SqlParameter("@idProduto", numeroID.Next()));
                comando.Parameters.Add(new SqlParameter("@nome", this.tbNomeProduto.Text));       
                comando.Parameters.Add(new SqlParameter("@categoria", this.tbCategoria.Text));
                comando.Parameters.Add(new SqlParameter("@codEAN", this.mtbCodEAN.Text));
                comando.Parameters.Add(new SqlParameter("@preco", float.Parse(this.tbPreco.Text)));
                comando.Parameters.Add(new SqlParameter("@estoque", this.tbEstoque.Text));

                //Abrindo conexao com o banco de dados
                conexao.Open();


                //executar sentença SQL no SGBD
                comando.ExecuteNonQuery();

                //Fechando conexao com o banco de dados
                conexao.Close();

                MessageBox.Show("Cadastro efetuado com sucesso!");
                tbNomeProduto.Text = "";
                tbCategoria.Text = "";
                tbPreco.Text = "";
                mtbCodEAN.Text = "";
                tbEstoque.Text = "";
                this.produtoTableAdapter.Fill(this.desafiovendas_dbDataSet.Produto);
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNomeProduto.Text = "";
            tbCategoria.Text = "";
            tbPreco.Text = "";
            mtbCodEAN.Text = "";
            tbEstoque.Text = "";
        }

        private void FormCadastroVinhos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafiovendas_dbDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.

        }
    }
}

