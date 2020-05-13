if exists (select 1 from sys.procedures where name = 'SpUsuariosUpd')
drop proc SpUsuariosUpd
go

create proc SpUsuariosUpd
(
	@pIdUsuario int, 
	@pIdPerfil int, 
	@pNick varchar(20), 
	@pPass varchar(20)
)
as
begin

	update Usuarios
	set
		IdPerfil = @pIdPerfil, 
		Nick = @pNick, 
		Pass = @pPass
	where 	IdUsuario = @pIdUsuario

end