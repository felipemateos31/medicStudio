If Exists(Select 1 from sys.procedures where name='SpAgendaUpd')
drop proc SpAgendaUpd
go
Create proc SpAgendaUpd
(
		@pIdContacto	int out,
		@pNombre	varchar (20),
		@pApPaterno	varchar	(20),
		@pApMaterno	varchar	(20),
		@pTelefeno1	varchar	(10),
		@pTelefeno2	varchar	(10),
		@pEmail	    varchar	(50),
		@pDireccion	varchar	(50)
)
as
begin
update Agenda	
	set
		Nombre=@pNombre,
		ApPaterno=@pApPaterno,
		ApMaterno=@pApMaterno,
		Telefeno1=@pTelefeno1,
		Telefeno2=@pTelefeno2,
		Email=@pEmail,
		Direccion=@pDireccion
	where IdContacto=@pIdContacto
end






  
