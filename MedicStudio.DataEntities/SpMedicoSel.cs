using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
    public class SpMedicoSel : StoredProcedure 
    {
        public SpMedicoSel()
            : base("SpMedicoSel")
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
