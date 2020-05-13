If Exists(Select 1 from sys.procedures where name='SpMedicoIns')
drop proc SpMedicoIns
go
Create proc SpMedicoIns
(
		@pIdMedico	int out,
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
	select @pIdMedico=ISNULL(max(IdMedico),0)+1
	from Medico
	
	insert into Medico(IdMedico,Nombre,ApellidoP,ApellidoM,Edad,FechaNac,EstadoCiv,Area,Telefono1,Telefono2,Email)
	Values			 (@pIdMedico,@pNombre,@pApellidoP,@pApellidoM,@pEdad,@pFechaNac,@pEstadoCiv,@pArea,@pTelefono1,@pTelefono2,@pEmail) 
  
end


