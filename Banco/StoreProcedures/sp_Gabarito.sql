Create procedure Sp_Gabarito( @pIdProva int)
As
Begin
SELECT Q.Ds_Pergunta, A.Ds_Alternativa, Q.Ds_Justificativa
FROM TB_PROVA P 
INNER JOIN TB_QUESTAOPROVA QP ON P.Id_Prova = QP.Id_Prova
INNER JOIN TB_Questao Q		  ON Q.Id_Questao = QP.Id_Questao
INNER JOIN TB_Alternativas A  ON QP.Id_Questao = A.Id_Questao
WHERE A.St_Verificacao = 1 and P.Id_Prova = @pIdProva
End;