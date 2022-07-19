using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace desafioWFBD_Vendas
{
    public partial class FormRealizarVendas : Form
    {
        public FormRealizarVendas()
        {
            InitializeComponent();
            this.vendaTableAdapter.Fill(this.desafiovendas_dbDataSet.Venda);
            this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSet.Cliente);
            this.produtoTableAdapter.Fill(this.desafiovendas_dbDataSet.Produto);

        }
        string stringConexao = "Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True";

        private void btRealizarVenda_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                //SqlConnection conexao = new SqlConnection("Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=desafiovendas_db;TrustServerCertificate=True;Integrated Security=True");
                conexao.Open();


                string sqlTexto = "INSERT INTO Venda(valorTotal, nomeCliente, NomeProduto) VALUES (@valorTotal, @nomeCliente, @NomeProduto)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);


                if ()
                    float calculo = "SELECT preco FROM Produto";

                float total = float.Parse(tbQuantidade.Text);

                //Insere os dados dos TextBox no comando SQL
                comando.Parameters.Add(new SqlParameter("@valorTotal", total));
                comando.Parameters.Add(new SqlParameter("@nomeCliente", this.cbCliente.Text));
                comando.Parameters.Add(new SqlParameter("@NomeProduto", this.cbNome.Text));

                comando.ExecuteNonQuery();
                conexao.Close();
                this.vendaTableAdapter.Fill(this.desafiovendas_dbDataSet.Venda);
                this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSet.Cliente);
                this.produtoTableAdapter.Fill(this.desafiovendas_dbDataSet.Produto);
                MessageBox.Show("Conexão bem sucedida");
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.Fill(this.desafiovendas_dbDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


        
}
