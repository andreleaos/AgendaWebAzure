
create database clientedb;

use clientedb;

CREATE TABLE clientes(
    id INT AUTO_INCREMENT PRIMARY KEY,
	nome varchar(100),
	email varchar(100),
	fone varchar(100),
    dataCriacao DATE
) ENGINE=INNODB;


insert into clientes (nome, email, fone, dataCriacao) values ('Andre Silva','andre.silva@gmail.com','11 2356-9865',now());
insert into clientes (nome, email, fone, dataCriacao) values ('Sueli Marques','sueli.marques@gmail.com','11 2356-9865',now());
insert into clientes (nome, email, fone, dataCriacao) values ('Jose Antonio','jose.ja@gmail.com','11 2356-9865',now());
insert into clientes (nome, email, fone, dataCriacao) values ('Pedro Zulu','pedro.zulu@gmail.com','11 2356-9865',now());
insert into clientes (nome, email, fone, dataCriacao) values ('Marcia Sabia','marcia.sabia@gmail.com','11 2356-9865',now());

select id, nome, email, fone from clientes;


