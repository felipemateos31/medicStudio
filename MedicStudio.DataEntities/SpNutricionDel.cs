using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpNutricionDel : StoredProcedure
	{
		public SpNutricionDel(): base("SpNutricionDel")
		{
			this.AddParameter("@pIdConsulta", System.Data.SqlDbType.Int, DBNull.Value);
		}

		public int IdConsulta
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsulta"].Value, 0); }
			set { this.Command.Parameters["@pIdConsulta"].Value = value; }
		}
	}
}