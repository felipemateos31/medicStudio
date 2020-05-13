if Exists(Select 1 from sys.procedures where name='SpPacienteDel')
drop proc  SpPacienteDel
go
Create proc  SpPacienteDel
(
   @pIdPaciente int
 )
as
begin
   delete Paciente
   where IdPaciente=@pIdPaciente
end