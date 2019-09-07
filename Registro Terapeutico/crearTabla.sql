
use HogarAncianos;
go
create table Usuario(
codigo_usu int IDENTITY(1,1) primary key,
nombre_usu varchar(50),
apellido_usu varchar(50),
user_usu varchar(50),
password_usu varchar(50)
);
create table Paciente(
codigo_pac int IDENTITY(1,1) primary key,
nombre_pac varchar(50),
apellido_pac varchar(50),
cedula_pac varchar(50),
fecha_nacimiento_pac date,
fecha_registro_pac date,
antecedentes_pac char(200),
dolor_pac int,
marcha_pac varchar(50),
muscular_pac varchar(50),
neurologica_pac varchar(50),
articular_pac varchar(200),
discapacidad_pac varchar(50),
impresion_diagnostica_pac varchar(200)
);
create table Preferencia (
codigo_pre int IDENTITY(1,1) primary key,
nombre_pre varchar(10),
rutaVideo_pre varchar(200),
codigo_pac int FOREIGN KEY REFERENCES Paciente(codigo_pac)
);

create table Tipo_Terapia(
codigo_tip int IDENTITY(1,1) primary key,
nombre_tip varchar(50)
);

create table Terapia(
codigo_ter int IDENTITY(1,1) primary key,
nombre_ter varchar(50),
codigo_tip int FOREIGN KEY REFERENCES Tipo_Terapia(codigo_tip)
);

create table Registro_Terapeutico(
codigo_reg int IDENTITY(1,1) primary key,
fecha_reg date,
repeticiones_reg int,
observaciones_reg varchar(100),
codigo_pac int FOREIGN KEY REFERENCES Paciente(codigo_pac),
codigo_usu int FOREIGN KEY REFERENCES Usuario(codigo_usu),
codigo_ter int FOREIGN KEY REFERENCES Terapia(codigo_ter)
);