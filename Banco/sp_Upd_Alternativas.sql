use tind4s;
drop procedure if exists sp_Upd_Alternativas
go
Create procedure sp_Upd_Alternativas(@pId_Alternativas int, 
									@pDs_Alternativa varchar(500), 
									@pId_Questao int)
as
begin
	Update TB_Alternativas
	set Ds_Alternativa = @pDs_Alternativa
	where Id_Alternativas = @pId_Alternativas
end;