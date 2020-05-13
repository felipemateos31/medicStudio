using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpPacienteDel : StoredProcedure
	{
		public SpPacienteDel(): base("SpPacienteDel")
		{
			this.AddParameter("@pIdPaciente", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdPaciente
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdPaciente"].Value, 0); }
			set { this.Command.Parameters["@pIdPaciente"].Value = value; }
		}
	}
}