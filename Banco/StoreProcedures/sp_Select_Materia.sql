use tind4s;
drop procedure if exists sp_Select_Materia;
go
Create procedure sp_Select_Materia
as
begin
	Select M.Id_Materia, M.Abrev_Nm_Materia, M.Nm_Materia, M.Id_Curso, C.Nm_Curso
	from TB_Materia as M inner join TB_Curso as C ON M.Id_Curso = C.Id_Curso
end;