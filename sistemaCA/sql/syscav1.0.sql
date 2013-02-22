


--criando db sysca


Create Database dbsysca;

GO

--usando data base sysca	


use dbsysca;

GO
-- criando tabelas
-- criando tablal funcionario

Create Table tblfuncionario(
	id_funcionario int identity(1,1) not null,
	nome varchar(80) not null,
	funcao varchar(80),
	ctps int,
	data_admissao date ,
	data_demissao date ,
	renumeracao_mensal  float(2),
	endere varchar(80),
	bairro varchar(80),
	cidade varchar(80),
	estado nchar(2),
	telefone varchar(15),
	email varchar(80),
	status varchar(15),
	rg varchar(15),
	cpf varchar(15),

	Constraint UQ_tblfuncionario Unique(id_funcionario),
	Constraint PK_tblfuncionario Primary Key(id_funcionario),
)

go

-- TABLE USUARIO
Create Table tblusuario(
	id_usuario int identity(1,1) not null,
	login VARCHAR(80) not null,
	senha varchar(30) not null,
	id_funcionario int not null,

	--Charve Primaria 
	Constraint Pk_tblusuario Primary Key(id_usuario),
	--chave estrageira tabela funcionario
	
)
go


-- criando tbl modulo aplicação 

--tablea tipo de Cultura 

Create Table tblcultura(
	id_cultura int identity(1,1) not null,
	nome varchar(80),

--colocando id_cultura como chave primaria
	Constraint PK_tblcultura Primary Key(id_cultura)


)


--tabela talhao

Create Table tbltalhao(
	id_talhao int identity(1,1) not null,
	descricao  varchar(80) not null,
	localizacao varchar(80) not null,
	tamanho int not null,
	obs varchar(150) ,
	sistemaCutivo varchar(80),

-- Chave Primaria 
	Constraint PK_tbltalao Primary Key(id_talhao),

)

go





-- tabela safra 

Create Table tblsafra(
	id_safra int identity(1,1) not null,
	ano int not null,
	obs varchar(150),
	status varchar(15),
	id_cultura int ,
--colocando id_safra como chave primaria
	Constraint PK_tblsafra	Primary Key(id_safra),

	
	)


go


-- tablea produtos aplicado 
Create Table tblprodutosaplicado(
	id_produtosaplicado int identity(1,1) not null,
	quantidade int not null,
	preco float(2) ,
	total float(2),

	--referente FK	
	id_produto int not null,
	id_fornecedor int not null,

	Constraint PK_tblprodutosaplicado Primary Key(id_produtosaplicado),
	Constraint UQ_tblprodutosaplicado Unique(id_produtosaplicado),

)



-- criando Tabela aplicacao -->

Create Table tblaplicacao(
	id_aplicacao int identity(1,1) not null,
	data_cadastro date not null,
	status varchar(15) not null,
	data_aplicacao date,
	areaaplicada int,
	-- referente a FK
	id_produtosaplicado int not null,
	id_talhao int not null,
	id_safra int not null,	
	id_ben int not null,
	id_funcionario int not null,

-- colocado id_aplicacao como chave primaria

	Constraint PK_tblaplicacao Primary Key(id_aplicacao),
	Constraint UQ_tblaplicacao Unique(id_aplicacao),

)

go

--tabela produto

Create Table tblproduto(
	id_produto int identity(1,1) not null,
	nome varchar(80) not null,
	descricao varchar(120),
	unidade_medida varchar(2),
	

	--refente fk
	id_tipoproduto int not null,

	Constraint UQ_tblproduto Unique(id_produto),
	Constraint PK_tblproduto Primary Key(id_produto),

)

go


 --tabela tipo produto

Create Table tbltipoproduto(
	id_tipoproduto int identity(1,1) not null,
	descicao varchar(80),

-- have primaria id_tipoproduto
	Constraint UQ_tbltipoproduto Unique(id_tipoproduto),
	Constraint PK_tbltipoproduto Primary Key(id_tipoproduto),


)


