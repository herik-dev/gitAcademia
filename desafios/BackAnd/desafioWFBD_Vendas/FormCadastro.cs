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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

        }

        Thread add;
        private void btCadastrar_Click(object sender, EventArgs e)
        {

        
        // String de conexão
        SqlConnection conexao = new SqlConnection("Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True");
            // conexao.Open();

            //capturar valores das variáveis


            //gerar sentenças SQL
            string sqlTexto = "INSERT INTO Cliente(idCliente, nomeCompleto, email, Telefone) VALUES (@idCliente, @nomeCompleto, @email, @Telefone)";
            Random numeroID = new Random();
            numeroID.Next();
            try
            {
                
                // Cria um ojbeto do tipo comando passando como parametro a string sqlTexto e conexao

                    SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                //Insere os dados dos TextBox no comando SQL
                comando.Parameters.Add(new SqlParameter("@idCliente", numeroID.Next()));
                comando.Parameters.Add(new SqlParameter("@nomeCompleto", this.tbNome.Text));
                comando.Parameters.Add(new SqlParameter("@email", this.tbEmail.Text));
                comando.Parameters.Add(new SqlParameter("@Telefone", this.tbTelefone.Text));

                //Abrindo conexao com o banco de dados
                conexao.Open();


                //executar sentença SQL no SGBD
                comando.ExecuteNonQuery();

                //Fechando conexao com o banco de dados
                conexao.Close();

                MessageBox.Show("Cadastro efetuado com sucesso!");
                tbNome.Text = "";
                tbTelefone.Text = "";
                tbEmail.Text = "";
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
            tbNome.Text = "";
            tbTelefone.Text = "";
            tbEmail.Text = "";
        }
    }
}