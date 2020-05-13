if exists (select 1 from sys.procedures where name = 'SpNutricionIns')
drop proc SpNutricionIns
go

create proc SpNutricionIns
(
	@pIdConsultaNut int, 
	@pIdPaciente int, 
	@pIdMedico int,  
	@pMotivoConsulta text, 
	@pProblemasActuales text, 
	@pPeso varchar(15), 
	@pEstatura varchar(15), 
	@pTalla varchar(15), 
	@pIMC varchar(15), 
	@pPecho varchar(10), 
	@pAbdomen varchar(10), 
	@pCuello varchar(10), 
	@pBrazo varchar(10), 
	@pEnfermedadImp varchar(30), 
	@pInfoMedicamentos text, 
	@pCirugia bit, 
	@pTipoDeCirugia varchar(40), 
	@pEnfermedadesCornicas text, 
	@pActividadFisica text, 
	@pObservaciones text
)
as
begin
	select @pIdConsultaNut=ISNULL(max(IdConsultaNut),0)+1
	from Nutricion

	insert into Nutricion
	(
		IdConsultaNut, 
		IdPaciente, 
		IdMedico, 
		Fecha, 
		MotivoConsulta, 
		ProblemasActuales, 
		Peso, 
		Estatura, 
		Talla, 
		IMC, 
		Pecho, 
		Abdomen, 
		Cuello, 
		Brazo, 
		EnfermedadImp, 
		InfoMedicamentos, 
		Cirugia, 
		TipoDeCirugia, 
		EnfermedadesCornicas, 
		ActividadFisica, 
		Observaciones
	)
	values
	(
		@pIdConsultaNut, 
		@pIdPaciente, 
		@pIdMedico, 
		GetDate(), 
		@pMotivoConsulta, 
		@pProblemasActuales, 
		@pPeso, 
		@pEstatura, 
		@pTalla, 
		@pIMC, 
		@pPecho, 
		@pAbdomen, 
		@pCuello, 
		@pBrazo, 
		@pEnfermedadImp, 
		@pInfoMedicamentos, 
		@pCirugia, 
		@pTipoDeCirugia, 
		@pEnfermedadesCornicas, 
		@pActividadFisica, 
		@pObservaciones
	)

end