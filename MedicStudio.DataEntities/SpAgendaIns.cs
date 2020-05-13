using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpAgendaIns : StoredProcedure
	{
		public SpAgendaIns(): base("SpAgendaIns")
		{
			this.AddParameter("@pIdContacto", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApPaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pApMaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTelefeno1", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTelefeno2", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pDireccion", System.Data.SqlDbType.VarChar, DBNull.Value);
		}

		public int IdContacto
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdContacto"].Value, 0); }
			set { this.Command.Parameters["@pIdContacto"].Value = value; }
		}

		public string Nombre
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNombre"].Value, ""); }
			set { this.Command.Parameters["@pNombre"].Value = value; }
		}

		public string ApPaterno
		{
			get { return Utils.IsNull(this.Command.Parameters["@pApPaterno"].Value, ""); }
			set { this.Command.Parameters["@pApPaterno"].Value = value; }
		}

		public string ApMaterno
		{
			get { return Utils.IsNull(this.Command.Parameters["@pApMaterno"].Value, ""); }
			set { this.Command.Parameters["@pApMaterno"].Value = value; }
		}

		public string Telefeno1
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTelefeno1"].Value, ""); }
			set { this.Command.Parameters["@pTelefeno1"].Value = value; }
		}

		public string Telefeno2
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTelefeno2"].Value, ""); }
			set { this.Command.Parameters["@pTelefeno2"].Value = value; }
		}

		public string Email
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, ""); }
			set { this.Command.Parameters["@pEmail"].Value = value; }
		}

		public string Direccion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pDireccion"].Value, ""); }
			set { this.Command.Parameters["@pDireccion"].Value = value; }
		}
	}
}