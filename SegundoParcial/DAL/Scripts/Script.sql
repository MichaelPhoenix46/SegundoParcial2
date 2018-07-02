create database VehiculosDb
go
use VehiculosDb
go
create table Vehiculos
(
	VehiculoId int primary key identity(1,1),
	Descripcion varchar(max),
	Mantenimiento int
);

go
insert into Vehiculos(Descripcion)
values ('Toyota Corolla 2005 Le');
go
insert into Vehiculos(Descripcion)
values ('Honda CRU 2015 Touring');
go