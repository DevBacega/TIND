use tind4s;
drop procedure if exists sp_Ins_Turma;
go
Create procedure sp_Ins_Turma(@pId_Curso int,
							  @pDs_Periodo Varchar(10))
as
begin
	insert into TB_Turma(Id_Curso, Ds_Periodo) values(@pId_Curso, @pDs_Periodo);
end;