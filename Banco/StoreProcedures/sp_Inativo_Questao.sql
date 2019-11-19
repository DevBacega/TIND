use tind4s;
drop procedure if exists sp_Inativo_Questao;
go
Create procedure sp_Inativo_Questao(@pId int)
as
begin
	Declare @Status TINYINT;
	Set @Status = (Select St_Pergunta from TB_Questao where Id_Questao = @pId)

	IF @Status = 1
		Update TB_Questao Set St_Pergunta = 0 Where Id_Questao = @pId
	ELSE 
		Update TB_Questao Set St_Pergunta = 1 Where Id_Questao = @pId
end;

