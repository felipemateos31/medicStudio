If Exists(Select 1 from sys.procedures where name='SpAgendaGrd')
drop proc  SpAgendaGrd
go
Create proc  SpAgendaGrd
(
	@pBuscar		varchar(100) = ''
)
as
begin
	select		RowNumber = ROW_NUMBER() over (order by A.IdContacto asc),
	            A.IdContacto,
				A.Nombre,
				A.ApPaterno,
				A.ApMaterno,
				A.Telefeno1,
				A.Telefeno2,
				A.Email,
				A.Direccion		
	from		Agenda A
	where		A.Nombre like '%'+ @pBuscar +'%' or
	            A.ApPaterno like '%'+ @pBuscar +'%' or 
	            A.ApMaterno like '%'+ @pBuscar +'%'            
end
