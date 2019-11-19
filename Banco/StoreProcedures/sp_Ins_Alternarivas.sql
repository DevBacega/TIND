use tind4s;
Drop procedure if exists sp_Ins_Alternarivas;
go
Create procedure sp_Ins_Alternarivas(@pDs_Alternativa Varchar(500),
									 @pVerificacao int,
									 @pId_Questao int)
as
begin
	insert into TB_Alternativas(Ds_Alternativa, St_Verificacao, Id_Questao) values(@pDs_Alternativa, @pVerificacao,@pId_Questao);
end;