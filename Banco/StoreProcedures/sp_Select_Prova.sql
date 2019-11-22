use tind4s;
drop procedure if exists sp_Select_Prova;
go
Create procedure sp_Select_Prova
as
begin
	Select P.Id_Prova as 'ID', P.Nm_Prova as 'Titulo da Prova', P.St_Prova as 'Status', P.Id_Prontuario as 'Prontuario', U.Nm_Usuario as 'Professor'
	from TB_Prova P
	INNER JOIN TB_Usuario U ON P.Id_Prontuario = U.Id_Prontuario where St_Prova = 1;
end;

