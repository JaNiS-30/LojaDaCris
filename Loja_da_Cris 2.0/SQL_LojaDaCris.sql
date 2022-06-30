CREATE DATABASE LojaDaCris
GO

USE LojaDaCris
GO

CREATE TABLE Categoria (
	ID_Categoria INT IDENTITY(1,1),
	Categoria NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_CATEGORIA PRIMARY KEY (ID_Categoria)
	);
GO

CREATE TABLE Produto (
	CodigoDeBarras INT NOT NULL,
	NomeProduto NVARCHAR(80) NOT NULL,
	Imagem NVARCHAR(250) NOT NULL,
	Quantidade INT NOT NULL,
	PrecoUnit MONEY NOT NULL,
	ID_Categoria INT NOT NULL,
	CONSTRAINT PK_PRODUTO PRIMARY KEY (CodigoDeBarras),
	CONSTRAINT FK_PRODUTO_CATEGORIA FOREIGN KEY (ID_Categoria) REFERENCES Categoria(ID_Categoria) 
	ON DELETE CASCADE
	);
GO

CREATE TABLE Cliente (
	ID_Cliente INT IDENTITY(1,1),
	Nome NVARCHAR(150) NOT NULL,
	CPF NVARCHAR(14) NOT NULL,
	Telefone NVARCHAR(14) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	DataNasc DATE,
	Cidade NVARCHAR(50),
	Endereco NVARCHAR(100), 
	Numero INT,
	CEP NVARCHAR(9),
	CONSTRAINT PK_CLIENTE PRIMARY KEY (ID_Cliente)
	);
GO

CREATE TABLE Vendedor (
	ID_Vendedor INT IDENTITY(1,1),
	ID_Cliente INT NOT NULL,
	Usuario NVARCHAR(50) CONSTRAINT UQ_VENDEDOR UNIQUE,
	Senha NVARCHAR(100) NOT NULL,
	DataTrocaSenha DATE NOT NULL,
	Comissao FLOAT NOT NULL,
	ComissaoRecebida MONEY NOT NULL,
	Salario MONEY NOT NULL,
	IS_ADM BIT NOT NULL,
	CONSTRAINT PK_VENDEDOR PRIMARY KEY (ID_Vendedor),
	CONSTRAINT FK_VENDEDOR_CLIENTE FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
	ON DELETE CASCADE
	);
GO

CREATE TABLE Venda (
	ID_Venda INT IDENTITY(1,1),
	ID_Cliente INT NOT NULL,
	ID_Vendedor INT NOT NULL,
	DataVenda DATE NOT NULL CONSTRAINT DF_DATAVENDA DEFAULT GETDATE(),
	ComissaoVenda MONEY NOT NULL,
	PrecoTotal MONEY NOT NULL,	
	CONSTRAINT PK_VENDA PRIMARY KEY (ID_Venda),
	CONSTRAINT FK_VENDA_CLIENTE FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
	ON DELETE CASCADE,
	CONSTRAINT FK_VENDA_VENDEDOR FOREIGN KEY (ID_Vendedor) REFERENCES Vendedor(ID_Vendedor)
	);
GO

CREATE TABLE ItemVenda (
	ID_ItemVenda INT IDENTITY(1,1),
	ID_Venda INT NOT NULL,
	CodigoDeBarras INT NOT NULL,
	Quantidade INT NOT NULL,
	Valor MONEY NOT NULL,	
	CONSTRAINT FK_ITEMVENDA PRIMARY KEY (ID_ItemVenda),
	CONSTRAINT FK_ITEMVENDA_PRODUTO FOREIGN KEY (CodigoDeBarras) REFERENCES Produto(CodigoDeBarras) 
	ON DELETE CASCADE,
	CONSTRAINT FK_ITEMVENDA_VENDA FOREIGN KEY (ID_Venda) REFERENCES Venda(ID_Venda) 
	ON DELETE CASCADE
	);
GO

INSERT INTO Cliente (Nome, CPF, Telefone, Email, DataNasc, Cidade, Endereco, Numero, CEP) 
VALUES ('Giani Rosset Pertuzatti', '037.902.240-06', '(54)99620-3042', 'gianirp9@hotmail.com', '2002-09-04', 'Três Arroios', 'Rua João Zahner', 43, '99725-000');
GO

INSERT INTO Vendedor (ID_Cliente, Usuario, Senha, DataTrocaSenha, Comissao, ComissaoRecebida, Salario, IS_ADM)
VALUES (1, 'GRPERTUZATTI', 'admin', '2022-06-01', 8.5, 0.00, 1212.00, 1);
GO

INSERT INTO Categoria (Categoria) VALUES ('Enxovais');
GO

INSERT INTO Produto (CodigoDeBarras, NomeProduto, Imagem, Quantidade, PrecoUnit, ID_Categoria)
VALUES (789111, 'Lençol cinza prata Pérola Enxovais', 'C:\Loja_da_Cris\ImgProdutos\lencol-cinza-perola.jpg', 3, 119.99, 1);
GO

INSERT INTO Produto (CodigoDeBarras, NomeProduto, Imagem, Quantidade, PrecoUnit,ID_Categoria)
VALUES (789123, 'Lençol bordô Pérola Enxovais', 'C:\Loja_da_Cris\ImgProdutos\lencol-vermelho-perola.jpg', 4, 119.99, 1);
GO

INSERT INTO Produto (CodigoDeBarras, NomeProduto, Imagem, Quantidade, PrecoUnit,ID_Categoria)
VALUES (789321, 'Lençol azul celeste Pérola Enxovais', 'C:\Loja_da_Cris\ImgProdutos\lencol-cinza-azul-celeste.jpg', 4, 119.99, 1);
GO

INSERT INTO Produto (CodigoDeBarras, NomeProduto, Imagem, Quantidade, PrecoUnit,ID_Categoria)
VALUES (789987, 'Edredom Débora branco neve', 'C:\Loja_da_Cris\ImgProdutos\cobertor-debora.jpg', 4, 299.99, 1);
GO