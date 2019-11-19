use tind4s;
drop procedure if exists sp_Ins_Curso;
go
Create procedure sp_Ins_Curso(@pNm_Curso varchar(150),
							  @pAbrev_Nm_Curso varchar(10)) as
begin
	insert into TB_Curso(Nm_Curso, Abrev_Nm_Curso) values(@pNm_Curso, @pAbrev_Nm_Curso);
end;