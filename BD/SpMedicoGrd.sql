If Exists(Select 1 from sys.procedures where name='SpMedicoGrd')
drop proc  SpMedicoGrd
go
Create proc  SpMedicoGrd
(
	@pBuscar		varchar(100) = ''
)
as
begin
	select		RowNumber = ROW_NUMBER() over (order by M.IdMedico asc),
				M.IdMedico,
				M.Nombre,
				M.ApellidoP,
				M.ApellidoM,
				M.Edad,
				M.FechaNac,
				M.EstadoCiv,
				M.Area,
				M.Telefono1,
				M.Telefono2,
				M.Email
						
	from		Medico M
	where		M.Nombre like '%'+ @pBuscar +'%' or
	            M.ApellidoP like '%'+ @pBuscar +'%' or 
	            M.ApellidoM like '%'+ @pBuscar +'%'            
end
