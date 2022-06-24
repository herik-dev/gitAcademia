using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace usuarioFormsBD
{
    public partial class Consulta : Form
    {
        Thread add;
        public Consulta()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            try
            {

                string sqlTexto = "SELECT  idUsuario, nomeCompleto, email  from usuarios";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_Consulta.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_Consulta.Items.Add(leitor["idUsuario"].ToString());
                    listView_Consulta.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    listView_Consulta.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                conexao.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }

        }

        private void button_conectarBD_Click(object sender, EventArgs e)
        {
            carregarListView();
            button_conectarBD.Enabled = false;
        }

        private void button_adicionarUsuari_Click(object sender, EventArgs e)
        {
            this.Close();
            add = new Thread(abrirJanela);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Adicionar());
        }
    }
}
