/*
Navicat SQL Server Data Transfer

Source Server         : Projeto Agro
Source Server Version : 110000
Source Host           : NOT-EDUARDO\SYSCA:1433
Source Database       : dbsysca
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2013-02-27 00:15:42
*/


-- ----------------------------
-- Table structure for [sysdiagrams]
-- ----------------------------
CREATE TABLE [sysdiagrams] (
[name] sysname NOT NULL ,
[principal_id] int NOT NULL ,
[diagram_id] int NOT NULL IDENTITY(1,1) ,
[version] int NULL ,
[definition] varbinary(MAX) NULL 
)


GO

-- ----------------------------
-- Records of sysdiagrams
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [sysdiagrams] ON
GO
SET IDENTITY_INSERT [sysdiagrams] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblaplicacao]
-- ----------------------------
CREATE TABLE [tblaplicacao] (
[id_aplicacao] int NOT NULL IDENTITY(1,1) ,
[data_cadastro] date NOT NULL ,
[status] varchar(15) NOT NULL ,
[data_aplicacao] date NULL ,
[areaaplicada] int NULL ,
[id_produtosaplicado] int NOT NULL ,
[id_talhao] int NOT NULL ,
[id_safra] int NOT NULL ,
[id_ben] int NOT NULL ,
[id_funcionario] int NOT NULL 
)


GO

-- ----------------------------
-- Records of tblaplicacao
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblaplicacao] ON
GO
SET IDENTITY_INSERT [tblaplicacao] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblbens]
-- ----------------------------
CREATE TABLE [tblbens] (
[id_ben] int NOT NULL IDENTITY(1,1) ,
[descricao] varchar(120) NOT NULL ,
[tipoben] varchar(80) NOT NULL ,
[codigoControle] varchar(4) NULL ,
[data_aquisicao] date NULL ,
[preco_aquisicao] real NULL ,
[horimetro_inicial] int NULL ,
[hodometro_inicial] int NULL 
)


GO

-- ----------------------------
-- Records of tblbens
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblbens] ON
GO
SET IDENTITY_INSERT [tblbens] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblcultura]
-- ----------------------------
CREATE TABLE [tblcultura] (
[id_cultura] int NOT NULL IDENTITY(1,1) ,
[nome] varchar(80) NULL 
)


GO

-- ----------------------------
-- Records of tblcultura
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblcultura] ON
GO
SET IDENTITY_INSERT [tblcultura] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblfornecedor]
-- ----------------------------
CREATE TABLE [tblfornecedor] (
[id_fornecedor] int NOT NULL IDENTITY(1,1) ,
[nomefatasia] varchar(120) NULL ,
[razaosocial] varchar(120) NULL ,
[cpf] varchar(15) NULL ,
[cnpj] varchar(15) NULL ,
[endereco] varchar(120) NULL ,
[cidade] varchar(120) NULL ,
[fone] varchar(15) NULL ,
[email] varchar(120) NULL ,
[obs] varchar(150) NULL 
)


GO

-- ----------------------------
-- Records of tblfornecedor
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblfornecedor] ON
GO
SET IDENTITY_INSERT [tblfornecedor] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblfuncionario]
-- ----------------------------
CREATE TABLE [tblfuncionario] (
[id_funcionario] int NOT NULL IDENTITY(1,1) ,
[nome] varchar(80) NOT NULL ,
[funcao] varchar(80) NULL ,
[ctps] varchar(15) NULL ,
[data_admissao] date NULL ,
[renumeracao_mensal] real NULL ,
[endere] varchar(80) NULL ,
[bairro] varchar(80) NULL ,
[telefone] varchar(15) NULL ,
[email] varchar(80) NULL ,
[rg] varchar(15) NULL ,
[cpf] varchar(15) NULL ,
[obs] varchar(180) NULL ,
[celular] varchar(15) NULL ,
[sobrenome] varchar(80) NULL ,
[sexo] nchar(2) NULL 
)


GO
DBCC CHECKIDENT(N'[tblfuncionario]', RESEED, 19)
GO

