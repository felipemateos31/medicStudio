using System;
using Framework;

namespace MedicStudio.Entities
{
	public class OpcionesPerfiles : Entity
	{
		private Opciones _opciones;
		private Perfiles _perfiles;
		private bool _acceso;

		public Opciones Opciones
		{
			get { return this._opciones; }
			set { this._opciones = value; }
		}

		public Perfiles Perfiles
		{
			get { return this._perfiles; }
			set { this._perfiles = value; }
		}

		public bool Acceso
		{
			get { return this._acceso; }
			set { this._acceso = value; }
		}

		public OpcionesPerfiles(): this(false)
		{
		}

		public OpcionesPerfiles(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}