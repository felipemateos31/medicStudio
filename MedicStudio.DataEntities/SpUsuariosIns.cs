using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpUsuariosIns : StoredProcedure
	{
		public SpUsuariosIns(): base("SpUsuariosIns")
		{
			this.AddParameter("@pIdUsuario", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdPerfil", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pNick", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pPass", System.Data.SqlDbType.VarChar, DBNull.Value);
		}

		public int IdUsuario
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, 0); }
			set { this.Command.Parameters["@pIdUsuario"].Value = value; }
		}

		public int IdPerfil
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdPerfil"].Value, 0); }
			set { this.Command.Parameters["@pIdPerfil"].Value = value; }
		}

		public string Nick
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNick"].Value, ""); }
			set { this.Command.Parameters["@pNick"].Value = value; }
		}

		public string Pass
		{
			get { return Utils.IsNull(this.Command.Parameters["@pPass"].Value, ""); }
			set { this.Command.Parameters["@pPass"].Value = value; }
		}
	}
}