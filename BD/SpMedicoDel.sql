if Exists(Select 1 from sys.procedures where name='SpMedicoDel')
drop proc  SpMedicoDel
go
Create proc  SpMedicoDel
(
   @pIdMedico int
 )
as
begin
   delete Medico
   where IdMedico=@pIdMedico
end