using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;


namespace MedicStudio.DataEntities
{
    public class ValidarAccesoAlSistema : StoredProcedure
    {
        public ValidarAccesoAlSistema() :
            base("ValidarAccesoAlSistema")
        {
            this.AddParameter("@pUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pPass", System.Data.SqlDbType.VarChar, DBNull.Value);
        }
        public string Usuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pUsuario"].Value, ""); }
            set { this.Command.Parameters["@pUsuario"].Value = value; }
        }

        public string Pass
        {
            get { return Utils.IsNull(this.Command.Parameters["@pPass"].Value, ""); }
            set { this.Command.Parameters["@pPass"].Value = value; }
        }
    }
}
