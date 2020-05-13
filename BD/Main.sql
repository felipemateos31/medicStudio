
create table Paciente
(
IdPaciente int, --No es nulo, llave primaria, auto-incrementar
Nombre varchar (50) not null, 
ApellidoP varchar (30)not null,
ApellidoM varchar (20) null,
Edad tinyint not null,
FechaNac datetime not null,
LugardeNacimiento varchar (30),
LugardeResidencia varchar (30),
EstadoCiv Varchar (20) not null,
Escolaridad varchar (20) not null,
Ocupacion varchar (30) not null,
Direccion varchar (50) null,
Telefono varchar (10) null,
Email varchar (50) null,
constraint PK_Paciente primary key(IdPaciente)
)

create table Medico
(
IdMedico int,
Nombre varchar (20) not null,
ApellidoP varchar (20)not null,
ApellidoM varchar (20)not null,
Edad tinyint not null,
FechaNac datetime not null,
EstadoCiv Varchar (20) not null,
Area varchar (20) not null,
Telefono1 varchar (10) not null,
Telefono2 varchar (10) null,
Email varchar (50) not null,
Usuario Varchar (5) not null,
Pass Varchar (10) not null,
constraint PK_Medico primary key(IdMedico)
)
create table Agenda
(
	IdContacto int,
	Nombre varchar (20) not null,
	ApPaterno varchar (20) not null,
	ApMaterno Varchar (20) not null,
	Telefeno1 Varchar (10) not null, 
	Telefeno2 Varchar (10) null,
	Email varchar (50) null,
	Direccion Varchar (50) not null,
	constraint PK_Agenda primary key (IdContacto)
)


-----------------------------------------------------------Nutricion--------------------------------------------------------------
create table Nutricion
(
IdConsultaNut int,
IdPaciente int not null,
IdMedico int not null,
Fecha date not null,
MotivoConsulta text not null,
ProblemasActuales text not null,
Peso Varchar (15) not null,
Estatura varchar (15) not null,
Talla Varchar (15) not null,
IMC Varchar(15) not null,
Pecho Varchar (10) not null,
Abdomen  Varchar (10) not null, 
Cuello  Varchar (10) not null,
Brazo Varchar (10)not null,
EnfermedadImp varchar(30) null,
InfoMedicamentos text not null,
Cirugia bit null,
TipoDeCirugia varchar (40) not null,
EnfermedadesCornicas text not null,
ActividadFisica text not null,
Observaciones text not null
Constraint PK_Nutricion primary key(IdConsultaNut),
constraint FK_Nutricion_Medico foreign key (IdMedico) references Medico(IdMedico),
constraint FK_Nutricion_Paciente foreign key (IdPaciente) references Paciente(IdPaciente)
)

--------------------------------------------------------PSICOLOGÍA-----------------------------------------------------------------

create table Psicologia
(
	IdConsultaPs int, 
	IdPaciente int, 
	IdMedico int,
	Fecha Date not null,
	Motivo text not null,
	Antecedentes text not null,
	RelacionFamiliar text not null,
	DescripcionCircAmigos text not null,
	ActividadesIndividuales text not null,
	Casado bit not null,
	UnionLibre bit not null,
	soltero bit not null,
	Alcohol bit not null,
	Fuma bit not null,
	Sustancias bit not null,
	ExpectativaTerapia text  not null,
	Compromisos text not null,
	Resultados  text not null,
	Recomendaciones  text not null
	Constraint PK_Psicologia  primary key(IdConsultaPs),
	constraint FK_Psicologia_Medico foreign key (IdMedico) references Medico(IdMedico),
	constraint FK_Psicologia_Paciente foreign key (IdPaciente) references Paciente(IdPaciente)
)
-------------------------------------------ConsultaGeneral------------------------------------------------------------------
create table MedicinaGeneral
(
	IdConsultaMG int,
	IdPaciente int not null,
	IdMedico int not null,
	Fecha date not null,
	MotivoConsulta text not null,
	ProblemasActuales text not null,
	Medicamentos text not null,
	Observaciones text not null,
	EnfermedadesCronicas text not null,
	EnfermedadesImportantes text not null,
	Diagnstico text not null
	Constraint PK_MedicinaGeneral  primary key(IdConsultaMG),
	constraint FK_MedicinaGeneral_Medico foreign key (IdMedico) references Medico(IdMedico),
	constraint FK_MedicinaGeneral_Paciente foreign key (IdPaciente) references Paciente(IdPaciente)
)
--------------------------------------------HISTORIAL MEDICO-----------------------------------------------------------------
Create table HistoriaClinica
(
	IdConsultaMed int, 
	IdPaciente int, 
	IdMedico int,
	Fecha datetime not null,
	InterrogatorioDirecto bit null,
	InterrogatorioIndirecto bit null
	Constraint PK_HistoriaClinica primary key(IdConsultaMed)
)
create table AntecedentesHeredoFamiliares
(
IdConsultaMed int,
IdAntecedentesMed int,
Diabetes bit null,
DiabetesPadre bit null,
DiabetesMadre bit null,
HTA bit null,
HTAPadre bit null,
HTAMadre bit null,
Oncologicos bit null,
OncologicosPadre bit null,
OncologicosMadre bit null,
Coagulopatias bit null,
CoagulopatiasPadre bit null,
Coagulopatias bit not null,
Artritis bit null,
ArtritisPadre bit null,
ArtritisMadre bit null,
Mentales bit null,
MentalesPadre bit null,
MentalesMadre bit null,
Alcoholismo bit null,
AlcoholismoPadre bit null,
AlcoholismoMadre bit null,
Hiperlipidemias bit null,
HiperlipidemiasPadre bit null,
HiperlipidemiasMadre bit null,
Tuberculosis bit null,
TuberculosisPadre bit null,
TuberculosisMadre bit null,
Alergias bit null,
AlergiasPadre bit null,
AlergiasMadre bit null,
Cardiopatias bit null,
CardiopatiasPadre bit null,
CardiopatiasMadre bit null,
Obesidad bit null,
ObesidadPadre bit null,
ObesidadMadre bit null,
Hemofilia bit null,
HemofiliaPadre bit null,
HemofiliaMadre bit null,
Toxicomanias bit null,
ToxicomaniasPadre bit null,
ToxicomaniasMadre bit null,
AltGeneticas bit null,
AltGeneticasPadre bit null,
AltGeneticasMadre bit null,
ITSSIDA bit null,
ITSSIDAPadre bit null,
ITSSIDAMadre bit null,
Otros varchar (50)
Constraint PK_AntecedentesHeredofamiliares primary key (IdAntecedentesMed),
constraint FK_AntecedentesHeredoFamiliares foreign key (IdConsultaMed) references HistoriaClinica (IdMedico)
)

