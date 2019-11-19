use tind4s;
drop procedure if exists sp_SelectWr_Usuario;
go
Create procedure sp_SelectWr_Usuario(@pId int)
as
begin
	Select Id_Prontuario, Ds_Usuario, Ds_Senha, Nm_Usuario, St_Usuario 
	from TB_usuario
	where St_Usuario = 1 and Id_Prontuario = @pId
end;