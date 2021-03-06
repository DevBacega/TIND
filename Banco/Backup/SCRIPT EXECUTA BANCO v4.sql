USE [master]
GO
/****** Object:  Database [tind4s]    Script Date: 11/9/2019 11:42:23 PM ******/
CREATE DATABASE [tind4s]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tind4s', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\tind4s.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tind4s_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\tind4s_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [tind4s] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tind4s].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tind4s] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tind4s] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tind4s] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tind4s] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tind4s] SET ARITHABORT OFF 
GO
ALTER DATABASE [tind4s] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [tind4s] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tind4s] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tind4s] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tind4s] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tind4s] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tind4s] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tind4s] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tind4s] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tind4s] SET  ENABLE_BROKER 
GO
ALTER DATABASE [tind4s] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tind4s] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tind4s] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tind4s] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tind4s] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tind4s] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tind4s] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tind4s] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tind4s] SET  MULTI_USER 
GO
ALTER DATABASE [tind4s] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tind4s] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tind4s] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tind4s] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tind4s] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tind4s] SET QUERY_STORE = OFF
GO
USE [tind4s]
GO
/****** Object:  Table [dbo].[TB_Alternativas]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Alternativas](
	[Id_Alternativas] [int] IDENTITY(1,1) NOT NULL,
	[Ds_Alternativa] [varchar](500) NULL,
	[St_Verificacao] [int] NULL,
	[Id_Questao] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Alternativas] ASC,
	[Id_Questao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Curso]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Curso](
	[Id_Curso] [int] IDENTITY(1,1) NOT NULL,
	[Nm_Curso] [varchar](150) NULL,
	[Abrev_Nm_Curso] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Materia](
	[Id_Materia] [int] IDENTITY(1,1) NOT NULL,
	[Nm_Materia] [varchar](150) NULL,
	[Abrev_Nm_Materia] [varchar](10) NULL,
	[Id_Curso] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Prova](
	[Id_Prova] [int] IDENTITY(1,1) NOT NULL,
	[Nm_Prova] [varchar](150) NULL,
	[St_Prova] [int] NULL,
	[Id_Prontuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Prova] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Questao](
	[Id_Questao] [int] IDENTITY(1,1) NOT NULL,
	[Ds_Pergunta] [varchar](500) NULL,
	[St_Pergunta] [int] NULL,
	[Ds_Justificativa] [varchar](500) NULL,
	[Id_Prontuario] [int] NULL,
	[Id_Materia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Questao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_QuestaoProva]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_QuestaoProva](
	[Id_Questao] [int] NOT NULL,
	[Id_Prova] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Questao] ASC,
	[Id_Prova] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Usuario](
	[Id_Prontuario] [int] IDENTITY(1,1) NOT NULL,
	[Ds_Usuario] [varchar](10) NOT NULL,
	[Ds_Senha] [varchar](10) NOT NULL,
	[Nm_Usuario] [varchar](150) NOT NULL,
	[St_Usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Prontuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TB_Alternativas]  WITH CHECK ADD FOREIGN KEY([Id_Questao])
REFERENCES [dbo].[TB_Questao] ([Id_Questao])
GO
ALTER TABLE [dbo].[TB_Materia]  WITH CHECK ADD FOREIGN KEY([Id_Curso])
REFERENCES [dbo].[TB_Curso] ([Id_Curso])
GO
ALTER TABLE [dbo].[TB_Prova]  WITH CHECK ADD FOREIGN KEY([Id_Prontuario])
REFERENCES [dbo].[TB_Usuario] ([Id_Prontuario])
GO
ALTER TABLE [dbo].[TB_Questao]  WITH CHECK ADD FOREIGN KEY([Id_Materia])
REFERENCES [dbo].[TB_Materia] ([Id_Materia])
GO
ALTER TABLE [dbo].[TB_Questao]  WITH CHECK ADD FOREIGN KEY([Id_Prontuario])
REFERENCES [dbo].[TB_Usuario] ([Id_Prontuario])
GO
ALTER TABLE [dbo].[TB_QuestaoProva]  WITH CHECK ADD FOREIGN KEY([Id_Prova])
REFERENCES [dbo].[TB_Prova] ([Id_Prova])
GO
ALTER TABLE [dbo].[TB_QuestaoProva]  WITH CHECK ADD FOREIGN KEY([Id_Questao])
REFERENCES [dbo].[TB_Questao] ([Id_Questao])
GO
/****** Object:  StoredProcedure [dbo].[sp_Criar_Tb]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_Criar_Tb] as
GO
/****** Object:  StoredProcedure [dbo].[sp_Grid_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Grid_Usuario]
as
begin
	select U.Id_Prontuario As Prontuario, U.Nm_Usuario As Nome
	from TB_Usuario as U
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_Inativo_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Inativo_Prova](@pId int)
as
begin
	Declare @Status int;
	Set @Status = (Select St_Prova from TB_Prova where Id_Prova = @pId)

	IF @Status = 1
		Update TB_Prova Set St_Prova = 0 Where Id_Prova = @pId
	ELSE 
		Update TB_Prova Set St_Prova = 1 Where Id_Prova = @pId
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Inativo_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Inativo_Questao](@pId int)
as
begin
	Declare @Status TINYINT;
	Set @Status = (Select St_Pergunta from TB_Questao where Id_Questao = @pId)

	IF @Status = 1
		Update TB_Questao Set St_Pergunta = 0 Where Id_Questao = @pId
	ELSE 
		Update TB_Questao Set St_Pergunta = 1 Where Id_Questao = @pId
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_Inativo_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Inativo_Usuario](@pId_Usuario int)
as
begin
	Declare @Status TINYINT;
	Set @Status = (Select St_Usuario from TB_Usuario where Id_Prontuario = @pId_Usuario)

	IF @Status = 1
		Update TB_Usuario Set St_Usuario = 0 Where Id_Prontuario = @pId_Usuario
	ELSE 
		Update TB_Usuario Set St_Usuario = 1 Where Id_Prontuario = @pId_Usuario
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Alternarivas]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Alternarivas](@pDs_Alternativa Varchar(500),
									 @pVerificacao int,
									 @pId_Questao int)
as
begin
	insert into TB_Alternativas(Ds_Alternativa, St_Verificacao, Id_Questao) values(@pDs_Alternativa, @pVerificacao,@pId_Questao);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Curso]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Curso](@pNm_Curso varchar(150),
							  @pAbrev_Nm_Curso varchar(10)) as
begin
	insert into TB_Curso(Nm_Curso, Abrev_Nm_Curso) values(@pNm_Curso, @pAbrev_Nm_Curso);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Materia](@pId_Curso int,
								@pNm_Materia Varchar(150),
								@pAbrev_Nm_Materia Varchar(10))as
begin
	insert into TB_Materia(Id_Curso, Nm_Materia, Abrev_Nm_Materia) values(@pId_Curso, @pNm_Materia, @pAbrev_Nm_Materia);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Prova](@pNm_Prova varchar(150),
							  @pSt_Prova int,
							  @pId_Prontuario int)
as
begin
	insert into TB_Prova(Nm_Prova, St_Prova, Id_Prontuario)
	values(@pNm_Prova, @pSt_Prova, @pId_Prontuario);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Questao](@pDs_Pergunta Varchar(500),
								@pDs_Justificativa Varchar(500),
								@pId_Materia int,
								@pId_Prontuario int,
								@pSt_Pergunta int)
as
begin
	insert into TB_Questao(Ds_Pergunta,  
						   Ds_Justificativa, 
						   Id_Materia, 
						   Id_Prontuario, 
						   St_Pergunta) 
					values(@pDs_Pergunta, 
						   @pDs_Justificativa, 
						   @pId_Materia, 
						   @pId_Prontuario, 
						   @pSt_Pergunta);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Questao_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Questao_Prova](@pId_Prova int, @pId_Questao int)
as
begin
	insert into TB_QuestaoProva(Id_Prova, Id_Questao)values(@pId_Prova, @pId_Questao);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Turma]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Turma](@pId_Curso int,
							  @pDs_Periodo Varchar(10))
as
begin
	insert into TB_Turma(Id_Curso, Ds_Periodo) values(@pId_Curso, @pDs_Periodo);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Ins_Usuario](@pNm_Usuario Varchar(150),
								@pDs_Usuario varchar(10),
								@pDs_Senha varchar(10),
								@pSt_Usuario int)
as
begin
	Insert into TB_Usuario(Nm_Usuario, Ds_Usuario, Ds_Senha, St_Usuario) values(@pNm_Usuario, @pDs_Usuario, @pDs_Senha, @pSt_Usuario);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_MAX_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_MAX_Questao]
as
begin
    SELECT MAX(Id_Questao) AS IDNOVO
	from TB_Questao
end;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Selecionar_Curso_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Selecionar_Curso_Materia](@pIdCurso int)
as
begin

SELECT Id_Materia, Nm_Materia FROM TB_MATERIA WHERE Id_Curso = @pIdCurso
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Alternativa]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Alternativa]
as
begin
	Select Id_Alternativas, Ds_Alternativa, St_Verificacao
	from TB_Alternativas
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Curso]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Curso]
as
begin
	Select Id_Curso, Nm_Curso, Abrev_Nm_Curso
	from TB_Curso
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Materia]
as
begin
	Select M.Id_Materia, M.Abrev_Nm_Materia, M.Nm_Materia, M.Id_Curso, C.Nm_Curso
	from TB_Materia as M inner join TB_Curso as C ON M.Id_Curso = C.Id_Curso
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Prova]
as
begin
	Select Id_Prova, Nm_Prova, St_Prova, Id_Prontuario
	from TB_Prova
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_QsProva]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_QsProva]
as
begin
	Select Id_Prova, Id_Questao
	from TB_QuestaoProva
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Questao]
as
begin
	Select Id_Questao, Ds_Pergunta, Ds_Justificativa, U.Nm_Usuario, M.Nm_Materia, St_Pergunta 
	from TB_Questao as Q
	inner join TB_Usuario as U on(Q.Id_Prontuario = U.Id_Prontuario)
	inner join TB_Materia as M on(Q.Id_Materia = M.Id_Materia)
	where St_Pergunta = 1;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Select_Usuario]
as
begin
	Select Id_Prontuario, Ds_Usuario, Ds_Senha, Nm_Usuario, St_Usuario 
	from TB_usuario
	where St_Usuario = 1
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Alternativa]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Alternativa](@pId int)
as
begin
	Select Id_Alternativas, Ds_Alternativa, St_Verificacao, Id_Questao
	from TB_Alternativas
	where Id_Questao = @pId;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Curso]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Curso](@pId int)
as
begin
	Select Id_Curso, Nm_Curso, Abrev_Nm_Curso
	from TB_Curso
	where Id_Curso = @pId;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Materia](@pId int)
as
begin
	Select Id_Materia, Nm_Materia, Abrev_Nm_Materia, Id_Curso
	from TB_Materia
	where Id_Materia = @pId;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Prova](@pId int)
as
begin
	Select Id_Prova, Nm_Prova, St_Prova, Id_Prontuario
	from TB_Prova
	where Id_Prova = @pId
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_QsProva]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_QsProva](@pId int)
as
begin
	Select Id_Prova, Id_Questao
	from TB_QuestaoProva
	where Id_Prova = @pId;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Questao](@pId int)
as
begin
	Select Id_Questao, Ds_Pergunta, Ds_Justificativa, Id_Prontuario, Id_Materia, St_Pergunta 
	from TB_Questao
	where St_Pergunta = 1 and Id_Questao = @pId;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectWr_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_SelectWr_Usuario](@pId int)
as
begin
	Select Id_Prontuario, Ds_Usuario, Ds_Senha, Nm_Usuario, St_Usuario 
	from TB_usuario
	where St_Usuario = 1 and Id_Prontuario = @pId
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Alternativas]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Alternativas](@pId_Alternativas int, 
									@pDs_Alternativa varchar(500),
									@pSt_Verificacao int)
as
begin
	Update TB_Alternativas
	set Ds_Alternativa = @pDs_Alternativa, St_Verificacao = @pSt_Verificacao
	where Id_Alternativas = @pId_Alternativas
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Curso]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Curso](@pId_Curso int, 
							  @pNm_Curso varchar(150),
							  @pAbrev_Nm_Curso varchar(10))
as
begin
	Update TB_Curso
	set Nm_Curso = @pNm_Curso, Abrev_Nm_Curso = @pAbrev_Nm_Curso
	where @pId_Curso = Id_Curso
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Materia]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Materia](@pId_Materia int, 
								@pNm_Materia varchar(150), 
								@pAbrev_Nm_Materia varchar(10),
								@pId_Curso int)
as
begin
	Update TB_Materia
	set Nm_Materia = @pNm_Materia, Abrev_Nm_Materia = @pAbrev_Nm_Materia, Id_Curso = @pId_Curso
	where @pId_Materia = Id_Materia
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Prova](@pId_Prova int, 
							  @pNm_Prova varchar(150),
							  @pSt_Prova int)
as
begin
	Update TB_Prova
	set Nm_Prova = @pNm_Prova, St_Prova = @pSt_Prova
	where @pId_Prova = Id_Prova
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Questao]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Questao](@pId_Questao int,
								@pDs_Pergunta varchar(500), 
								@pDs_Justificativa varchar(500), 
								@pId_Prontuario int,
								@pId_Materia int,
								@pSt_Pergunta int)
as
begin
	Update TB_Questao
	set Ds_Pergunta = @pDs_Pergunta, 
		Ds_Justificativa = @pDs_Justificativa, 
		Id_Materia = @pId_Materia,
		St_Pergunta = @pSt_Pergunta
	where @pId_Questao = Id_Questao
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Questao_Prova]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Questao_Prova](@pId_Prova int, 
									  @pId_Questao int)
as	
begin
	Update TB_QuestaoProva
	set Id_Questao = @pId_Questao
	where @pId_Prova = Id_Prova
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Turma]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Turma](@pId_Turma int, @pDs_Periodo varchar(10), @pIdCurso int)
as
begin
	Update TB_Turma
	set Ds_Periodo = @pDs_Periodo, Id_Curso = @pIdCurso
	where @pId_Turma = Id_Turma
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Upd_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Upd_Usuario](@pId_Prontuario int, @pDs_Usuario varchar(15), @pDs_Senha varchar(10), @pNm_Usuario varchar(150), @pSt_Usuario int)
as
begin
	update TB_Usuario
	set Nm_Usuario = @pNm_Usuario, Ds_Usuario = @pDs_Usuario, Ds_Senha = @pDs_Senha,St_Usuario = @pSt_Usuario
	where @pId_Prontuario = Id_Prontuario
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Vizualizar_Usuario]    Script Date: 11/9/2019 11:42:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_Vizualizar_Usuario](@pDs_Usuario varchar(10),
									   @pDs_Senha varchar(10))
as
begin
	select * from TB_Usuario where Ds_Usuario = @pDs_Usuario and Ds_Senha = @pDs_Senha;
end;
GO
USE [master]
GO
ALTER DATABASE [tind4s] SET  READ_WRITE 
GO
