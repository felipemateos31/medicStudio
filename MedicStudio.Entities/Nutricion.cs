using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Nutricion : Entity
	{
		private int _iD;
		private Paciente _paciente;
		private Medico _medico;
		private DateTime _fecha;
		private string _motivoConsulta;
		private string _problemasActuales;
		private string _peso;
		private string _estatura;
		private string _talla;
		private string _iMC;
		private string _pecho;
		private string _abdomen;
		private string _cuello;
		private string _brazo;
		private string _enfermedadImp;
		private string _infoMedicamentos;
		private bool _cirugia;
		private string _tipoDeCirugia;
		private string _enfermedadesCornicas;
		private string _actividadFisica;
		private string _observaciones;

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

		public string Peso
		{
			get { return this._peso; }
			set { this._peso = value; }
		}

		public string Estatura
		{
			get { return this._estatura; }
			set { this._estatura = value; }
		}

		public string Talla
		{
			get { return this._talla; }
			set { this._talla = value; }
		}

		public string IMC
		{
			get { return this._iMC; }
			set { this._iMC = value; }
		}

		public string Pecho
		{
			get { return this._pecho; }
			set { this._pecho = value; }
		}

		public string Abdomen
		{
			get { return this._abdomen; }
			set { this._abdomen = value; }
		}

		public string Cuello
		{
			get { return this._cuello; }
			set { this._cuello = value; }
		}

		public string Brazo
		{
			get { return this._brazo; }
			set { this._brazo = value; }
		}

		public string EnfermedadImp
		{
			get { return this._enfermedadImp; }
			set { this._enfermedadImp = value; }
		}

		public string InfoMedicamentos
		{
			get { return this._infoMedicamentos; }
			set { this._infoMedicamentos = value; }
		}

		public bool Cirugia
		{
			get { return this._cirugia; }
			set { this._cirugia = value; }
		}

		public string TipoDeCirugia
		{
			get { return this._tipoDeCirugia; }
			set { this._tipoDeCirugia = value; }
		}

		public string EnfermedadesCornicas
		{
			get { return this._enfermedadesCornicas; }
			set { this._enfermedadesCornicas = value; }
		}

		public string ActividadFisica
		{
			get { return this._actividadFisica; }
			set { this._actividadFisica = value; }
		}

		public string Observaciones
		{
			get { return this._observaciones; }
			set { this._observaciones = value; }
		}

		public Nutricion(): this(false)
		{
		}

		public Nutricion(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}