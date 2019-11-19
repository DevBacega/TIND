use tind4s;
drop procedure if exists sp_Inativo_Usuario;
go
Create procedure sp_Inativo_Usuario(@pId_Usuario int)
as
begin
	Declare @Status TINYINT;
	Set @Status = (Select St_Usuario from TB_Usuario where Id_Prontuario = @pId_Usuario)

	IF @Status = 1
		Update TB_Usuario Set St_Usuario = 0 Where Id_Prontuario = @pId_Usuario
	ELSE 
		Update TB_Usuario Set St_Usuario = 1 Where Id_Prontuario = @pId_Usuario
end;


















