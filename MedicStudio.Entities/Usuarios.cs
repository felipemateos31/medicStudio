using System;
using Framework;
using System.Collections.Generic;


namespace MedicStudio.Entities
{
	public class Usuarios : Entity
	{
		private int _iD;
		private Perfiles _perfiles;
		private string _nick;
		private string _pass;
        private List<OpcionesPerfiles> _opciones;


        public List<OpcionesPerfiles> Opciones
        {
            get { return this._opciones; }
            set { this._opciones = value; }
        }

		public int ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}

		public Perfiles Perfiles
		{
			get { return this._perfiles; }
			set { this._perfiles = value; }
		}

		public string Nick
		{
			get { return this._nick; }
			set { this._nick = value; }
		}

		public string Pass
		{
			get { return this._pass; }
			set { this._pass = value; }
		}

		public Usuarios(): this(false)
		{
		}

		public Usuarios(bool fromDataSource): base(fromDataSource)
		{
		}
	}
}