use tind4s;
drop procedure if exists sp_Select_Gprova;
go
Create procedure sp_Select_Gprova(@pQnt int,
								  @pId_Materia int)
as
begin
	Select top (@pQnt) Id_Questao 
	from TB_Questao where Id_Materia = @pId_Materia and St_Pergunta = 1 order by NEWID()
end;