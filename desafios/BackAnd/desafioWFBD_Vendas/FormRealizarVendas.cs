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

namespace desafioWFBD_Vendas
{
    public partial class FormRealizarVendas : Form
    {
        public FormRealizarVendas()
        {
            InitializeComponent();
            string stringConexao = "Data Source=VIRUS\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";

            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
        }
    }
}
