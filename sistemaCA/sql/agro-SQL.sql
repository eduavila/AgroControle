USE [master]
GO
/****** Object:  Database [dbsysca]    Script Date: 17/03/2013 22:51:32 ******/
CREATE DATABASE [dbsysca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbsysca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SYSCA\MSSQL\DATA\dbsysca.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbsysca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SYSCA\MSSQL\DATA\dbsysca_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbsysca] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbsysca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbsysca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbsysca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbsysca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbsysca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbsysca] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbsysca] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbsysca] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [dbsysca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbsysca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbsysca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbsysca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbsysca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbsysca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbsysca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbsysca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbsysca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbsysca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbsysca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbsysca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbsysca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbsysca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbsysca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbsysca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbsysca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbsysca] SET  MULTI_USER 
GO
ALTER DATABASE [dbsysca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbsysca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbsysca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbsysca] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [dbsysca]
GO
/****** Object:  StoredProcedure [dbo].[psListarSafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[psListarSafra]
	
AS
BEGIN
	Select id_safra,descricao,dataincio,datafechamento,id_cultura,[status],obs	 From tblsafra 
END

GO
/****** Object:  StoredProcedure [dbo].[psVisualizarSafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psVisualizarSafra]

	@id_safra int


AS
Begin

	Select id_safra,descricao,dataincio,datafechamento,id_cultura,[status],obs from tblsafra where id_safra = @id_safra


end
GO
/****** Object:  StoredProcedure [dbo].[spAlterarFuncionario]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spAlterarFuncionario]
	
	@idfuncionario int,
	@nome varchar(80),
	@funcao	varchar(80),
	@ctps varchar(15),
	@renumeracao real,
	@endere varchar(80),
	@bairro varchar(80),
	@telefone varchar(15),
	@email varchar(80),
	@rg varchar(15),
	@cpf varchar(15),
	@obs varchar(180),
	@celular varchar(15),
	@sobrenome varchar(80),
	@sexo nchar(2)


AS
BEGIN
	update tblfuncionario set nome = @nome ,funcao = @funcao,ctps = @ctps, renumeracao_mensal = @renumeracao,endere =@endere,
	bairro = @bairro,telefone = @telefone,email = @email,rg = @rg, cpf = @cpf, obs = @obs,celular = @celular,sobrenome = @sobrenome, sexo = @sexo where id_funcionario = @idfuncionario
END
GO
/****** Object:  StoredProcedure [dbo].[spAlterarProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlterarProduto]
	@idproduto int,
	@nome varchar(80),
	@decricao varchar(120),
	@unidade_medida varchar(2),
	@Idtipo_produto int
	
AS
BEGIN
	update tblproduto set  nome = @nome ,descricao = @decricao , unidade_medida = @unidade_medida,id_tipoproduto = @Idtipo_produto where id_produto = @idproduto
END

GO
/****** Object:  StoredProcedure [dbo].[spAtualizarSafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAtualizarSafra]
	@idsafra int,
	@descricao varchar(80),
	@status  varchar(15),
	@obs varchar(150),
	@dataincio date,
	@id_cultura int,
	@datafechamento date
AS
BEGIN
	update tblsafra set descricao =@descricao ,[status]=@status,obs=@obs,dataincio= @dataincio,id_cultura=@id_cultura,datafechamento=@datafechamento where id_safra = @idsafra
END
GO
/****** Object:  StoredProcedure [dbo].[spCadastarProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[spCadastarProduto]
	@nome varchar(80),
	@descricao varchar(120),
	@unidade_medida varchar(2),
	@id_tipoproduto int
AS
BEGIN
	INSERT INTO tblproduto (nome,descricao,unidade_medida,id_tipoproduto) values (@nome,@descricao,@unidade_medida,@id_tipoproduto)
END

GO
/****** Object:  StoredProcedure [dbo].[spCadastrarSafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCadastrarSafra]
	@descricao varchar(80),
	@status  varchar(15),
	@obs varchar(150),
	@dataincio date,
	@id_cultura int,
	@datafechamento date
AS
BEGIN
	insert into tblsafra (descricao,[status],obs,dataincio,id_cultura,datafechamento) values (@descricao,@status,@obs,@dataincio,@id_cultura,@datafechamento)
END

GO
/****** Object:  StoredProcedure [dbo].[spDeletarFuncionario]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spDeletarFuncionario]
	@idfuncionario int 
AS
BEGIN
	Delete from tblfuncionario where @idfuncionario = id_funcionario
END
GO
/****** Object:  StoredProcedure [dbo].[spDeletarProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeletarProduto]
	@idproduto int 
AS
BEGIN
	Delete from tblproduto where id_produto = @idproduto
END

GO
/****** Object:  StoredProcedure [dbo].[spDeletarSafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeletarSafra]
	@id_safra int
	
AS
BEGIN
	Delete from tblsafra where id_safra = @id_safra 
END
GO
/****** Object:  StoredProcedure [dbo].[spListaProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaProduto]
	
AS
BEGIN
	SELECT id_produto,nome,descricao,unidade_medida,id_tipoproduto FROM tblproduto
END

GO
/****** Object:  StoredProcedure [dbo].[spListarTalhao]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spListarTalhao]


AS
BEGIN
	select * from tbltalhao 
END

GO
/****** Object:  StoredProcedure [dbo].[spListarTipoCultura]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarTipoCultura]
	
	
AS
BEGIN
	Select * from tblcultura
END
GO
/****** Object:  StoredProcedure [dbo].[spListatipoProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListatipoProduto]
	
AS
BEGIN
	SELECT * FROM tbltipoproduto
END

GO
/****** Object:  StoredProcedure [dbo].[spPesqiosaTipoCultura]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesqiosaTipoCultura]
	@nome varchar(80)
	
AS
BEGIN
	Select * from tblcultura where nome like '%'+@nome+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[spPesquisaFunCPF]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesquisaFunCPF]
	@descricao varchar(15)
AS
BEGIN
	SELECT * FROM tblfuncionario where cpf like '%'+@descricao+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[spPesquisaFunId]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesquisaFunId]
	@descricao int
AS
BEGIN
	SELECT * FROM tblfuncionario where id_funcionario = @descricao
END

GO
/****** Object:  StoredProcedure [dbo].[spPesquisaFunNome]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesquisaFunNome]
	@descricao varchar(80)
AS
BEGIN
	SELECT * FROM tblfuncionario where nome like '%'+@descricao+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[spPesquisaTipoproduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPesquisaTipoproduto]
	@descricao varchar(80)
AS
BEGIN
	SELECT * FROM tbltipoproduto where descicao like '@descricao%'
END

GO
/****** Object:  StoredProcedure [dbo].[spVisualizarFuncionario]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spVisualizarFuncionario]
	@idfuncionario int 
AS
BEGIN
	select * from tblfuncionario where id_funcionario = @idfuncionario
END

GO
/****** Object:  StoredProcedure [dbo].[spVisualizarProduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVisualizarProduto]
	@idproduto int 
AS
BEGIN
	select * from tblproduto where id_produto = @idproduto
END

GO
/****** Object:  Table [dbo].[tblaplicacao]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblaplicacao](
	[id_aplicacao] [int] IDENTITY(1,1) NOT NULL,
	[data_cadastro] [date] NOT NULL,
	[status] [varchar](15) NOT NULL,
	[data_aplicacao] [date] NULL,
	[areaaplicada] [float] NULL,
	[obs] [varchar](200) NULL,
	[descricao] [varchar](80) NULL,
	[id_talhao] [int] NULL,
	[id_safra] [int] NULL,
	[id_ben] [int] NULL,
	[id_funcionario] [int] NULL,
	[tipoaplicaco] [varchar](50) NULL,
 CONSTRAINT [PK_tblaplicacao] PRIMARY KEY CLUSTERED 
(
	[id_aplicacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblaplicacao] UNIQUE NONCLUSTERED 
(
	[id_aplicacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblbens]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblbens](
	[id_ben] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](120) NOT NULL,
	[tipoben] [varchar](80) NOT NULL,
	[codigoControle] [varchar](10) NULL,
	[data_aquisicao] [date] NULL,
	[preco_aquisicao] [real] NULL,
	[horimetro_inicial] [int] NULL,
	[hodometro_inicial] [int] NULL,
	[placa] [varchar](8) NULL,
 CONSTRAINT [PK_tblbens] PRIMARY KEY CLUSTERED 
(
	[id_ben] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblbens] UNIQUE NONCLUSTERED 
(
	[id_ben] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblcultura]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblcultura](
	[id_cultura] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](80) NULL,
 CONSTRAINT [PK_tblcultura] PRIMARY KEY CLUSTERED 
(
	[id_cultura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblfornecedor]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblfornecedor](
	[id_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nomefatasia] [varchar](120) NULL,
	[razaosocial] [varchar](120) NULL,
	[cpf] [varchar](15) NULL,
	[cnpj] [varchar](15) NULL,
	[endereco] [varchar](120) NULL,
	[cidade] [varchar](120) NULL,
	[fone] [varchar](15) NULL,
	[email] [varchar](120) NULL,
	[obs] [varchar](150) NULL,
	[ie] [varchar](13) NULL,
 CONSTRAINT [PK_tblfornecedor] PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblforncedor] UNIQUE NONCLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblfuncionario]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblfuncionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](80) NOT NULL,
	[funcao] [varchar](80) NULL,
	[ctps] [varchar](15) NULL,
	[data_admissao] [date] NULL,
	[renumeracao_mensal] [real] NULL,
	[endere] [varchar](80) NULL,
	[bairro] [varchar](80) NULL,
	[telefone] [varchar](15) NULL,
	[email] [varchar](80) NULL,
	[rg] [varchar](15) NULL,
	[cpf] [varchar](15) NULL,
	[obs] [varchar](180) NULL,
	[celular] [varchar](15) NULL,
	[sobrenome] [varchar](80) NULL,
	[sexo] [nchar](2) NULL,
 CONSTRAINT [PK_tblfuncionario] PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblfuncionario] UNIQUE NONCLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblitenrevisao]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblitenrevisao](
	[id_itenrevisao] [int] IDENTITY(1,1) NOT NULL,
	[preco] [real] NULL,
	[id_produtos] [int] NULL,
	[id_revisao] [int] NULL,
 CONSTRAINT [PK_tbintenrevisao] PRIMARY KEY CLUSTERED 
(
	[id_itenrevisao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblitenrevisao] UNIQUE NONCLUSTERED 
(
	[id_itenrevisao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblproduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblproduto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](80) NOT NULL,
	[descricao] [varchar](120) NULL,
	[unidade_medida] [varchar](2) NULL,
	[id_tipoproduto] [int] NOT NULL,
 CONSTRAINT [PK_tblproduto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblproduto] UNIQUE NONCLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblprodutosaplicado]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblprodutosaplicado](
	[id_produtosaplicado] [int] IDENTITY(1,1) NOT NULL,
	[quantidade] [int] NOT NULL,
	[preco] [real] NULL,
	[id_produto] [int] NOT NULL,
	[id_aplicacao] [int] NULL,
 CONSTRAINT [PK_tblprodutosaplicado] PRIMARY KEY CLUSTERED 
(
	[id_produtosaplicado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblprodutosaplicado] UNIQUE NONCLUSTERED 
(
	[id_produtosaplicado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblrevisaofuturas]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblrevisaofuturas](
	[id_revisao] [int] IDENTITY(1,1) NOT NULL,
	[motivo] [varchar](120) NOT NULL,
	[data_cadastro] [date] NULL,
	[data_revisao] [date] NULL,
	[status] [varchar](12) NULL,
	[id_ben] [int] NOT NULL,
	[id_safra] [int] NOT NULL,
 CONSTRAINT [PK_tblrevisaofuturas] PRIMARY KEY CLUSTERED 
(
	[id_revisao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tblrevisaofuturas] UNIQUE NONCLUSTERED 
(
	[id_revisao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblsafra]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblsafra](
	[id_safra] [int] IDENTITY(1,1) NOT NULL,
	[obs] [varchar](150) NULL,
	[status] [varchar](15) NULL,
	[id_cultura] [int] NULL,
	[dataincio] [date] NOT NULL,
	[descricao] [varchar](80) NULL,
	[datafechamento] [date] NULL,
 CONSTRAINT [PK_tblsafra] PRIMARY KEY CLUSTERED 
(
	[id_safra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbltalhao]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbltalhao](
	[id_talhao] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](80) NOT NULL,
	[localizacao] [varchar](80) NOT NULL,
	[tamanho] [float] NULL,
	[obs] [varchar](150) NULL,
	[sistemaCutivo] [varchar](80) NULL,
 CONSTRAINT [PK_tbltalao] PRIMARY KEY CLUSTERED 
(
	[id_talhao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbltipoproduto]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbltipoproduto](
	[id_tipoproduto] [int] IDENTITY(1,1) NOT NULL,
	[descicao] [varchar](80) NULL,
 CONSTRAINT [PK_tbltipoproduto] PRIMARY KEY CLUSTERED 
(
	[id_tipoproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_tbltipoproduto] UNIQUE NONCLUSTERED 
(
	[id_tipoproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblusuario]    Script Date: 17/03/2013 22:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblusuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](80) NOT NULL,
	[senha] [varchar](30) NOT NULL,
 CONSTRAINT [Pk_tblusuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblaplicacao]  WITH CHECK ADD  CONSTRAINT [FK_tblaplicacao_tblbens] FOREIGN KEY([id_ben])
REFERENCES [dbo].[tblbens] ([id_ben])
GO
ALTER TABLE [dbo].[tblaplicacao] CHECK CONSTRAINT [FK_tblaplicacao_tblbens]
GO
ALTER TABLE [dbo].[tblaplicacao]  WITH CHECK ADD  CONSTRAINT [FK_tblaplicacao_tblfuncionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[tblfuncionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[tblaplicacao] CHECK CONSTRAINT [FK_tblaplicacao_tblfuncionario]
GO
ALTER TABLE [dbo].[tblaplicacao]  WITH CHECK ADD  CONSTRAINT [FK_tblaplicacao_tblsafra] FOREIGN KEY([id_safra])
REFERENCES [dbo].[tblsafra] ([id_safra])
GO
ALTER TABLE [dbo].[tblaplicacao] CHECK CONSTRAINT [FK_tblaplicacao_tblsafra]
GO
ALTER TABLE [dbo].[tblaplicacao]  WITH CHECK ADD  CONSTRAINT [FK_tblaplicacao_tbltalhao] FOREIGN KEY([id_talhao])
REFERENCES [dbo].[tbltalhao] ([id_talhao])
GO
ALTER TABLE [dbo].[tblaplicacao] CHECK CONSTRAINT [FK_tblaplicacao_tbltalhao]
GO
ALTER TABLE [dbo].[tblitenrevisao]  WITH CHECK ADD  CONSTRAINT [FK_tblintenrevisao_tblprodutos] FOREIGN KEY([id_produtos])
REFERENCES [dbo].[tblproduto] ([id_produto])
GO
ALTER TABLE [dbo].[tblitenrevisao] CHECK CONSTRAINT [FK_tblintenrevisao_tblprodutos]
GO
ALTER TABLE [dbo].[tblitenrevisao]  WITH CHECK ADD  CONSTRAINT [FK_tblintenrevisao_tblrevisaofuturas] FOREIGN KEY([id_revisao])
REFERENCES [dbo].[tblrevisaofuturas] ([id_revisao])
GO
ALTER TABLE [dbo].[tblitenrevisao] CHECK CONSTRAINT [FK_tblintenrevisao_tblrevisaofuturas]
GO
ALTER TABLE [dbo].[tblproduto]  WITH CHECK ADD  CONSTRAINT [FK_tblproduto_tbltipoproduto] FOREIGN KEY([id_tipoproduto])
REFERENCES [dbo].[tbltipoproduto] ([id_tipoproduto])
GO
ALTER TABLE [dbo].[tblproduto] CHECK CONSTRAINT [FK_tblproduto_tbltipoproduto]
GO
ALTER TABLE [dbo].[tblprodutosaplicado]  WITH CHECK ADD  CONSTRAINT [FK_tblprodutosaplicado_tblaplicacao] FOREIGN KEY([id_aplicacao])
REFERENCES [dbo].[tblaplicacao] ([id_aplicacao])
GO
ALTER TABLE [dbo].[tblprodutosaplicado] CHECK CONSTRAINT [FK_tblprodutosaplicado_tblaplicacao]
GO
ALTER TABLE [dbo].[tblprodutosaplicado]  WITH CHECK ADD  CONSTRAINT [FK_tblprodutosaplicado_tblproduto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[tblproduto] ([id_produto])
GO
ALTER TABLE [dbo].[tblprodutosaplicado] CHECK CONSTRAINT [FK_tblprodutosaplicado_tblproduto]
GO
ALTER TABLE [dbo].[tblrevisaofuturas]  WITH CHECK ADD  CONSTRAINT [FK_tblrevisaofuturas_tblbens] FOREIGN KEY([id_ben])
REFERENCES [dbo].[tblbens] ([id_ben])
GO
ALTER TABLE [dbo].[tblrevisaofuturas] CHECK CONSTRAINT [FK_tblrevisaofuturas_tblbens]
GO
ALTER TABLE [dbo].[tblrevisaofuturas]  WITH CHECK ADD  CONSTRAINT [Fk_tblrevisaofuturas_tblsafra] FOREIGN KEY([id_safra])
REFERENCES [dbo].[tblsafra] ([id_safra])
GO
ALTER TABLE [dbo].[tblrevisaofuturas] CHECK CONSTRAINT [Fk_tblrevisaofuturas_tblsafra]
GO
ALTER TABLE [dbo].[tblsafra]  WITH CHECK ADD  CONSTRAINT [FK_tblsafra_tblcultura] FOREIGN KEY([id_cultura])
REFERENCES [dbo].[tblcultura] ([id_cultura])
GO
ALTER TABLE [dbo].[tblsafra] CHECK CONSTRAINT [FK_tblsafra_tblcultura]
GO
USE [master]
GO
ALTER DATABASE [dbsysca] SET  READ_WRITE 
GO