-- ----------------------------
-- Records of tblfuncionario
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblfuncionario] ON
GO
INSERT INTO [tblfuncionario] ([id_funcionario], [nome], [funcao], [ctps], [data_admissao], [renumeracao_mensal], [endere], [bairro], [telefone], [email], [rg], [cpf], [obs], [celular], [sobrenome], [sexo]) VALUES (N'1', N'Eduardo', N'Analista de Ti', N'15458785', N'2012-01-11', N'1500', N'545345345', N'rua dourados', N'6599463782', N'edu.avila@gmail.com', N'154878565', N'34234', N'asdsadasdasdasdasdas', N'32432432', N'avila', null);
INSERT INTO [tblfuncionario] ([id_funcionario], [nome], [funcao], [ctps], [data_admissao], [renumeracao_mensal], [endere], [bairro], [telefone], [email], [rg], [cpf], [obs], [celular], [sobrenome], [sexo]) VALUES (N'18', N'Anantan ', N'sadsadasdas', N'2342343242', N'2013-02-22', N'3.423432E7', N'sdadasdas', N'rua sdahdsi', N'32432423', N'saddasdsadas', N'32432432', N'34324234', N'asdasdasdas', N'23432432', N'biba', N'M ');
INSERT INTO [tblfuncionario] ([id_funcionario], [nome], [funcao], [ctps], [data_admissao], [renumeracao_mensal], [endere], [bairro], [telefone], [email], [rg], [cpf], [obs], [celular], [sobrenome], [sexo]) VALUES (N'19', N'matheus ', N'sdasdasd', N'234324', N'2013-02-11', N'2.343243E7', N'dscsdfasdas', N'dasdhaushduah', N'32432432', N'sdsadsadas', N'2343242', N'234324324', N'asdasdasdasda', N'234324', N'pessoa', N'M ');
GO
SET IDENTITY_INSERT [tblfuncionario] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblitenrevisao]
-- ----------------------------
CREATE TABLE [tblitenrevisao] (
[id_itenrevisao] int NOT NULL IDENTITY(1,1) ,
[preco] real NULL 
)


GO

-- ----------------------------
-- Records of tblitenrevisao
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblitenrevisao] ON
GO
SET IDENTITY_INSERT [tblitenrevisao] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblproduto]
-- ----------------------------
CREATE TABLE [tblproduto] (
[id_produto] int NOT NULL IDENTITY(1,1) ,
[nome] varchar(80) NOT NULL ,
[descricao] varchar(120) NULL ,
[unidade_medida] varchar(2) NULL ,
[id_tipoproduto] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[tblproduto]', RESEED, 6)
GO

-- ----------------------------
-- Records of tblproduto
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblproduto] ON
GO
INSERT INTO [tblproduto] ([id_produto], [nome], [descricao], [unidade_medida], [id_tipoproduto]) VALUES (N'1', N'sojadasd', N'', N'sc', N'1');
INSERT INTO [tblproduto] ([id_produto], [nome], [descricao], [unidade_medida], [id_tipoproduto]) VALUES (N'3', N'parafuso', N'parafuso de rosca fina', N'pc', N'1');
INSERT INTO [tblproduto] ([id_produto], [nome], [descricao], [unidade_medida], [id_tipoproduto]) VALUES (N'4', N'asuidhasidhasi', N'asidhasihdaiu', N'ml', N'1');
GO
SET IDENTITY_INSERT [tblproduto] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblprodutosaplicado]
-- ----------------------------
CREATE TABLE [tblprodutosaplicado] (
[id_produtosaplicado] int NOT NULL IDENTITY(1,1) ,
[quantidade] int NOT NULL ,
[preco] real NULL ,
[total] real NULL ,
[id_produto] int NOT NULL ,
[id_fornecedor] int NOT NULL 
)


GO

-- ----------------------------
-- Records of tblprodutosaplicado
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblprodutosaplicado] ON
GO
SET IDENTITY_INSERT [tblprodutosaplicado] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblrevisaofuturas]
-- ----------------------------
CREATE TABLE [tblrevisaofuturas] (
[id_revisao] int NOT NULL IDENTITY(1,1) ,
[motivo] varchar(120) NOT NULL ,
[data_cadastro] date NULL ,
[data_revisao] date NULL ,
[status] varchar(12) NULL ,
[id_ben] int NOT NULL ,
[id_safra] int NOT NULL ,
[id_itenrevisao] int NOT NULL 
)


GO

-- ----------------------------
-- Records of tblrevisaofuturas
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblrevisaofuturas] ON
GO
SET IDENTITY_INSERT [tblrevisaofuturas] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblsafra]
-- ----------------------------
CREATE TABLE [tblsafra] (
[id_safra] int NOT NULL IDENTITY(1,1) ,
[ano] int NOT NULL ,
[obs] varchar(150) NULL ,
[status] varchar(15) NULL ,
[id_cultura] int NULL 
)


