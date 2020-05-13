using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Psicologia : Entity
	{
		private int _iD;
		private Paciente _paciente;
		private Medico _medico;
		private DateTime _fecha;
		private string _motivo;
		private string _antecedentes;
		private string _relacionFamiliar;
		private string _descripcionCircAmigos;
		private string _actividadesIndividuales;
		private bool _casado;
		private bool _unionLibre;
		private bool _soltero;
		private bool _alcohol;
		private bool _fuma;
		private bool _sustancias;
		private string _expectativaTerapia;
		private string _compromisos;
		private string _resultados;
		private string _recomendaciones;

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

		public string Motivo
		{
			get { return this._motivo; }
			set { this._motivo = value; }
		}

		public string Antecedentes
		{
			get { return this._antecedentes; }
			set { this._antecedentes = value; }
		}

		public string RelacionFamiliar
		{
			get { return this._relacionFamiliar; }
			set { this._relacionFamiliar = value; }
		}


		public string DescripcionCircAmigos
		{
			get { return this._descripcionCircAmigos; }
			set { this._descripcionCircAmigos = value; }
		}

		public string ActividadesIndividuales
		{
			get { return this._actividadesIndividuales; }
			set { this._actividadesIndividuales = value; }
		}

		public bool Casado
		{
			get { return this._casado; }
			set { this._casado = value; }
		}

		public bool UnionLibre
		{
			get { return this._unionLibre; }
			set { this._unionLibre = value; }
		}

		public bool Soltero
		{
			get { return this._soltero; }
			set { this._soltero = value; }
		}

		public bool Alcohol
		{
			get { return this._alcohol; }
			set { this._alcohol = value; }
		}

		public bool Fuma
		{
			get { return this._fuma; }
			set { this._fuma = value; }
		}

		public bool Sustancias
		{
			get { return this._sustancias; }
			set { this._sustancias = value; }
		}

		public string ExpectativaTerapia
		{
			get { return this._expectativaTerapia; }
			set { this._expectativaTerapia = value; }
		}

		public string Compromisos
		{
			get { return this._compromisos; }
			set { this._compromisos = value; }
		}

		public string Resultados
		{
			get { return this._resultados; }
			set { this._resultados = value; }
		}

		public string Recomendaciones
		{
			get { return this._recomendaciones; }
			set { this._recomendaciones = value; }
		}

		public Psicologia(): this(false)
		{
		}

		public Psicologia(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}