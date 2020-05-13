using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpAgendaDel : StoredProcedure
	{
		public SpAgendaDel(): base("SpAgendaDel")
		{
			this.AddParameter("@pIdContacto", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdContacto
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdContacto"].Value, 0); }
			set { this.Command.Parameters["@pIdContacto"].Value = value; }
		}
	}
}