GO

-- ----------------------------
-- Records of tblsafra
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblsafra] ON
GO
SET IDENTITY_INSERT [tblsafra] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tbltalhao]
-- ----------------------------
CREATE TABLE [tbltalhao] (
[id_talhao] int NOT NULL IDENTITY(1,1) ,
[descricao] varchar(80) NOT NULL ,
[localizacao] varchar(80) NOT NULL ,
[tamanho] int NOT NULL ,
[obs] varchar(150) NULL ,
[sistemaCutivo] varchar(80) NULL 
)


GO

-- ----------------------------
-- Records of tbltalhao
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tbltalhao] ON
GO
SET IDENTITY_INSERT [tbltalhao] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tbltipoproduto]
-- ----------------------------
CREATE TABLE [tbltipoproduto] (
[id_tipoproduto] int NOT NULL IDENTITY(1,1) ,
[descicao] varchar(80) NULL 
)


GO

-- ----------------------------
-- Records of tbltipoproduto
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tbltipoproduto] ON
GO
INSERT INTO [tbltipoproduto] ([id_tipoproduto], [descicao]) VALUES (N'1', N'graão');
GO
SET IDENTITY_INSERT [tbltipoproduto] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [tblusuario]
-- ----------------------------
CREATE TABLE [tblusuario] (
[id_usuario] int NOT NULL IDENTITY(1,1) ,
[login] varchar(80) NOT NULL ,
[senha] varchar(30) NOT NULL ,
[id_funcionario] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[tblusuario]', RESEED, 2)
GO

-- ----------------------------
-- Records of tblusuario
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tblusuario] ON
GO
INSERT INTO [tblusuario] ([id_usuario], [login], [senha], [id_funcionario]) VALUES (N'1', N'admin', N'admin', N'1');
INSERT INTO [tblusuario] ([id_usuario], [login], [senha], [id_funcionario]) VALUES (N'2', N'admin2', N'veralucia', N'1');
GO
SET IDENTITY_INSERT [tblusuario] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Procedure structure for [sp_alterdiagram]
-- ----------------------------

	CREATE PROCEDURE [sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_creatediagram]
-- ----------------------------

	CREATE PROCEDURE [sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_dropdiagram]
-- ----------------------------

	CREATE PROCEDURE [sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_helpdiagramdefinition]
-- ----------------------------

	CREATE PROCEDURE [sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_helpdiagrams]
-- ----------------------------

	CREATE PROCEDURE [sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_renamediagram]
-- ----------------------------

	CREATE PROCEDURE [sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_upgraddiagrams]
