use tind4s;
drop procedure if exists sp_SelectWr_QsProva;
go
Create procedure sp_SelectWr_QsProva(@pId int)
as
begin
	Select Id_Prova, Id_Questao
	from TB_QuestaoProva
	where Id_Prova = @pId;
end;