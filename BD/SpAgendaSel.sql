If Exists(Select 1 from sys.procedures where name='SpAgendaSel')
drop proc  SpAgendaSel
go
Create proc  SpAgendaSel
(
    @pIdContacto int
 )
as
begin
    select 
			    A.IdContacto,
				A.Nombre,
				A.ApPaterno,
				A.ApMaterno,
				A.Telefeno1,
				A.Telefeno2,
				A.Email,
				A.Direccion	
    from Agenda A
    where IdContacto=@pIdContacto
end


