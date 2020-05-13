using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpMedicinaGeneralDel : StoredProcedure
	{
		public SpMedicinaGeneralDel(): base("SpMedicinaGeneralDel")
		{
			this.AddParameter("@pIdConsultaMG", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdConsultaMG
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsultaMG"].Value, 0); }
			set { this.Command.Parameters["@pIdConsultaMG"].Value = value; }
		}
	}
}