use master;
create database Empleados;
GO
use Empleados;
GO
create table Departamentos (
	idDepartamento int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ubicacion varchar(150)
);
create table Empleados (
	idEmpleado int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(150),
	salario money,
	direccion varchar(200),
	idDepartamento int
);
insert into Departamentos (ubicacion) values ('San Salvador');
insert into Departamentos (ubicacion) values ('Santa Ana');
insert into Departamentos (ubicacion) values ('San Miguel');
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Mario',1100,'San Salvador',1);
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Luis',2000,'San Marcos',1);
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Rafael',1800,'Barrios',3);
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Alberto',1400,'Calvario',2);
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Carlos',9000,'Soyapango',1);
insert into Empleados(nombre,salario,direccion,idDepartamento) values ('Alex',8500,'Calvario',2);