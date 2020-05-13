if exists (select 1 from sys.procedures where name = 'SpMedicinaGeneralIns')
drop proc SpMedicinaGeneralIns
go

create proc SpMedicinaGeneralIns
(
	@pIdConsultaMG int, 
	@pIdPaciente int, 
	@pIdMedico int, 
	@pMotivoConsulta text, 
	@pProblemasActuales text, 
	@pMedicamentos text, 
	@pObservaciones text, 
	@pEnfermedadesCronicas text, 
	@pEnfermedadesImportantes text, 
	@pDiagnstico text
)
as
begin
	select @pIdConsultaMG=ISNULL(max(IdConsultaMG),0)+1
	from MedicinaGeneral

	insert into MedicinaGeneral
	(
		IdConsultaMG, 
		IdPaciente, 
		IdMedico, 
		Fecha, 
		MotivoConsulta, 
		ProblemasActuales, 
		Medicamentos, 
		Observaciones, 
		EnfermedadesCronicas, 
		EnfermedadesImportantes, 
		Diagnstico
	)
	values
	(
		@pIdConsultaMG, 
		@pIdPaciente, 
		@pIdMedico, 
		GetDate(), 
		@pMotivoConsulta, 
		@pProblemasActuales, 
		@pMedicamentos, 
		@pObservaciones, 
		@pEnfermedadesCronicas, 
		@pEnfermedadesImportantes, 
		@pDiagnstico
	)

end