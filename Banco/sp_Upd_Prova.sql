use tind4s;
drop procedure if exists sp_Upd_Prova;
go
Create procedure sp_Upd_Prova(@pId_Prova int, 
							  @pNm_Prova varchar(150),
							  @pId_Turma int,
							  @pSt_Prova date)
as
begin
	Update TB_Prova
	set Nm_Prova = @pNm_Prova, Id_Turma = @pId_Turma, St_Prova = @pSt_Prova
	where @pId_Prova = Id_Prova
end;