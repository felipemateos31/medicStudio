using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpMedicoDel : StoredProcedure
	{
		public SpMedicoDel(): base("SpMedicoDel")
		{
			this.AddParameter("@pIdMedico", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdMedico
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdMedico"].Value, 0); }
			set { this.Command.Parameters["@pIdMedico"].Value = value; }
		}
	}
}