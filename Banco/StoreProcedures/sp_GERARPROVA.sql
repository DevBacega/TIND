use tind4s;
drop procedure if exists sp_GERARPROVA;
go
Create procedure sp_GERARPROVA(@pId_Prova int)
as
begin
	/*Select Q.Ds_Pergunta
	from TB_Questao as Q
	inner join TB_QuestaoProva QP on(QP.Id_Questao = Q.Id_Questao)
	where Q.Id_Questao = @pId_Questao and QP.Id_Prova = @pId_Prova
	union all */

	Select A.Ds_Alternativa, Q.Ds_Pergunta, U.Nm_Usuario, M.Nm_Materia
	from TB_Alternativas as A
	inner join TB_Questao as Q on(Q.Id_Questao = A.Id_Questao)
	inner join TB_QuestaoProva QP on(QP.Id_Questao = Q.Id_Questao)
	inner join TB_Usuario U on(U.Id_Prontuario = Q.Id_Prontuario)
	inner join TB_Materia M on(M.Id_Materia = Q.Id_Materia)
	where QP.Id_Prova = 1
end;














