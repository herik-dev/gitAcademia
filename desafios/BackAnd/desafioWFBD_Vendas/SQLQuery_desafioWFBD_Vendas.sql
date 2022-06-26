/* Criação do banco de dados */
create database vendas_db;
/* Selecionando bando de dados para 
   Realizar consulta */
use desafiovendas_db;

drop database vendas_db;

/* Criação da tabela Clientes OK*/
CREATE TABLE Clientes
(
id_Cliente int PRIMARY KEY identity, --auto incremento
nome VARCHAR(90) NOT NULL,
telefone VARCHAR(90) NOT NULL,
email VARCHAR(90)NOT NULL,
)

DROP TABLE Cliente;

INSERT INTO Clientes VALUES ('Herik','999999999','herik.lopes@ufn.edu');
SELECT * FROM Clientes;

/* Criação da tabela Produtos */
CREATE TABLE Produtos
(
id_Produto int PRIMARY KEY identity, --auto incremento
codEAN int NOT NULL,
nome VARCHAR(50),
preco VARCHAR(50),
estoque int NOT NULL,
)

DROP TABLE Produtos;

INSERT INTO Produtos VALUES (000000000,'Vinho Pergola',20.00,50);

SELECT * FROM Produtos;

/* Criação da tabela Vendas */
CREATE TABLE Vendas
(
id_Venda int PRIMARY KEY identity, --auto incremento
valorTotal FLOAT NOT NULL,
codigo_idCliente int NOT NULL,
ItemVenda_idItemVenda int NOT NULL,

CONSTRAINT fk_vendaCliente FOREIGN KEY (codigo_idCliente) REFERENCES Clientes(id_Cliente),


CONSTRAINT fk_ItemVenda_Venda FOREIGN KEY (ItemVenda_idItemVenda) REFERENCES ItemVenda(id_ItemVenda),
)

DROP TABLE Vendas;

INSERT INTO Vendas VALUES (1,20.00);

SELECT * FROM Vendas;


/* Criação da tabela ItemVenda */
CREATE TABLE ItemVenda
(
id_ItemVenda int PRIMARY KEY NOT NULL identity,
venda_idVenda int NOT NULL,
produto_idProduto int NOT NULL,
quantidade int NOT NULL,
valorTotal FLOAT NOT NULL,

/* Consulta para Criação das relações */

CONSTRAINT fk_Venda_ItemVenda FOREIGN KEY (venda_idVenda) REFERENCES Vendas(id_Venda),
/**/
CONSTRAINT fk_produtoVenda FOREIGN KEY (produto_idProduto)  REFERENCES Produtos(id_Produto),
)

DROP TABLE ItemVenda;

INSERT INTO ItemVenda VALUES (40.00);

SELECT * FROM Vendas;
SELECT * FROM Produto;
SELECT * FROM Cliente;
SELECT * FROM ItemVenda;

use desafiovendas_db;



/* TESTE */

-- script base de dados venda_db
--criando base de dados
CREATE DATABASE desafioWFBD_Vendas;
--mostrando todas as tabelas da base de dados
SELECT name
FROM sys.databases;
--usando a base de dados empresa_db
use desafioWFBD_Vendas;

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


DROP TABLE Cliente;
DROP TABLE Produto;

--criando tabela Venda
CREATE TABLE Venda 
(
idVenda INT PRIMARY KEY NOT NULL IDENTITY,
valorTotal FLOAT NOT NULL,
Cliente_idCliente INT NOT NULL,
ItemVenda_idItemVenda INT NOT NULL,

CONSTRAINT fk_Cliente_Venda FOREIGN KEY (Cliente_idCliente) REFERENCES Cliente (idCliente),

CONSTRAINT fk_ItemVenda_Venda FOREIGN KEY (ItemVenda_idItemVenda) REFERENCES ItemVenda (idItemVenda),

)


--criando tabela ItemVenda
CREATE TABLE ItemVenda 
(
idItemVenda INT PRIMARY KEY NOT NULL,
Venda_idVenda INT NOT NULL,
Produto_idProduto INT NOT NULL,
quantidade INT NOT NULL,
valorTotal FLOAT NOT NULL,

CONSTRAINT fk_Venda_ItemVenda FOREIGN KEY (Venda_idVenda) REFERENCES Venda (idVenda),


CONSTRAINT fk_Produto_ItemVenda FOREIGN KEY (Produto_idProduto) REFERENCES Produto (idProduto),
)


INSERT INTO Cliente VALUES ('Herik','herik.lopes@ufn.edu','999999999');
INSERT INTO Produto VALUES (000000000,'Vinho Pergola',20.00,50);


use usuario_db;