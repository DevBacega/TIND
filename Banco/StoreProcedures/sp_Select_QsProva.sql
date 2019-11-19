use tind4s;
drop procedure if exists sp_Select_QsProva;
go
Create procedure sp_Select_QsProva
as
begin
	Select Id_Prova, Id_Questao
	from TB_QuestaoProva
end;