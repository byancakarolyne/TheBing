use bing;

create table dbo.transportadora (
id_transportadora int not null IDENTITY(1,1), 
nm_transportadora varchar(100) not null,
ds_transportadora varchar(500),
telefone varchar(25),
PRIMARY KEY (id_transportadora)
);

create table dbo.empresa (
id_empresa int not null IDENTITY(1,1),
cnpj char(14), 
nome_empresa varchar(200),
primary Key(id_empresa)
);

create table dbo.tipocarga (
id_tipo int not null identity(1,1),
nome_tipo varchar(150),
PRIMARY KEY(id_tipo)
);

create table dbo.status (
id_status int not null IDENTITY(1,1), 
status varchar(100) not null,
PRIMARY KEY (id_status)
);

create table dbo.carga (
id_carga int not null IDENTITY(1,1),
nome_carga varchar(100),
descricao_carga varchar(750),
origem varchar(100),
destino varchar(100),
flag_carga bit,
id_empresa int FOREIGN KEY REFERENCES dbo.empresa(id_empresa),
PRIMARY KEY (id_carga)
);


create table dbo.carga_status (
id_carga_status int not null IDENTITY(1,1),
id_carga int FOREIGN KEY REFERENCES dbo.carga(id_carga),
id_status int foreign key REFERENCES dbo.status(id_status),
horario datetime,
PRIMARY KEY (id_carga_status)
);
