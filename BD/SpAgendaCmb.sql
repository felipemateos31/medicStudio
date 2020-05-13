If Exists(Select 1 from sys.procedures where name='SpAgendaCmb')
drop proc  SpAgendaCmb
go
Create proc  SpAgendaCmb

as
begin
    select A.IdContacto,A.Nombre+' '+A.ApPaterno+' '+A.ApMaterno as NombreCompleto
    from Agenda A
end


