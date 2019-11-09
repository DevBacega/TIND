use tind4s;
drop procedure if exists sp_Upd_Questao
go
Create procedure sp_Upd_Questao(@pId_Questao int,
								@pDs_Pergunta varchar(500), 
								@pDs_Justificativa varchar(500), 
								@pId_Prontuario int,
								@pId_Materia int,
								@pSt_Pergunta int)
as
begin
	Update TB_Questao
	set Ds_Pergunta = @pDs_Pergunta, 
		Ds_Justificativa = @pDs_Justificativa, 
		Id_Materia = @pId_Materia,
		St_Pergunta = @pSt_Pergunta
	where @pId_Questao = Id_Questao
end;