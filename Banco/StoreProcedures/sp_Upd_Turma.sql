use tind4s;
drop procedure if exists sp_Upd_Turma
go
Create procedure sp_Upd_Turma(@pId_Turma int, @pDs_Periodo varchar(10), @pIdCurso int)
as
begin
	Update TB_Turma
	set Ds_Periodo = @pDs_Periodo, Id_Curso = @pIdCurso
	where @pId_Turma = Id_Turma
end;