-- ----------------------------

	CREATE PROCEDURE [sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	
GO

-- ----------------------------
-- Procedure structure for [spAlterarFuncionario]
-- ----------------------------
create PROCEDURE [spAlterarFuncionario]
	
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

-- ----------------------------
-- Procedure structure for [spAlterarProduto]
-- ----------------------------
CREATE PROCEDURE [spAlterarProduto]
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

-- ----------------------------
-- Procedure structure for [spCadastarProduto]
-- ----------------------------

-- =============================================
CREATE PROCEDURE [spCadastarProduto]
	@nome varchar(80),
	@descricao varchar(120),
	@unidade_medida varchar(2),
	@id_tipoproduto int
AS
BEGIN
	INSERT INTO tblproduto (nome,descricao,unidade_medida,id_tipoproduto) values (@nome,@descricao,@unidade_medida,@id_tipoproduto)
END

GO

-- ----------------------------
-- Procedure structure for [spDeletarFuncionario]
-- ----------------------------
create PROCEDURE [spDeletarFuncionario]
	@idfuncionario int 
AS
BEGIN
	Delete from tblfuncionario where @idfuncionario = id_funcionario
END
GO

-- ----------------------------
-- Procedure structure for [spDeletarProduto]
-- ----------------------------
CREATE PROCEDURE [spDeletarProduto]
	@idproduto int 
AS
BEGIN
	Delete from tblproduto where id_produto = @idproduto
END

GO

-- ----------------------------
-- Procedure structure for [spListaProduto]
-- ----------------------------
CREATE PROCEDURE [spListaProduto]
	
AS
BEGIN
	SELECT id_produto,nome,descricao,unidade_medida,id_tipoproduto FROM tblproduto
END

GO

-- ----------------------------
-- Procedure structure for [spListatipoProduto]
-- ----------------------------
CREATE PROCEDURE [spListatipoProduto]
	
AS
BEGIN
	SELECT * FROM tbltipoproduto
END

GO

-- ----------------------------
-- Procedure structure for [spPesquisaFunCPF]
-- ----------------------------
CREATE PROCEDURE [spPesquisaFunCPF]
	@descricao varchar(15)
AS
BEGIN
	SELECT * FROM tblfuncionario where cpf like '%'+@descricao+'%'
END

GO

-- ----------------------------
-- Procedure structure for [spPesquisaFunId]
-- ----------------------------
CREATE PROCEDURE [spPesquisaFunId]
	@descricao int
AS
BEGIN
	SELECT * FROM tblfuncionario where id_funcionario = @descricao
END

GO

-- ----------------------------
-- Procedure structure for [spPesquisaFunNome]
-- ----------------------------
CREATE PROCEDURE [spPesquisaFunNome]
	@descricao varchar(80)
AS
BEGIN
	SELECT * FROM tblfuncionario where nome like '%'+@descricao+'%'
END

GO

-- ----------------------------
-- Procedure structure for [spPesquisaTipoproduto]
-- ----------------------------
CREATE PROCEDURE [spPesquisaTipoproduto]
	@descricao varchar(80)
AS
BEGIN
	SELECT * FROM tbltipoproduto where descicao like '@descricao%'
END

GO

-- ----------------------------
-- Procedure structure for [spVisualizarFuncionario]
-- ----------------------------
create PROCEDURE [spVisualizarFuncionario]
	@idfuncionario int 
AS
BEGIN
	select * from tblfuncionario where id_funcionario = @idfuncionario
END

GO

-- ----------------------------
-- Procedure structure for [spVisualizarProduto]
-- ----------------------------
CREATE PROCEDURE [spVisualizarProduto]
	@idproduto int 
AS
BEGIN
	select * from tblproduto where id_produto = @idproduto
END

GO

-- ----------------------------
-- Function structure for [fn_diagramobjects]
-- ----------------------------

	CREATE FUNCTION [fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	
GO

-- ----------------------------
-- Indexes structure for table sysdiagrams
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sysdiagrams]
-- ----------------------------
ALTER TABLE [sysdiagrams] ADD PRIMARY KEY ([diagram_id])
GO

-- ----------------------------
-- Uniques structure for table [sysdiagrams]
-- ----------------------------
ALTER TABLE [sysdiagrams] ADD UNIQUE ([principal_id] ASC, [name] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblaplicacao
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblaplicacao]
-- ----------------------------
ALTER TABLE [tblaplicacao] ADD PRIMARY KEY ([id_aplicacao])
GO

-- ----------------------------
-- Uniques structure for table [tblaplicacao]
-- ----------------------------
ALTER TABLE [tblaplicacao] ADD UNIQUE ([id_aplicacao] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblbens
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblbens]
-- ----------------------------
ALTER TABLE [tblbens] ADD PRIMARY KEY ([id_ben])
GO

-- ----------------------------
-- Uniques structure for table [tblbens]
-- ----------------------------
ALTER TABLE [tblbens] ADD UNIQUE ([id_ben] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblcultura
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblcultura]
-- ----------------------------
ALTER TABLE [tblcultura] ADD PRIMARY KEY ([id_cultura])
GO

-- ----------------------------
-- Indexes structure for table tblfornecedor
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblfornecedor]
-- ----------------------------
ALTER TABLE [tblfornecedor] ADD PRIMARY KEY ([id_fornecedor])
GO

-- ----------------------------
-- Uniques structure for table [tblfornecedor]
-- ----------------------------
ALTER TABLE [tblfornecedor] ADD UNIQUE ([id_fornecedor] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblfuncionario
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblfuncionario]
-- ----------------------------
ALTER TABLE [tblfuncionario] ADD PRIMARY KEY ([id_funcionario])
GO

-- ----------------------------
-- Uniques structure for table [tblfuncionario]
-- ----------------------------
ALTER TABLE [tblfuncionario] ADD UNIQUE ([id_funcionario] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblitenrevisao
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblitenrevisao]
-- ----------------------------
ALTER TABLE [tblitenrevisao] ADD PRIMARY KEY ([id_itenrevisao])
GO

