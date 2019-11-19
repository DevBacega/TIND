use tind4s;
drop procedure if exists sp_Select_Usuario;
go
Create procedure sp_Select_Usuario
as
begin
	Select Id_Prontuario, Ds_Usuario, Ds_Senha, Nm_Usuario, St_Usuario 
	from TB_usuario
	where St_Usuario = 1
end;