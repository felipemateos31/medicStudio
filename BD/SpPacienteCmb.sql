If Exists(Select 1 from sys.procedures where name='SpPacienteCmb')
drop proc  SpPacienteCmb
go
Create proc  SpPacienteCmb

as
begin
    select P.IdPaciente,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM as NombreCompleto
    from Paciente P
end