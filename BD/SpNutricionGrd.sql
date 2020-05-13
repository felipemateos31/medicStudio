If Exists(Select 1 from sys.procedures where name='SpNutricionGrd')
drop proc  SpNutricionGrd
go
Create proc  SpNutricionGrd
(
	@pBuscar		varchar(100) = ''
)
as
begin
	select		RowNumber = ROW_NUMBER() over (order by N.IdConsulta asc),
				N.IdConsulta,
				N.IdPaciente,
				N.IdMedico,
				N.Fecha,
				N.MotivoConsulta,
				N.ProblemasActuales,
				N.Peso,
				N.Estatura,
				N.Talla,
				N.IMC,
				N.Pecho,
				N.Abdomen,
				N.Cuello,
				N.Brazo,
				N.EnfermedadImp,
				N.InfoMedicamentos,
				N.Cirugia,
				N.TipoDeCirugia,
				N.EnfermedadesCornicas,
				N.ActividadFisica,
				N.Observaciones,
				M.IdMedico,M.Nombre+' '+M.ApellidoP+' '+M.ApellidoM as NombreMedico,
				P.IdPaciente,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM as NombrePaciente,
				M.Area
	from Nutricion N
		inner join Medico M
				on N.IdMedico = M.IdMedico
		inner join Paciente P
				on N.IdPaciente = p.IdPaciente
	where		NombreMedico like '%'+ @pBuscar +'%' or
	            NombrePaciente like '%'+ @pBuscar +'%' or 
	            M.Area like '%'+ @pBuscar +'%'        
end