create database petshop

create table tipo_animal (
	id int not null,
	descricao varchar(55) not null,
	primary key (id)
);

create table tipo_produto (
	id int not null,
	descricao varchar(55) not null,
	primary key (id)
);

create table clientes (
	id int not null AUTO_INCREMENT,
	email varchar(255) not null,
	nome varchar (255) not null,
	senha varchar (40) not null,
	primary key (id)
);

create table produtos (
	id int not null AUTO_INCREMENT,
	tipo int not null,
	descricao varchar (255),
	valor varchar (255) not null,
	tipo_animal int not null,
	primary key (id),
	foreign key (tipo) references tipo_produto(id),
	foreign key (tipo_animal) references tipo_animal(id)
);

create table vendas (
	id int not null AUTO_INCREMENT,
	id_cliente int not null,
	id_produto int not null,
	valor_total varchar(255) not null,
	primary key (id),
	foreign key (id_cliente) references clientes(id),
	foreign key (id_produto) references produtos(id)
);

insert into table tipo_animal values (1, 'gato');
insert into table tipo_animal values (2, 'cachorro');

insert into table tipo_produto values (1, 'ração');
insert into table tipo_produto values (2, 'brinquedo');