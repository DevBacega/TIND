use tind4s;
drop procedure if exists sp_Ins_Usuario;
go
Create procedure sp_Ins_Usuario(@pNm_Usuario Varchar(150),
								@pDs_Usuario varchar(10),
								@pDs_Senha varchar(10),
								@pSt_Usuario int)
as
begin
	Insert into TB_Usuario(Nm_Usuario, Ds_Usuario, Ds_Senha, St_Usuario) values(@pNm_Usuario, @pDs_Usuario, @pDs_Senha, @pSt_Usuario);
end;