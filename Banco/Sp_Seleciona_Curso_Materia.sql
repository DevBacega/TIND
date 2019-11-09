use tind4s;
drop procedure if exists Sp_Selecionar_Curso_Materia;
go
Create Procedure Sp_Selecionar_Curso_Materia(@pIdCurso int)
as
begin

SELECT Id_Materia, Nm_Materia FROM TB_MATERIA WHERE Id_Curso = @pIdCurso
end;
