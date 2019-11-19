use tind4s;
drop procedure if exists sp_Select_Curso;
go
Create procedure sp_Select_Curso
as
begin
	Select Id_Curso, Nm_Curso, Abrev_Nm_Curso
	from TB_Curso
end;