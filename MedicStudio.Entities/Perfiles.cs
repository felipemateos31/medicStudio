using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Perfiles : Entity
	{
		private int _iD;
		private string _nombrePerfil;

		public int ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}

		public string NombrePerfil
		{
			get { return this._nombrePerfil; }
			set { this._nombrePerfil = value; }
		}

		public Perfiles(): this(false)
		{
		}

		public Perfiles(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}