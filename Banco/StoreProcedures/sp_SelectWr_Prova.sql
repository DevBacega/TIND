use tind4s;
drop procedure if exists sp_SelectWr_Prova;
go
Create procedure sp_SelectWr_Prova(@pId int)
as
begin
	Select Id_Prova, Nm_Prova, St_Prova, Id_Prontuario
	from TB_Prova
	where Id_Prova = @pId
end;