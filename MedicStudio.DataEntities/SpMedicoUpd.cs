using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpMedicoUpd : StoredProcedure
	{
		public SpMedicoUpd(): base("SpMedicoUpd")
		{
			this.AddParameter("@pIdMedico", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApellidoP", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApellidoM", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEdad", System.Data.SqlDbType.TinyInt, DBNull.Value);
			this.AddParameter("@pFechaNac", System.Data.SqlDbType.DateTime, DBNull.Value);
			this.AddParameter("@pEstadoCiv", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pArea", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTelefono1", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTelefono2", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            
		}

		public int IdMedico
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdMedico"].Value, 0); }
			set { this.Command.Parameters["@pIdMedico"].Value = value; }
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

		public string EstadoCiv
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEstadoCiv"].Value, ""); }
			set { this.Command.Parameters["@pEstadoCiv"].Value = value; }
		}

		public string Area
		{
			get { return Utils.IsNull(this.Command.Parameters["@pArea"].Value, ""); }
			set { this.Command.Parameters["@pArea"].Value = value; }
		}

		public string Telefono1
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTelefono1"].Value, ""); }
			set { this.Command.Parameters["@pTelefono1"].Value = value; }
		}

		public string Telefono2
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTelefono2"].Value, ""); }
			set { this.Command.Parameters["@pTelefono2"].Value = value; }
		}

		public string Email
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, ""); }
			set { this.Command.Parameters["@pEmail"].Value = value; }
		}
 
	}
}