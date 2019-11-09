use tind4s;
drop procedure if exists sp_SelectWr_Curso;
go
Create procedure sp_SelectWr_Curso(@pId int)
as
begin
	Select Id_Curso, Nm_Curso, Abrev_Nm_Curso
	from TB_Curso
	where Id_Curso = @pId;
end;