if exists (select 1 from sys.procedures where name = 'SpMedicinaGeneralDel')
drop proc SpMedicinaGeneralDel
go

create proc SpMedicinaGeneralDel
(
	@pIdConsultaMG int
)
as
begin

	delete MedicinaGeneral
	where 	IdConsultaMG = @pIdConsultaMG

end