use tind4s;
Drop procedure if exists sp_Ins_Materia;
go
Create procedure sp_Ins_Materia(@pId_Curso			int,
								@pNm_Materia		Varchar(150),
								@pAbrev_Nm_Materia	Varchar(10))as
begin
	insert into TB_Materia(Id_Curso, Nm_Materia, Abrev_Nm_Materia) values(@pId_Curso, @pNm_Materia, @pAbrev_Nm_Materia);
end;