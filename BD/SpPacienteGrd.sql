If Exists(Select 1 from sys.procedures where name='SpPacienteGrd')
drop proc  SpPacienteGrd
go
Create proc  SpPacienteGrd
(
	@pBuscar		varchar(100) = ''
)
as
begin
	select		RowNumber = ROW_NUMBER() over (order by P.IdPaciente asc),
	            P.IdPaciente,
				P.Nombre,
				P.ApellidoP,
				P.ApellidoM,
				P.Edad,
				P.FechaNac,
				P.LugardeNacimiento,
				P.LugardeResidencia,
				P.EstadoCiv,
				P.Escolaridad,
				P.Ocupacion,
				P.Direccion,
				P.Telefono,
				P.Email		
	from		Paciente P
	where		P.Nombre like '%'+ @pBuscar +'%' or
	            P.ApellidoP like '%'+ @pBuscar +'%' or 
	            P.ApellidoM like '%'+ @pBuscar +'%'            
end
