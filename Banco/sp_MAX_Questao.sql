use tind4s;
drop procedure if exists sp_MAX_Questao;
go
Create procedure sp_MAX_Questao
as
begin
    SELECT MAX(Id_Questao) AS IDNOVO
	from TB_Questao
end;