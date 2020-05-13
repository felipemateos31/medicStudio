using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Paciente : Entity
	{
		private int _iD;
		private string _nombre;
		private string _apellidoP;
		private string _apellidoM;
		private int _edad;
		private DateTime _fechaNac;
		private string _lugardeNacimiento;
		private string _lugardeResidencia;
		private string _estadoCiv;
		private string _escolaridad;
		private string _ocupacion;
		private string _direccion;
		private string _telefono;
		private string _email;
        private string _nombreCompleto;

		public int ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}

		public string Nombre
		{
			get { return this._nombre; }
			set { this._nombre = value; }
		}

		public string ApellidoP
		{
			get { return this._apellidoP; }
			set { this._apellidoP = value; }
		}

		public string ApellidoM
		{
			get { return this._apellidoM; }
			set { this._apellidoM = value; }
		}

		public int Edad
		{
			get { return this._edad; }
			set { this._edad = value; }
		}

		public DateTime FechaNac
		{
			get { return this._fechaNac; }
			set { this._fechaNac = value; }
		}

		public string LugardeNacimiento
		{
			get { return this._lugardeNacimiento; }
			set { this._lugardeNacimiento = value; }
		}

		public string LugardeResidencia
		{
			get { return this._lugardeResidencia; }
			set { this._lugardeResidencia = value; }
		}

		public string EstadoCiv
		{
			get { return this._estadoCiv; }
			set { this._estadoCiv = value; }
		}

		public string Escolaridad
		{
			get { return this._escolaridad; }
			set { this._escolaridad = value; }
		}

		public string Ocupacion
		{
			get { return this._ocupacion; }
			set { this._ocupacion = value; }
		}

		public string Direccion
		{
			get { return this._direccion; }
			set { this._direccion = value; }
		}

		public string Telefono
		{
			get { return this._telefono; }
			set { this._telefono = value; }
		}

		public string Email
		{
			get { return this._email; }
			set { this._email = value; }
		}
        public string NombreCompleto
        {
            get { return this._nombreCompleto; }
            set { this._nombreCompleto = value; }
        }

		public Paciente(): this(false)
		{
		}

		public Paciente(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}