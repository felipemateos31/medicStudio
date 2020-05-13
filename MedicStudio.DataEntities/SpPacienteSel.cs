using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
   public class SpPacienteSel:StoredProcedure 
    {
       public SpPacienteSel()
           : base("SpPacienteSel")
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
