using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaEmail
{
    class Usuario
    {
        /// <summary>
        /// Criação dos objetos
        /// </summary>
        string nomeCompleto;
        string email;

        /// <summary>
        /// Criação de e-mail's
        /// </summary>
        private void gerarEmail()
        {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

        /// <summary>
        /// Construtor utilizado no cadastro do usuario
        /// </summary>
        /// <param name="nome"></param>
        public Usuario(string nome)
        {
            this.nomeCompleto = nome;
            this.gerarEmail();
        }

        /// <summary>
        /// Construtor utilizado para popular a lista a partir do arquivo (banco)
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        public Usuario(string nome, string email)
        {
            this.nomeCompleto = nome;
            this.email = email;
        }

        /// <summary>
        /// Métodos GET e SET
        /// </summary>
        public string Nome { get => nomeCompleto; set => nomeCompleto = value; }

        public string Email { get => email; }
    }
}