using System;
using Framework;

namespace MedicStudio.Entities
{
	public class MedicinaGeneral : Entity
	{
		private int _iD;
		private Paciente _paciente;
		private Medico _medico;
		private DateTime _fecha;
		private string _motivoConsulta;
		private string _problemasActuales;
		private string _medicamentos;
		private string _observaciones;
		private string _enfermedadesCronicas;
		private string _enfermedadesImportantes;
		private string _diagnstico;

		public int ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}

		public Paciente Paciente
		{
			get { return this._paciente; }
			set { this._paciente = value; }
		}

		public Medico Medico
		{
			get { return this._medico; }
			set { this._medico = value; }
		}

		public DateTime Fecha
		{
			get { return this._fecha; }
			set { this._fecha = value; }
		}

		public string MotivoConsulta
		{
			get { return this._motivoConsulta; }
			set { this._motivoConsulta = value; }
		}

		public string ProblemasActuales
		{
			get { return this._problemasActuales; }
			set { this._problemasActuales = value; }
		}

		public string Medicamentos
		{
			get { return this._medicamentos; }
			set { this._medicamentos = value; }
		}

		public string Observaciones
		{
			get { return this._observaciones; }
			set { this._observaciones = value; }
		}

		public string EnfermedadesCronicas
		{
			get { return this._enfermedadesCronicas; }
			set { this._enfermedadesCronicas = value; }
		}

		public string EnfermedadesImportantes
		{
			get { return this._enfermedadesImportantes; }
			set { this._enfermedadesImportantes = value; }
		}

		public string Diagnstico
		{
			get { return this._diagnstico; }
			set { this._diagnstico = value; }
		}

		public MedicinaGeneral(): this(false)
		{
		}

		public MedicinaGeneral(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}