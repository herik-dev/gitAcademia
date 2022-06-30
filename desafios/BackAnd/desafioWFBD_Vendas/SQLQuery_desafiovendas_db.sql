-- script base de dados desafiovendas_db

--criando base de dados
CREATE DATABASE desafiovendas_db;

--mostrando todas as tabelas da base de dados
SELECT name
FROM sys.databases;

--usando a base de dados desafiovendas_db
use desafiovendas_db;

--criando tabela Cliente
CREATE TABLE Cliente (
  idCliente INT PRIMARY KEY,
  nomeCompleto VARCHAR(150) NOT NULL,
  email VARCHAR (50) NOT NULL,
  Telefone VARCHAR(20) NOT NULL,      
);

--criando tabela Produto
CREATE TABLE Produto (
  idProduto INT PRIMARY KEY NOT NULL,
  nome VARCHAR(50) NOT NULL,
  categoria VARCHAR(50) NOT NULL,
  codEAN VARCHAR(50) NOT NULL,
  preco FLOAT NOT NULL,
  estoque INT NOT NULL,   
);

--criando tabela Venda
CREATE TABLE Venda 
(
valorTotal FLOAT NOT NULL,
nomeCliente VARCHAR (50) NOT NULL,
NomeProduto VARCHAR (50) NOT NULL,
)

--Comandos para excluir tabelas
DROP TABLE Cliente;
DROP TABLE Produto;
DROP TABLE Vendas;

--Comandos para selecionar itens das tabelas
SELECT * FROM Cliente;
SELECT * FROM Produto;
SELECT * FROM Venda;



