use tind4s;
drop procedure if exists sp_Upd_Usuario
go
Create procedure sp_Upd_Usuario(@pId_Prontuario int, @pDs_Usuario varchar(15), @pDs_Senha varchar(10), @pNm_Usuario varchar(150), @pSt_Usuario int)
as
begin
	update TB_Usuario
	set Nm_Usuario = @pNm_Usuario, Ds_Usuario = @pDs_Usuario, Ds_Senha = @pDs_Senha,St_Usuario = @pSt_Usuario
	where @pId_Prontuario = Id_Prontuario
end;