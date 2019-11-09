use tind4s;
drop procedure if exists sp_Upd_Materia
go
Create procedure sp_Upd_Materia(@pId_Materia int, 
								@pNm_Materia varchar(150), 
								@pAbrev_Nm_Materia varchar(10),
								@pId_Curso int)
as
begin
	Update TB_Materia
	set Nm_Materia = @pNm_Materia, Abrev_Nm_Materia = @pAbrev_Nm_Materia, Id_Curso = @pId_Curso
	where @pId_Materia = Id_Materia
end;