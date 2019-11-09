use tind4s;
drop procedure if exists sp_Select_Questao;
go
Create procedure sp_Select_Questao
as
begin
	Select Id_Questao, Ds_Pergunta, Ds_Justificativa, Id_Prontuario, Id_Materia, St_Pergunta 
	from TB_Questao
	where St_Pergunta = 1;
end;
