using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
   public class SpConsultasMedicasGrd:StoredProcedure 
    {
       public SpConsultasMedicasGrd()
           : base("SpConsultasMedicasGrd")
       {
            this.AddParameter("@pBuscar", System.Data.SqlDbType.VarChar, "");
        }
        public string Buscar
        {
            get { return Utils.IsNull(this.Command.Parameters["@pBuscar"].Value, ""); }
            set { this.Command.Parameters["@pBuscar"].Value = value; }
        }
    }
}
