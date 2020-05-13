If Exists(Select 1 from sys.procedures where name='SpPacienteSel')
drop proc  SpPacienteSel
go
Create proc  SpPacienteSel
(
    @pIdPaciente int
 )
as
begin
    select      P.IdPaciente,
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
    from Paciente P
    where  IdPaciente=@pIdPaciente
end