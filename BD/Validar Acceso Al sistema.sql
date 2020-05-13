If Exists(Select 1 from sys.procedures where name='ValidarAccesoAlSistema')
drop proc ValidarAccesoAlSistema
go
Create proc ValidarAccesoAlSistema
(
@pUsuario varchar(20),
@pPass varchar(20)
)
as
begin
Select U.Nick, U.Pass
from Usuarios U
where U.Nick=@pUsuario and U.Pass=@pPass
end
select * from  sys.procedures


