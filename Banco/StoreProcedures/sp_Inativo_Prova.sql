use tind4s;
drop procedure if exists sp_Inativo_Prova;
go
Create procedure sp_Inativo_Prova(@pId int)
as
begin
	Declare @Status int;
	Set @Status = (Select St_Prova from TB_Prova where Id_Prova = @pId)

	IF @Status = 1
		Update TB_Prova Set St_Prova = 0 Where Id_Prova = @pId
	ELSE 
		Update TB_Prova Set St_Prova = 1 Where Id_Prova = @pId
end;
