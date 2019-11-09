use tind4s;
drop procedure if exists sp_Select_Materia;
go
Create procedure sp_Select_Materia
as
begin
	Select Id_Materia, Nm_Materia, Abrev_Nm_Materia, Id_Curso
	from TB_Materia
end;