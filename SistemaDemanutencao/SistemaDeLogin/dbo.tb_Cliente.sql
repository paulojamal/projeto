CREATE TABLE [dbo].[tb_Cliente] (
    [Id_cliente] INT          IDENTITY (1, 1) NOT NULL,
    [NomeUser]   VARCHAR (50) NOT NULL,
    [SenhaUser]  VARCHAR (50) NOT NULL,
	[Name]   VARCHAR (50) NOT NULL,
	[Sobrenome]   VARCHAR (50) NOT NULL,
	[ID]   VARCHAR (50) NOT NULL,
	[Telefone]   VARCHAR (50) NOT NULL,
	[Rua]   VARCHAR (50) NOT NULL,
	[Numero]   VARCHAR (50) NOT NULL,
	[Bairro]   VARCHAR (50) NOT NULL,
	[Cidade]   VARCHAR (50) NOT NULL,
	[Estado]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_cliente] ASC)
);

