use bing;

insert into dbo.carga_status (id_carga,id_status,horario) 
values (1,1,'2022-06-01 10:34:09 AM'),
 (1,2,'2022-06-05 09:34:09 AM'),
 (1,3,'2022-06-09 11:34:09 AM'),
 (1,4,'2022-06-13 11:45:09 AM'),
 (1,5,'2022-06-17 10:35:09 AM'),
 (1,6,'2022-06-21 10:20:09 AM'),
 (1,7,'2022-06-25 09:34:09 AM'),
 (1,8,'2022-06-29 10:34:09 AM'),
 (1,9,'2022-07-03 09:32:09 AM'),
 (1,10,'2022-07-07 10:23:09 AM'),
 (2,1,'2022-07-09 10:34:09 AM'),
(2,2,'2022-07-13 09:34:09 AM'),
(2,3,'2022-07-17 08:44:09 AM'),
(2,4,'2022-07-21 10:47:09 AM'),
(2,5,'2022-07-25 09:34:09 AM'),
(2,11,'2022-07-29 10:34:09 AM');

insert into dbo.tipocarga (nome_tipo) 
values ('Carga geral'),
('Carga refrigerada');

insert into dbo.transportadora (nm_transportadora, ds_transportadora, telefone) 
values ('Bandeirantes','01/08/2022 - 10:45','Tel.: (0XX13) 3202-4353'),
('Gelog','01/08/2022 - 15:00','(13) 3295-5770'),
('BRTranslog','02/08/2022 - 09:00','(13) 3224-3303 opção 5');

insert into dbo.empresa (cnpj, nome_empresa) 
values ('01234567890123','Bing Importações');

insert into dbo.carga (nome_carga,descricao_carga,origem,destino,flag_carga,id_empresa) 
values ('Televisão','NCM: 8525502','China','Brasil',null,1),
 ('Fruta','NCM: 20060000','Inglaterra','Brasil',null,1);
