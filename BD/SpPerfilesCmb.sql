If Exists(Select 1 from sys.procedures where name='SpPerfilesCmb')
drop proc  SpPerfilesCmb
go
Create proc  SpPerfilesCmb

as
begin
    select P.NombrePerfil, P.IdPerfil
    from Perfiles P
end