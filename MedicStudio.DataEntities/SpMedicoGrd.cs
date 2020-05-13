using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
    public class SpMedicoGrd: StoredProcedure 
    {
        public SpMedicoGrd()
            : base("SpMedicoGrd")
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
