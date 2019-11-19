use tind4s;
drop procedure if exists sp_Upd_Prova;
go
Create procedure sp_Upd_Prova(@pId_Prova int, 
							  @pNm_Prova varchar(150),
							  @pSt_Prova int)
as
begin
	Update TB_Prova
	set Nm_Prova = @pNm_Prova, St_Prova = @pSt_Prova
	where @pId_Prova = Id_Prova
end;