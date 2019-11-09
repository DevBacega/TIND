drop procedure if exists sp_Grid_Usuario;
go
Create procedure sp_Grid_Usuario
as
begin
	select U.Id_Prontuario As Prontuario, U.Nm_Usuario As Nome
	from TB_Usuario as U
end;

