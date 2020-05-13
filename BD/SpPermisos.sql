if exists (select 1 from sys.procedures where name = 'SpPermisoUsuario')
drop proc SpPermisoUsuario
go

create proc SpPermisoUsuario
(
@pIdPerfil int
)
as 
Begin 

select Op.IdOpcion,Op.IdPerfil,Op.Acceso
From OpcionesPerfiles Op
where @pIdPerfil=IdPerfil
end

