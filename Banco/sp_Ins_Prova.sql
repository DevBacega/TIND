use tind4s;
Drop procedure if exists sp_Ins_Prova;
go
Create procedure sp_Ins_Prova(@pNm_Prova varchar(150),
							  @pSt_Prova date,
							  @pId_Prontuario int,
							  @pId_Turma int)
as
begin
	insert into TB_Prova(Nm_Prova, St_Prova, Id_Prontuario, Id_Turma)
	values(@pNm_Prova, @pSt_Prova, @pId_Prontuario,@pId_Turma);
end;