use tind4s;
drop procedure if exists sp_SelectWr_Materia;
go
Create procedure sp_SelectWr_Materia(@pId int)
as
begin
	Select Id_Materia, Nm_Materia, Abrev_Nm_Materia, Id_Curso
	from TB_Materia
	where Id_Materia = @pId;
end;