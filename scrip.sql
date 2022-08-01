use master
go

if(exists(Select * from sys.databases where name = 'ExemploSnai'))
   drop  database ExemploSenai
go



create database ExemploSenai
go

use ExemploSenai
go

create table Usuario(
ID int identity primary key,
Nome Varchar(200) not null,
Senha Varchar(1000) not null,
);
go

create table Post(
ID int identity primary key,
Publicante int references Usuario(ID),
Conteudo varchar(MAX) not null,
);
go