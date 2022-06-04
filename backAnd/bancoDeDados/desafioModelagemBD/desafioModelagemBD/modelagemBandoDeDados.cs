using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioModelagemBD
{
    internal class modelagemBandoDeDados
    {

		/*
		Modelagem Lógica do Sistema de Vendas

		Cliente(codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone)

		Vendedor(codVendedor, nome, fone, senha)

		Prateleira(codPrateleira, localizacao)

		Produto(codProduto, codigoBarras, descricao, codPrateleira)
			codPrateleira referencia Prateleira

		Venda(dataNotafiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente)
			codProduto referencia Produto
			codVendedor referencia Vendedor
			codCliente referencia Cliente


		Entidade = classe
		Atributo/Coluna se for uma chave estrangeira, no diagrama fica subentendido
		Relacionamento indica quem visita quem (chave primária visita outra entidade  
												como chave estrangeira)
			- Uma chave estrangeira deve ser uma chave primária na sua entidade/classe
			de origem
		Cardinalidade: mostra como se dará a visita (quem terá a chave estrangeira)
		*/

		//Cliente(codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone)
			public class Cliente(string nome;
		string rua;
		int numero;
		string complemento;
		int cep;
		string cidade;
		string estado;
		string fone;)
	{
		int codCliente;//pKEY
			string nome;
			string rua;
			int numero;
			string complemento;
			int cep;
			string cidade;
			string estado;
			string fone;
		}
		//Vendedor(codVendedor, nome, fone, senha)
		public class Vendedor()
	{
		int codVendedor;//pKEY
		string nome;
		string fone;
		string senha;
	}
	//Prateleira(codPrateleira, localizacao)
	public class Prateleira()
	{
		int codPrateleira;//pKEY
		string localizacao;
	}
	//Produto(codProduto, codigoBarras, descricao, codPrateleira)codPrateleira referencia Prateleira
	public class Produto()
	{
		int codProduto;//pKEY
		int codigoBarras;
		string descricao;
		int codPrateleira;

		public produtoPrateleira()
		{
			codPrateleira Prateleira;
		}
	}
	//Venda(dataNotafiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente) codProduto referencia Produto codVendedor referencia Vendedor codCliente referencia Cliente

	public class Venda()
	{
		DateTime dataNotafiscal;
		int numeroNotaFiscal;
		int codProduto;
		int codVendedor;
		int codCliente;

		public VendaProduto()
		{
			codProduto = Produto;
			codVendedor = Vendedor;
			codCliente = Cliente
		}
	}
    }
}