-- ----------------------------
-- Uniques structure for table [tblitenrevisao]
-- ----------------------------
ALTER TABLE [tblitenrevisao] ADD UNIQUE ([id_itenrevisao] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblproduto
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblproduto]
-- ----------------------------
ALTER TABLE [tblproduto] ADD PRIMARY KEY ([id_produto])
GO

-- ----------------------------
-- Uniques structure for table [tblproduto]
-- ----------------------------
ALTER TABLE [tblproduto] ADD UNIQUE ([id_produto] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblprodutosaplicado
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblprodutosaplicado]
-- ----------------------------
ALTER TABLE [tblprodutosaplicado] ADD PRIMARY KEY ([id_produtosaplicado])
GO

-- ----------------------------
-- Uniques structure for table [tblprodutosaplicado]
-- ----------------------------
ALTER TABLE [tblprodutosaplicado] ADD UNIQUE ([id_produtosaplicado] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblrevisaofuturas
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblrevisaofuturas]
-- ----------------------------
ALTER TABLE [tblrevisaofuturas] ADD PRIMARY KEY ([id_revisao])
GO

-- ----------------------------
-- Uniques structure for table [tblrevisaofuturas]
-- ----------------------------
ALTER TABLE [tblrevisaofuturas] ADD UNIQUE ([id_revisao] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblsafra
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblsafra]
-- ----------------------------
ALTER TABLE [tblsafra] ADD PRIMARY KEY ([id_safra])
GO

-- ----------------------------
-- Indexes structure for table tbltalhao
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tbltalhao]
-- ----------------------------
ALTER TABLE [tbltalhao] ADD PRIMARY KEY ([id_talhao])
GO

-- ----------------------------
-- Indexes structure for table tbltipoproduto
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tbltipoproduto]
-- ----------------------------
ALTER TABLE [tbltipoproduto] ADD PRIMARY KEY ([id_tipoproduto])
GO

-- ----------------------------
-- Uniques structure for table [tbltipoproduto]
-- ----------------------------
ALTER TABLE [tbltipoproduto] ADD UNIQUE ([id_tipoproduto] ASC)
GO

-- ----------------------------
-- Indexes structure for table tblusuario
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [tblusuario]
-- ----------------------------
ALTER TABLE [tblusuario] ADD PRIMARY KEY ([id_usuario])
GO

-- ----------------------------
-- Foreign Key structure for table [tblaplicacao]
-- ----------------------------
ALTER TABLE [tblaplicacao] ADD FOREIGN KEY ([id_ben]) REFERENCES [tblbens] ([id_ben]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblaplicacao] ADD FOREIGN KEY ([id_funcionario]) REFERENCES [tblfuncionario] ([id_funcionario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblaplicacao] ADD FOREIGN KEY ([id_produtosaplicado]) REFERENCES [tblprodutosaplicado] ([id_produtosaplicado]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblaplicacao] ADD FOREIGN KEY ([id_safra]) REFERENCES [tblsafra] ([id_safra]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblaplicacao] ADD FOREIGN KEY ([id_talhao]) REFERENCES [tbltalhao] ([id_talhao]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tblproduto]
-- ----------------------------
ALTER TABLE [tblproduto] ADD FOREIGN KEY ([id_tipoproduto]) REFERENCES [tbltipoproduto] ([id_tipoproduto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tblprodutosaplicado]
-- ----------------------------
ALTER TABLE [tblprodutosaplicado] ADD FOREIGN KEY ([id_fornecedor]) REFERENCES [tblfornecedor] ([id_fornecedor]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblprodutosaplicado] ADD FOREIGN KEY ([id_produto]) REFERENCES [tblproduto] ([id_produto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tblrevisaofuturas]
-- ----------------------------
ALTER TABLE [tblrevisaofuturas] ADD FOREIGN KEY ([id_ben]) REFERENCES [tblbens] ([id_ben]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblrevisaofuturas] ADD FOREIGN KEY ([id_itenrevisao]) REFERENCES [tblitenrevisao] ([id_itenrevisao]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tblrevisaofuturas] ADD FOREIGN KEY ([id_safra]) REFERENCES [tblsafra] ([id_safra]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tblsafra]
-- ----------------------------
ALTER TABLE [tblsafra] ADD FOREIGN KEY ([id_cultura]) REFERENCES [tblcultura] ([id_cultura]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tblusuario]
-- ----------------------------
ALTER TABLE [tblusuario] ADD FOREIGN KEY ([id_funcionario]) REFERENCES [tblfuncionario] ([id_funcionario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
