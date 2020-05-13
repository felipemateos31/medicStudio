If Exists(Select 1 from sys.procedures where name='SpMedicoCmb')
drop proc  SpMedicoCmb
go
Create proc  SpMedicoCmb

as
begin
    select M.IdMedico,M.Nombre+' '+M.ApellidoP+' '+M.ApellidoM as NombreCompleto
    from Medico M
    where Area='Medicina General'
end


