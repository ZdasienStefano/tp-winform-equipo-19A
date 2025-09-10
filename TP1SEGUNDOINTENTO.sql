GO
create database DBarchivos 
collate Latin1_General_CI_AI

go
use DBarchivos
go
   
  create table Permisos(
  IDPermiso bigint primary key not null identity (1,1),--cp
  Nombre varchar(100) not null)



go
  create table TiposUsuario(
  IDTipoUsuario smallint primary key not null identity (1,1),--cp
  TipoUsuario varchar(100) not null)
  
  

go
create table Usuarios(
IDUsuario bigint  primary key not null identity(1,1),--cp
Nombre varchar(100) not null,
Apellido varchar (100) not null,
IDTipoUsuario SMALLINT foreign key references  TiposUsuario(IDTipoUsuario)not null
)
 
 go
create table TiposArchivos(
IDTipoArchivo smallint  primary key not null identity(1, 1),--cp
TipoArchivo varchar(100) not null)



go
CREATE TABLE Archivos (
    IDArchivo bigint PRIMARY KEY NOT NULL IDENTITY(1, 1), -- cp
    IDUsuarioDueño bigint foreign key references Usuarios(IDUsuario) NOT NULL,
    Nombre varchar(100) NOT NULL,
    Extension varchar(200) NOT NULL,
    Descripcion varchar(200) NOT NULL,
    IDTipoArchivo smallint foreign key references TiposArchivos(IDTipoArchivo) NOT NULL,
    Tamano bigint NOT NULL,
    FechaCreacion datetime NOT NULL DEFAULT GETDATE(),
    FechaUltimaModificacion datetime not null default getdate(),
    Eliminado bit NOT NULL)
   
    

    






  go
   create table ArchivosCompartidos(
   IDArchivo bigint foreign key references Archivos (IDArchivo) not null,--cp
   IDUsuario bigint foreign key  references Usuarios (IDUsuario) not null,--cp
   IDPermiso bigint foreign key references Permisos(IDPermiso) not null,
   FechaCompartido datetime not null default getdate(),
   primary key (IDArchivo, IDUsuario))


   select * from TiposArchivos;
