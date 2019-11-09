use tind4s;
drop procedure if exists sp_Criar_Tb;
go
Create Procedure sp_Criar_Tb as
go
begin
	drop table if exists TB_QuestaoProva, TB_Prova, TB_Alternativas, TB_Questao, TB_Turma, TB_Materia, TB_Curso, TB_Usuario
	--Criando Tabela do Usuario
	CREATE TABLE TB_Usuario (
		Id_Prontuario Int PRIMARY KEY identity(1,1),
		Ds_Usuario varchar(10) not null,
		Ds_Senha varchar(10) not null,
		Nm_Usuario Varchar(150) not null,
		St_Usuario int not null
	)
	--Criado a Tabela Curso
	CREATE TABLE TB_Curso (
		Id_Curso Int PRIMARY KEY identity(1,1),
		Nm_Curso Varchar(150),
		Abrev_Nm_Curso Varchar(10)
	)
	--Criando a Tabela Materia
	CREATE TABLE TB_Materia (
		Id_Materia Int PRIMARY KEY identity(1,1),
		Nm_Materia Varchar(150),
		Abrev_Nm_Materia Varchar(10),
		Id_Curso Int,
		FOREIGN KEY(Id_Curso) REFERENCES TB_Curso (Id_Curso)
	)
	--Criando Tabela das Turma
	/*CREATE TABLE TB_Turma (
	Id_Turma Int PRIMARY KEY identity(2019,1),
	Ds_Periodo Varchar(10),
	Id_Curso Int,
	FOREIGN KEY(Id_Curso) REFERENCES TB_Curso (Id_Curso)
	)*/
	--Criando a Tabela de Questão
	CREATE TABLE TB_Questao (
		Id_Questao Int PRIMARY KEY identity(1,1),
		Ds_Pergunta Varchar(500),
		St_Pergunta int,
		Ds_Justificativa Varchar(500),
		Id_Prontuario Int,
		Id_Materia Int,
		FOREIGN KEY(Id_Prontuario) REFERENCES TB_Usuario (Id_Prontuario),
		FOREIGN KEY(Id_Materia) REFERENCES TB_Materia (Id_Materia)
	)
	--Criando Tabela de Alternativas das Questões
	CREATE TABLE TB_Alternativas (
		Id_Alternativas Int identity(1,1),
		Ds_Alternativa Varchar(500),
		St_Verificacao int,
		Id_Questao Int,
		PRIMARY KEY(Id_Alternativas,Id_Questao),
		FOREIGN KEY(Id_Questao) REFERENCES TB_Questao (Id_Questao)
	)
	--Criando a Tabela de Provas
	CREATE TABLE TB_Prova (
		Id_Prova Int PRIMARY KEY identity(1,1),
		Nm_Prova Varchar(150),
		St_Prova int,
		Id_Prontuario Int,
		--Id_Turma Int,
		--FOREIGN KEY(Id_Turma) REFERENCES TB_Turma (Id_Turma),
		FOREIGN KEY(Id_Prontuario) REFERENCES TB_Usuario (Id_Prontuario)
	)
	--Criando A Tabela de Respostas da Prova
	CREATE TABLE TB_QuestaoProva (
		Id_Questao Int,
		Id_Prova Int,
		PRIMARY KEY(Id_Questao,Id_Prova),
		FOREIGN KEY(Id_Questao) REFERENCES TB_Questao (Id_Questao),
		FOREIGN KEY(Id_Prova) REFERENCES TB_Prova (Id_Prova)
	)
end;