Create table Perfiles
(
  IdPerfil int not null,
  NombrePerfil Varchar (30) not null,
  Constraint PK_Perfiles primary key(IdPerfil),
)
 insert into Perfiles(IdPerfil,NombrePerfil)
 Values(1,'Administrador')
 insert into Perfiles(IdPerfil,NombrePerfil)
 Values(2,'Medico')
 

Create table Usuarios
(
 IdUsuario int not null ,
 IdPerfil int not null,
 Nick Varchar(20) not null,
 Pass Varchar(20) not null,
 Constraint PK_Usuarios primary key(IdUsuario),
constraint FK_Usuarios_Perfiles foreign key (IdPerfil) references Perfiles(IdPerfil),
)

Create table Opciones
(
IdOpcion int not null,
NombreOpcion Varchar(50) not null
 Constraint PK_Opciones primary key(IdOpcion),
)
 insert into Opciones(IdOpcion,NombreOpcion)
 Values(1,'Empleados')
  insert into Opciones(IdOpcion,NombreOpcion)
 Values(2,'Consultas')
  insert into Opciones(IdOpcion,NombreOpcion)
 Values(3,'Usuarios')
  insert into Opciones(IdOpcion,NombreOpcion)
 Values(4,'Agenda')
  insert into Opciones(IdOpcion,NombreOpcion)
 Values(5,'Pacientes')
  insert into Opciones(IdOpcion,NombreOpcion)
 Values(6,'Reportes')



Create table OpcionesPerfiles
(
IdOpcion int not null,
IdPerfil int not null,
Acceso bit not null,
constraint FK_OpcionesPerfiles_Opciones foreign key (IdOpcion) references Opciones(IdOpcion),
constraint FK_OpcionesPerfiles_Perfiles foreign key (IdPerfil) references Perfiles(IdPerfil)
)
----Admin
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(1,1,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(2,1,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(3,1,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(4,1,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(5,1,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(6,1,1)
 
 ----Usuario Medico
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(1,2,0)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(2,2,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(3,2,0)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(4,2,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(5,2,1)
 insert into OpcionesPerfiles(IdOpcion,IdPerfil,Acceso)
 Values(6,2,0)
 
 
 select * From OpcionesPerfiles