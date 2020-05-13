If Exists(Select 1 from sys.procedures where name='SpMedicoUpd')
drop proc SpMedicoUpd
go
Create proc SpMedicoUpd
(
		@pIdMedico	int ,
		@pNombre	varchar	(20),
		@pApellidoP	varchar	(20),
		@pApellidoM	varchar	(20),
		@pEdad	    tinyint,
		@pFechaNac	datetime,	
		@pEstadoCiv	varchar	(20),
		@pArea	    varchar	(20),
		@pTelefono1	varchar	(10),
		@pTelefono2	varchar	(10),
		@pEmail	    varchar	(50)

)
as
begin
update Medico
	set
		Nombre=@pNombre,
		ApellidoP=@pApellidoP,
		ApellidoM=@pApellidoM,
		Edad=@pEdad,
		FechaNac=@pFechaNac,
		EstadoCiv=@pEstadoCiv,
		Area=@pArea,
		Telefono1=@pTelefono1,
		Telefono2=@pTelefono2,
		Email=@pEmail

		   
  where IdMedico=@pIdMedico
end

	
	


  


