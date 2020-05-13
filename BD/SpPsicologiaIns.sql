if exists (select 1 from sys.procedures where name = 'SpPsicologiaIns')
drop proc SpPsicologiaIns
go

create proc SpPsicologiaIns
(
	@pIdConsultaPs int, 
	@pIdPaciente int, 
	@pIdMedico int,  
	@pMotivo text, 
	@pAntecedentes text, 
	@pRelacionFamiliar text, 
	@pDescripcionCircAmigos text, 
	@pActividadesIndividuales text, 
	@pCasado bit, 
	@pUnionLibre bit, 
	@psoltero bit, 
	@pAlcohol bit, 
	@pFuma bit, 
	@pSustancias bit, 
	@pExpectativaTerapia text, 
	@pCompromisos text, 
	@pResultados text, 
	@pRecomendaciones text
)
as
begin
   select @pIdConsultaPs=ISNULL(max(IdConsultaPs),0)+1
	from Psicologia

	insert into Psicologia
	(
		IdConsultaPs, 
		IdPaciente, 
		IdMedico, 
		Fecha, 
		Motivo, 
		Antecedentes, 
		RelacionFamiliar, 
		DescripcionCircAmigos, 
		ActividadesIndividuales, 
		Casado, 
		UnionLibre, 
		soltero,  
		Alcohol, 
		Fuma, 
		Sustancias, 
		ExpectativaTerapia, 
		Compromisos, 
		Resultados, 
		Recomendaciones
	)
	values
	(
		@pIdConsultaPs, 
		@pIdPaciente, 
		@pIdMedico, 
		GetDate(), 
		@pMotivo, 
		@pAntecedentes, 
		@pRelacionFamiliar, 
		@pDescripcionCircAmigos, 
		@pActividadesIndividuales, 
		@pCasado, 
		@pUnionLibre, 
		@psoltero,  
		@pAlcohol, 
		@pFuma, 
		@pSustancias, 
		@pExpectativaTerapia, 
		@pCompromisos, 
		@pResultados, 
		@pRecomendaciones
	)

end