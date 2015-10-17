CREATE TABLE [dbo].[tb_Cliente] (
    [Id_cliente] INT          IDENTITY (1, 1) NOT NULL,
    [NomeUser]   VARCHAR (50) NOT NULL,
    [SenhaUser]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_cliente] ASC)
);