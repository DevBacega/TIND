use tind4s;
drop procedure if exists sp_Upd_Alternativas
go
Create procedure sp_Upd_Alternativas(@pId_Alternativas int, 
									@pDs_Alternativa varchar(500),
									@pSt_Verificacao int,
									@pId_Questao int)
as
begin
	Update TB_Alternativas
	set Ds_Alternativa = @pDs_Alternativa, St_Verificacao = @pSt_Verificacao
	where Id_Alternativas = @pId_Alternativas
end;