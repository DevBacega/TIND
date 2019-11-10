use tind4s;
drop procedure if exists sp_MAX_Prova;
go
Create procedure sp_MAX_Prova
as
begin
    SELECT IDENT_CURRENT('TB_Prova') as 'ID'
end;

