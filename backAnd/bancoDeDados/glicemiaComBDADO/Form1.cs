using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glicemiaComBDADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);

            try
            {
                conexao.Open();
            

                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
                

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);


                listView_medidasGlicemias.Items.Clear();
                
               
                SqlDataReader leitor = comando.ExecuteReader();
                
                int i = 0;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas de conexão com o BD","Alerta");
            }
            conexao.Close();
        }

        
    }
}
