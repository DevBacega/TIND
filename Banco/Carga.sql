use tind4s;
exec sp_Ins_Usuario 'felipe', 'admin', 'admin123', 1;
exec sp_Ins_Usuario 'victor', 'admin1', 'admin123', 1;
exec sp_Ins_Usuario 'Joao', 'Prof1', 'Prof1', 2;

exec sp_Ins_Curso 'Analise e Desenvolvimento de Sistemas','ADS';
exec sp_Ins_Curso 'Processos Quimicos', 'PQ';

exec sp_Ins_Materia 1,'Estrutura de Dados','ES';
exec sp_Ins_Materia 1,'Redes','RD';
exec sp_Ins_Materia 2,'Quimica Geral','QG';
exec sp_Ins_Materia 2,'Quimica 1','Q1';


exec sp_Ins_Questao 'O que seria uma fun��o recursiva?', 'Se chama recursiva pois ela mesma se chama criando um ciclo de repeti��o',1,3,1;
exec sp_Ins_Questao 'Fale uma fun��o recursiva famosa?', 'Fibonassi',1,3,1;
exec sp_Ins_Questao 'O que � uma Rede WAN?', 'Pois seu significado � "World Area NetWork', 2,3,1;
exec sp_Ins_Questao 'O que � HTTPS?', 'HTTPS - SECURITY', 2,3,1;

exec sp_Ins_Questao 'O primeiro modelo cient�fico para o �tomo foi proposto por Dalton em 1808. Este modelo foi comparado a?','Por causa de seu formato',3,3,1;
exec sp_Ins_Questao 'Qual elemento qu�mico dos alistados abaixo possui propriedades semelhantes �s do oxig�nio (O)?','pois o oxig�nio e o enxofre pertencem � mesma fam�lia na Tabela Peri�dica, que � a 16 (ou 6A), a fam�lia dos calcog�nios.',3,3,1


exec sp_Ins_Alternativas 'Uma fun��o de uma chamada',0,1;
exec sp_Ins_Alternativas 'Uma fun��o de duas chamada',0,1;
exec sp_Ins_Alternativas 'Uma fun��o Redonda',0,1;
exec sp_Ins_Alternativas 'Uma fun��o Curvada',0,1;
exec sp_Ins_Alternativas 'Uma fun��o que chama ela mesma',1,1;
				   
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

exec sp_Ins_Alternativas 'Uma bola de t�nis',0,5;
exec sp_Ins_Alternativas 'Uma bola de futebol',0,5;
exec sp_Ins_Alternativas 'Uma bola de pingue-pongue',0,5;
exec sp_Ins_Alternativas 'Uma bola de bilhar',1,5;
exec sp_Ins_Alternativas 'Uma bexiga cheia de ar.',0,5;

exec sp_Ins_Alternativas 'Nitrog�nio (N)',0,6
exec sp_Ins_Alternativas 'Hidrog�nio (H)',0,6
exec sp_Ins_Alternativas 'Enxofre (S)',1,6 
exec sp_Ins_Alternativas 'Fl�or (F)',0,6 
exec sp_Ins_Alternativas 'Carbono (C)',0,6