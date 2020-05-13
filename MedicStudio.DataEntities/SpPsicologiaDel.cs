using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpPsicologiaDel : StoredProcedure
	{
		public SpPsicologiaDel(): base("SpPsicologiaDel")
		{
			this.AddParameter("@pIdConsultaPs", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdConsulta
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsultaPs"].Value, 0); }
			set { this.Command.Parameters["@pIdConsultaPs"].Value = value; }
		}
	}
}