if exists (select 1 from sys.procedures where name = 'SpUsuariosIns')
drop proc SpUsuariosIns
go

create proc SpUsuariosIns
(
	@pIdUsuario int, 
	@pNick varchar(20), 
	@pPass varchar(20)
)
as
begin
 select @pIdUsuario=ISNULL(max(IdUsuario),0)+1
	from Usuarios

	insert into Usuarios
	(
		IdUsuario, 
		Nick, 
		Pass
	)
	values
	(
		@pIdUsuario, 
		@pNick, 
		@pPass
	)

end
