using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuarioFormsBD
{
    internal class Usuario
    {
        public int idUsuario;
        public string nomeCompleto;
        public string email;

        public Usuario(int idUsuario, string nomeCompleto, string email)
        {
            this.idUsuario = idUsuario;
            this.nomeCompleto = nomeCompleto;
            this.email = email;
        }

        public bool addPessoa()
        {
            Consulta consulta = new Consulta();
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@atos.net";
            this.email = this.email.ToLower();
            L
        }


 
    }

}
