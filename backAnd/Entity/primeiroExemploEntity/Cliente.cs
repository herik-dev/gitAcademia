﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace primeiroExemploEntity
{
    [Table("Clientes")]
    public class Cliente
    {
        []
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public string CPF { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
        }

    }
}
