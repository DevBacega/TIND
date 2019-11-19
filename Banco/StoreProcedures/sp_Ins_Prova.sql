use tind4s;
Drop procedure if exists sp_Ins_Prova;
go
Create procedure sp_Ins_Prova(@pNm_Prova varchar(150),
							  @pSt_Prova int,
							  @pId_Prontuario int)
as
begin
	insert into TB_Prova(Nm_Prova, St_Prova, Id_Prontuario)
	values(@pNm_Prova, @pSt_Prova, @pId_Prontuario);
end;