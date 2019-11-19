use tind4s;
drop procedure if exists sp_SelectWr_Questao;
go
Create procedure sp_SelectWr_Questao(@pId int)
as
begin
	Select Id_Questao, Ds_Pergunta, Ds_Justificativa, U.Nm_Usuario, M.Nm_Materia, St_Pergunta 
	from TB_Questao as Q
	inner join TB_Usuario as U on(Q.Id_Prontuario = U.Id_Prontuario)
	inner join TB_Materia as M on(Q.Id_Materia = M.Id_Materia)
	where St_Pergunta = 1 and Id_Questao = @pId;
end;
