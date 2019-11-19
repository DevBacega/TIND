use tind4s;
drop procedure if exists sp_Vizualizar_Usuario;
go
Create procedure sp_Vizualizar_Usuario(@pDs_Usuario varchar(10),
									   @pDs_Senha varchar(10))
as
begin
	select * from TB_Usuario where Ds_Usuario = @pDs_Usuario and Ds_Senha = @pDs_Senha;
end;