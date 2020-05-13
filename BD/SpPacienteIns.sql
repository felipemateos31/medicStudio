If Exists(Select 1 from sys.procedures where name='SpPacienteIns')
drop proc SpPacienteIns
go
Create proc SpPacienteIns
(
	@pIdPaciente int out,
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
	select @pIdPaciente=ISNULL(max(IdPaciente),0)+1
	from Paciente
	
	insert into Paciente(IdPaciente,Nombre,ApellidoP,ApellidoM,Edad,FechaNac,LugardeNacimiento,LugardeResidencia,EstadoCiv,Escolaridad,Ocupacion,Direccion,Telefono,Email)
	Values			 (@pIdPaciente,@pNombre,@pApellidoP,@pApellidoM,@pEdad,@pFechaNac,@pLugardeNacimiento,@pLugardeResidencia,@pEstadoCiv,@pEscolaridad,@pOcupacion,@pDireccion,@pTelefono,@pEmail)	
  
end



