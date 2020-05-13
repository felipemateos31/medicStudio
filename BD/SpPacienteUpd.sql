If Exists(Select 1 from sys.procedures where name='SpPacienteUpd')
drop proc SpPacienteUpd
go
Create proc SpPacienteUpd
(
	@pIdPaciente int ,
	@pNombre	 varchar	(50),
	@pApellidoP	 varchar	(30),
	@pApellidoM	 varchar	(20),
	@pEdad	tinyint,
	@pFechaNac	date,
	@pLugardeNacimiento	varchar	(30),
	@pLugardeResidencia	varchar	(30),
	@pEstadoCiv	varchar		    (20),
	@pEscolaridad	varchar		(20),
	@pOcupacion	varchar		(30),
	@pDireccion	varchar		(50),
	@pTelefono	varchar		(10),
	@pEmail	varchar		    (50)
)
as
begin
	update Paciente
	set
		Nombre=@pNombre,
		ApellidoP=@pApellidoP,
		ApellidoM=@pApellidoM,
		Edad=@pEdad,
		FechaNac=@pFechaNac,
		LugardeNacimiento=@pLugardeNacimiento,
		LugardeResidencia=@pLugardeResidencia,
		EstadoCiv=@pEstadoCiv,
		Escolaridad=@pEscolaridad,
		Ocupacion=@pOcupacion,
		Direccion=@pDireccion,
		Telefono=@pTelefono,
		Email=@pEmail
  where IdPaciente= @pIdPaciente
end
	


  
