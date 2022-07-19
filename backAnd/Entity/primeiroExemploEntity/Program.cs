using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primeiroExemploEntity;

namespace primeiroExemploEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ClienteContext())
            {
                Console.WriteLine("Iniciando o programa!!");

                var quantidade_clientes = context.Clientes.Count();
                context.Clientes.Add(new Cliente() { Nome="Herik", Email="herik.lopes@teste", CPF="11111111111" });
                context.SaveChanges();

               // MessageBox.Show($" usuario {Nome} com CPF: {CPF} e telefone {Telefone} ");
            }
        }
    }
}


