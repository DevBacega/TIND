use tind4s;
drop procedure if exists sp_Select_Prova;
go
Create procedure sp_Select_Prova
as
begin
	Select Id_Prova, Nm_Prova, St_Prova, Id_Prontuario
	from TB_Prova
end;