create table AntecedentesPersonalesNoPatologicos
(
IdConsultaMed int,
AntecedentesNoPatologicos int,
CalidadAlimentacion char (10) not null,
Cantidad char(10) not null,
FrecuenciaAlimentacion tinyint null,
HabitosHigienicos char(10) not null,
Alcoholismo bit null,
DetallesAlcoholismo varchar (100) null,
Drogas bit null,
DetallesDrogas varchar(100) null,
Tabaquismo bit null,
DetallesTabaquismo varchar(100) null,
CantidadCigarrosDiarios tinyint null,
Inmunizaciones bit null,
DetallesInmunizaciones varchar(100) null,
constraint PK_AntecedentesPersonalesNoPatologicos primary key (IdAntecedentesNoPatologicos),
constraint FK_AntecedentesPersonalesNoPatologicos foreign key (IdConsultaMed) references HistoriaClinica (IdMedico) 
)

Create table AntecedentesPatologicos
(
IdConsultaMed int,
IdAntecedentesPatologicos int,
Alegricos bit null,
TipoAlergenos varchar(100) null,
Reumatismo bit null,
Diabetico bit null,
TiempoEvolucion varchar(20) null,
Tratamiento varchar(100) null,
ITS bit null,
TipoITS varchar(30) null,
VIHSIDA bit null,
Neurologicos bit null,
Infecciones bit null,
TipoInfecciones Varchar(30) null,
ParasitosisIntestinal bit null,
Quirurjicos bit null,
CirugiaRealizada varchar(30) null,
FechaDeCirugia datetime null,
HemoTransfusion bit null,
FechaHemoTransfusion datetime null,
Cardiopatías bit null,
DiagnosticoCardiopatias Varchar(50) null,
FechaCardioPatias datetime null,
EnfermedadesRenales bit null,
DiagnosticoEnfermedadesRenales Varchar(50) null,
FechaEnfermedadesRenales datetime null,
Cancer bit null,
DiagnosticoCancer Varchar(50) null,
FechaCancer datetime null,
ControlActualmente bit null,
Anemia bit null,
Epsitaxis bit null,
Hemoptsis bit null,
Rectorragia bit null,
Melenta bit null,
HepatitisA bit null,
HepatitisB bit null,
HepatitisC bit null,
HepatitisDesconocida bit null,
Neuropatias bit null,
FechaNeuropatias datetime null,
TratamientoNeuropatias bit null,
Paludismo bit null,
FechaPaludismo datetime null,
TratamientoPaludismo bit null,
Tifoidea bit null,
FechaTifoidea datetime null,
TratamientoTifoidea Bit null,
Brucelosis bit null,
FechaTuberculosis datetime null,
Tratamiento bit null,
CrisisConvulsivas bit null,
TratamientoCrisisConvulsivas Varchar(100),
EnfermedadesMetales bit null,
Diagnostico varchar(80)null,
TratamientoEnfermedadesMEntales Varchar (100),
Traumaticos bit null,
TipoTraumaticos varchar(80),
Ulceras bit null,
TratamientoActual varchar(100),
OtrasPatologias varchar (100),
constraint PK_AntecedentesPersonalesPatologicos primary key (IdAntecedentesPatologicos),
constraint FK_AntecedentesPersonalesPatologicos foreign key (IdConsultaMed) references HistoriaClinica (IdMedico) 
)

Create table AntecedentesPerinatales
(
IdMedico int,
IdAntecedentesPerinatales int,
PesoAlNacer float null,
TallaAlNacer Varchar (10) null,
SemanaDeGestacion tinyint null,
ComplicacionesAlNacimiento varchar(100)null,
LugarEnLaFamilia varchar(50) null,
HistoriaAlimentaria varchar(80)null,
DesarrolloPsicomotor varchar (100)null,
constraint PK_AntecedentesPerinatales primary key (IdAntecedentesPerinatales),
constraint FK_AntecedentesPerinatales foreign key (IdConsultaMed) references HistoriaClinica (IdMedico) 

)



