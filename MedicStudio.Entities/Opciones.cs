using System;
using Framework;

namespace MedicStudio.Entities
{
	public class Opciones : Entity
	{
		private int _iD;
		private string _nombreOpcion;

		public int ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}

		public string NombreOpcion
		{
			get { return this._nombreOpcion; }
			set { this._nombreOpcion = value; }
		}

		public Opciones(): this(false)
		{
		}

		public Opciones(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}