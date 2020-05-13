If Exists(Select 1 from sys.procedures where name='SpAgendaIns')
drop proc SpAgendaIns
go
Create proc SpAgendaIns
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
	select @pIdContacto=ISNULL(max(IdContacto),0)+1
	from Agenda
	
	insert into Agenda(IdContacto,Nombre,ApPaterno,ApMaterno,Telefeno1,Telefeno2,Email,Direccion)
	Values			 (@pIdContacto,@pNombre,@pApPaterno,@pApMaterno,@pTelefeno1,@pTelefeno2,@pEmail,@pDireccion)
  
end


