if Exists(Select 1 from sys.procedures where name='SpAgendaDel')
drop proc  SpAgendaDel
go
Create proc  SpAgendaDel
(
   @pIdContacto int
 )
as
begin
   delete Agenda
   where IdContacto=@pIdContacto
end