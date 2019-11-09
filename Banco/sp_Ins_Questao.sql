use tind4s;
Drop procedure if exists sp_Ins_Questao;
go
Create procedure sp_Ins_Questao(@pDs_Pergunta Varchar(500),
								@pDs_Resposta Varchar(500),
								@pDs_Justificativa Varchar(500),
								@pId_Materia int,
								@pId_Prontuario int,
								@pSt_Pergunta int)
as
begin
	insert into TB_Questao(Ds_Pergunta, 
						   Ds_Resposta, 
						   Ds_Justificativa, 
						   Id_Materia, 
						   Id_Prontuario, 
						   St_Pergunta) 
					values(@pDs_Pergunta, 
						   @pDs_Resposta, 
						   @pDs_Justificativa, 
						   @pId_Materia, 
						   @pId_Prontuario, 
						   @pSt_Pergunta);
end;