if exists (select 1 from sys.procedures where name = 'SpNutricionDel')
drop proc SpNutricionDel
go

create proc SpNutricionDel
(
	@pIdConsultaNut int
)
as
begin

	delete Nutricion
	where 	IdConsultaNut = @pIdConsultaNut

end