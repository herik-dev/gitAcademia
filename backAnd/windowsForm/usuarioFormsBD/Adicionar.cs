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

namespace usuarioFormsBD
{
    public partial class Adicionar : Form
    {
        Thread add;
        public Adicionar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão para retornar a janela de consulta
        /// </summary>
        private void button_voltarConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
            add = new Thread(voltarJanela);
            add.SetApartmentState(ApartmentState.STA);
            add.Start();
        }
        private void voltarJanela(object obj)
        {
            Application.Run(new Consulta());
        }

        /// <summary>
        /// Botão para retornar Cadastrar usuario
        /// </summary>
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBox_nomeCompleto.Text;
            Consulta cadastro = new Consulta();

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

        /// <summary>
        /// Botão para limpar o conteúdo do Text Box
        /// </summary>
        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_nomeCompleto.Clear();
        }

    }
}
