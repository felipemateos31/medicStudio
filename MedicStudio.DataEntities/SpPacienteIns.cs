using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpPacienteIns : StoredProcedure
	{
		public SpPacienteIns(): base("SpPacienteIns")
		{
			this.AddParameter("@pIdPaciente", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApellidoP", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApellidoM", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEdad", System.Data.SqlDbType.TinyInt, DBNull.Value);
			this.AddParameter("@pFechaNac", System.Data.SqlDbType.Date, DBNull.Value);
			this.AddParameter("@pLugardeNacimiento", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pLugardeResidencia", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEstadoCiv", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEscolaridad", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pOcupacion", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pDireccion", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTelefono", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
		}

		public int IdPaciente
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdPaciente"].Value, 0); }
			set { this.Command.Parameters["@pIdPaciente"].Value = value; }
		}

		public string Nombre
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNombre"].Value, ""); }
			set { this.Command.Parameters["@pNombre"].Value = value; }
		}

		public string ApellidoP
		{
			get { return Utils.IsNull(this.Command.Parameters["@pApellidoP"].Value, ""); }
			set { this.Command.Parameters["@pApellidoP"].Value = value; }
		}

		public string ApellidoM
		{
			get { return Utils.IsNull(this.Command.Parameters["@pApellidoM"].Value, ""); }
			set { this.Command.Parameters["@pApellidoM"].Value = value; }
		}

		public int Edad
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEdad"].Value, 0); }
			set { this.Command.Parameters["@pEdad"].Value = value; }
		}

		public DateTime FechaNac
		{
			get { return Utils.IsNull(this.Command.Parameters["@pFechaNac"].Value, DateTime.MinValue); }
			set
			{
				if (value != DateTime.MinValue)
				{
					this.Command.Parameters["@pFechaNac"].Value = value;
				}
				else
				{
					this.Command.Parameters["@pFechaNac"].Value = DBNull.Value;
				}
			}
		}

		public string LugardeNacimiento
		{
			get { return Utils.IsNull(this.Command.Parameters["@pLugardeNacimiento"].Value, ""); }
			set { this.Command.Parameters["@pLugardeNacimiento"].Value = value; }
		}

		public string LugardeResidencia
		{
			get { return Utils.IsNull(this.Command.Parameters["@pLugardeResidencia"].Value, ""); }
			set { this.Command.Parameters["@pLugardeResidencia"].Value = value; }
		}

		public string EstadoCiv
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEstadoCiv"].Value, ""); }
			set { this.Command.Parameters["@pEstadoCiv"].Value = value; }
		}

		public string Escolaridad
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEscolaridad"].Value, ""); }
			set { this.Command.Parameters["@pEscolaridad"].Value = value; }
		}

		public string Ocupacion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pOcupacion"].Value, ""); }
			set { this.Command.Parameters["@pOcupacion"].Value = value; }
		}

		public string Direccion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pDireccion"].Value, ""); }
			set { this.Command.Parameters["@pDireccion"].Value = value; }
		}

		public string Telefono
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTelefono"].Value, ""); }
			set { this.Command.Parameters["@pTelefono"].Value = value; }
		}

		public string Email
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, ""); }
			set { this.Command.Parameters["@pEmail"].Value = value; }
		}
	}
}