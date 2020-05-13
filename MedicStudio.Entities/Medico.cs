using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Medico : Entity
	{
		private int _iD;
		private string _nombre;
		private string _apellidoP;
		private string _apellidoM;
		private int _edad;
		private DateTime _fechaNac;
		private string _estadoCiv;
		private string _area;
		private string _telefono1;
		private string _telefono2;
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

		public string EstadoCiv
		{
			get { return this._estadoCiv; }
			set { this._estadoCiv = value; }
		}

		public string Area
		{
			get { return this._area; }
			set { this._area = value; }
		}

		public string Telefono1
		{
			get { return this._telefono1; }
			set { this._telefono1 = value; }
		}

		public string Telefono2
		{
			get { return this._telefono2; }
			set { this._telefono2 = value; }
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

		public Medico(): this(false)
		{
		}

		public Medico(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}