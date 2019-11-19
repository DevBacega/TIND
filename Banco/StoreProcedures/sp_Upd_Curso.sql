use tind4s;
drop procedure if exists sp_Upd_Curso
go
Create procedure sp_Upd_Curso(@pId_Curso int, 
							  @pNm_Curso varchar(150),
							  @pAbrev_Nm_Curso varchar(10))
as
begin
	Update TB_Curso
	set Nm_Curso = @pNm_Curso, Abrev_Nm_Curso = @pAbrev_Nm_Curso
	where @pId_Curso = Id_Curso
end;
