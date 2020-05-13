If Exists(Select 1 from sys.procedures where name='SpConsultasMedicasGrd')
drop proc  SpConsultasMedicasGrd
go
Create proc  SpConsultasMedicasGrd
( 
	@pBuscar		varchar(100)
)
as
begin  
 --   Create table #Temporal
 --   (
 --    NombreMedico varchar (35),
 --    IdMedico int,
 --    Area Varchar (15),
 --    NombrePaciente varchar (35),
 --    IdPaciente int,
 --    IdConsulta int
 --   )
	--insert into #Temporal(IdMedico,NombreMedico,Area,NombrePaciente,IdPaciente,IdConsulta)
    Select * from
    (
	select	M.IdMedico,M.Nombre+' '+M.ApellidoP+' '+M.ApellidoM as NombreMedico, M.Area, P.IdPaciente,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM as NombrePaciente,G.IdConsultaMG as IdConsulta,G.Fecha
	from	Medico M
			inner join MedicinaGeneral G
				on G.IdMedico=M.IdMedico
			inner join Paciente P	
				on P.IdPaciente=G.IdPaciente 

	         union 
	            
	         select	M.IdMedico,M.Nombre+' '+M.ApellidoP+' '+M.ApellidoM as NombreMedico, M.Area, P.IdPaciente,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM as NombrePaciente,Ps.IdConsultaPs, Ps.Fecha
	from	Medico M
			inner join Psicologia Ps
				on Ps.IdMedico=M.IdMedico
			inner join Paciente P	
				on P.IdPaciente=Ps.IdPaciente 
			union 	    
	         select	M.IdMedico,M.Nombre+' '+M.ApellidoP+' '+M.ApellidoM as NombreMedico, M.Area, P.IdPaciente,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM as NombrePaciente,N.IdConsultaNut,N.Fecha
	from	Medico M
			inner join Nutricion N
				on N.IdMedico=M.IdMedico
			inner join Paciente P	
				on P.IdPaciente=N.IdPaciente
				
		) as T 
		
				
	where	    T.NombreMedico like '%'+ @pBuscar +'%' or
	            T.NombrePaciente like '%'+ @pBuscar +'%' or
	            T.Area like '%'+ @pBuscar +'%'
		order by T.Fecha desc
end