go

--  tabela fornecedor

Create Table tblfornecedor(
	id_fornecedor int identity(1,1) not null,
	nomefatasia varchar(120),
	razaosocial varchar(120),
	cpf varchar(15),
	cnpj varchar(15),
	endereco varchar(120),
	cidade varchar(120),
	fone varchar(15),
	email varchar(120),
	obs varchar(150),


 -- id_fornecedor chave primaria
	Constraint PK_tblfornecedor Primary Key(id_fornecedor),
	Constraint UQ_tblforncedor Unique(id_fornecedor),
)



--  tabela bens



Create Table tblbens(
	id_ben int identity(1,1) not null,
	descricao varchar(120) not null,
	tipoben varchar(80) not null,
	codigoControle varchar(4),
	data_aquisicao date,
	preco_aquisicao float(2),
	horimetro_inicial int,
	hodometro_inicial int,


	Constraint UQ_tblbens Unique(id_ben),
	Constraint PK_tblbens Primary Key(id_ben),


)

--tabela revisao futuras

Create Table tblrevisaofuturas(
	id_revisao int identity(1,1) not null,
	motivo varchar(120) not null,
	data_cadastro date,
	data_revisao date,
	status varchar(12),
	id_ben int not null,
	id_safra int not null,
	id_itenrevisao  int not null,


	Constraint UQ_tblrevisaofuturas Unique(id_revisao),
	Constraint PK_tblrevisaofuturas Primary Key(id_revisao),


)


--tabela intens da revisao

Create Table tblitenrevisao(
	id_itenrevisao int identity(1,1) not null,
	preco float(2),


	Constraint PK_tbintenrevisao Primary Key(id_itenrevisao),
	Constraint UQ_tblitenrevisao Unique(id_itenrevisao),

)




-- Aterando tabela e fazendo o relacionamento entre elas


-- alterando tabela para relacionamento 



--tabela usuario
alter table tblusuario
add Constraint FK_tblusuario Foreign Key(id_funcionario) references tblfuncionario(id_funcionario);



-- tabela safra

--Chave estrangeira tbl cultura
alter table tblsafra
add Constraint FK_tblsafra_tblcultura Foreign Key(id_cultura) references tblcultura(id_cultura);
	


--tablela Produtos Aplicado
Alter Table tblprodutosaplicado
Add Constraint FK_tblprodutosaplicado_tblproduto Foreign Key(id_produto) references tblproduto(id_produto),
Constraint FK_tblprodutosaplicado_tblfornecedor Foreign Key(id_fornecedor) references tblfornecedor(id_fornecedor);


-- tabela aplicacao


Alter Table tblaplicacao
Add Constraint FK_tblaplicacao_tblprodutoaplicado Foreign Key(id_produtosaplicado) references tblprodutosaplicado(id_produtosaplicado),
Constraint FK_tblaplicacao_tbltalhao Foreign Key(id_talhao) references tbltalhao(id_talhao),
Constraint FK_tblaplicacao_tblsafra Foreign Key(id_safra) references tblsafra(id_safra),
Constraint FK_tblaplicacao_tblbens Foreign Key(id_ben) references tblbens(id_ben),
Constraint FK_tblaplicacao_tblfuncionario Foreign Key(id_funcionario) references tblfuncionario(id_funcionario);

--tabela Produtos

Alter Table tblproduto
Add Constraint FK_tblproduto_tbltipoproduto Foreign Key(id_tipoproduto) references tbltipoproduto(id_tipoproduto);




--tabela Revisao Futuras

Alter Table tblrevisaofuturas Add
Constraint FK_tblrevisaofuturas_tblbens Foreign Key(id_ben) references tblbens(id_ben),
Constraint FK_tblrevisaofuturas_tblintenrevisao Foreign Key(id_itenrevisao) references tblitenrevisao(id_itenrevisao),
Constraint Fk_tblrevisaofuturas_tblsafra Foreign Key(id_safra) references tblsafra(id_safra);


