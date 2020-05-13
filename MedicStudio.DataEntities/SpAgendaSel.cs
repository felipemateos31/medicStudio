using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{ 
    public class SpAgendaSel: StoredProcedure
    {
        public SpAgendaSel()
            : base("SpAgendaSel")
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
