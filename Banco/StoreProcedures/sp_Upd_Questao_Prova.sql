use tind4s;
drop procedure if exists sp_Upd_Questao_Prova;
go
Create procedure sp_Upd_Questao_Prova(@pId_Prova int, 
									  @pId_Questao int)
as	
begin
	Update TB_QuestaoProva
	set Id_Questao = @pId_Questao
	where @pId_Prova = Id_Prova
end;