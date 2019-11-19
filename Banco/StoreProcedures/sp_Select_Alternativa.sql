use tind4s;
drop procedure if exists sp_Select_Alternativa;
go
Create procedure sp_Select_Alternativa
as
begin
	Select Id_Alternativas, Ds_Alternativa, St_Verificacao
	from TB_Alternativas
end;