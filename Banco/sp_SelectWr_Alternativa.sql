use tind4s;
drop procedure if exists sp_SelectWr_Alternativa;
go
Create procedure sp_SelectWr_Alternativa(@pId int)
as
begin
	Select Id_Alternativas, Ds_Alternativa, St_Verificacao
	from TB_Alternativas
	where Id_Alternativas = @pId;
end;