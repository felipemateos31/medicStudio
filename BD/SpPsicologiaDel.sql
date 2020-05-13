if exists (select 1 from sys.procedures where name = 'SpPsicologiaDel')
drop proc SpPsicologiaDel
go

create proc SpPsicologiaDel
(
	@pIdConsultaPs int
)
as
begin

	delete Psicologia
	where 	IdConsultaPs = @pIdConsultaPs

end