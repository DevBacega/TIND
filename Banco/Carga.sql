use tind4s;
exec sp_Ins_Usuario 'felipe', 'admin', 'admin123', 1;
exec sp_Ins_Usuario 'victor', 'admin1', 'admin123', 1;
exec sp_Ins_Usuario 'Joao', 'Prof1', 'Prof1', 2;

exec sp_Ins_Curso 'Analise e Desenvolvimento de Sistemas','ADS';
exec sp_Ins_Curso 'Processos Quimicos', 'PQ';

exec sp_Ins_Materia 1,'Estrutura de Dados','ES';
exec sp_Ins_Materia 1,'Redes','RD';
exec sp_Ins_Materia 2,'Analise Quimica','AQ';
exec sp_Ins_Materia 2,'Quimica 1','Q1';


exec sp_Ins_Questao 'O que seria uma função recursiva?', 'Se chama recursiva pois ela mesma se chama criando um ciclo de repetição',1,3,1;
exec sp_Ins_Questao 'Fale uma função recursiva famosa?', 'Fibonassi',1,3,1;
exec sp_Ins_Questao 'O que é uma Rede WAN?', 'Pois seu significado é "World Area NetWork', 2,3,1;
exec sp_Ins_Questao 'O que é HTTPS?', 'HTTPS - SECURITY', 2,3,1;


exec sp_Ins_Alternativas 'Uma função de uma chamada',0,1;
exec sp_Ins_Alternativas 'Uma função de duas chamada',0,1;
exec sp_Ins_Alternativas 'Uma função Redonda',0,1;
exec sp_Ins_Alternativas 'Uma função Curvada',0,1;
exec sp_Ins_Alternativas 'Uma função que chama ela mesma',1,1;
				   
exec sp_Ins_Alternativas 'Fibonissi',0,2;
exec sp_Ins_Alternativas 'Fibonassi',1,2;
exec sp_Ins_Alternativas 'Fibonossi',0,2;
exec sp_Ins_Alternativas 'Fibonussi',0,2;
exec sp_Ins_Alternativas 'Fibonasso',0,2;
				   
exec sp_Ins_Alternativas 'World Area NetWork',1,3;
exec sp_Ins_Alternativas 'Wide Area NetWork',0,3;
exec sp_Ins_Alternativas 'World Alter NetWork',0,3;
exec sp_Ins_Alternativas 'World Area Net',0,3;
exec sp_Ins_Alternativas 'Wird Area NetWork',0,3;

exec sp_Ins_Alternativas 'Hyper Text Transfer Protocol Secure',1,4;
exec sp_Ins_Alternativas 'Homing Text Transfer Protocol Secure',0,4;
exec sp_Ins_Alternativas 'Hercu Text Transfer Protocol Secure',0,4;
exec sp_Ins_Alternativas 'Hinner Text Transfer Protocol Secure',0,4;
exec sp_Ins_Alternativas 'Hiper Text Transfer Protocol Secure',0,4;








select * from TB_Usuario