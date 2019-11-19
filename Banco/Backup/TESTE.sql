use tind4s;
exec sp_Ins_Usuario 'felipe', 'admin', 'admin123', '1';
exec sp_Criar_Tb;
exec sp_Vizualizar_Usuario 'admin', 'admin123';

select * from TB_Usuario