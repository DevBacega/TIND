use tind4s;
drop procedure if exists sp_Ins_Questao_Prova;
go
Create procedure sp_Ins_Questao_Prova(@pId_Prova int, @pId_Questao int)
as
begin
	insert into TB_QuestaoProva(Id_Prova, Id_Questao)values(@pId_Prova, @pId_Questao);
end;