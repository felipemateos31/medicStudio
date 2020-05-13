using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Agenda : Entity
	{
		private int _iD;
		private string _nombre;
		private string _apPaterno;
		private string _apMaterno;
		private string _telefeno1;
		private string _telefeno2;
		private string _email;
		private string _direccion;

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

		public string ApPaterno
		{
			get { return this._apPaterno; }
			set { this._apPaterno = value; }
		}

		public string ApMaterno
		{
			get { return this._apMaterno; }
			set { this._apMaterno = value; }
		}

		public string Telefeno1
		{
			get { return this._telefeno1; }
			set { this._telefeno1 = value; }
		}

		public string Telefeno2
		{
			get { return this._telefeno2; }
			set { this._telefeno2 = value; }
		}

		public string Email
		{
			get { return this._email; }
			set { this._email = value; }
		}

		public string Direccion
		{
			get { return this._direccion; }
			set { this._direccion = value; }
		}

		public Agenda(): this(false)
		{
		}

		public Agenda(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}