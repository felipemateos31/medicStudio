using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
    public class SpPermisosUsuario:StoredProcedure
    {
        public SpPermisosUsuario()
            : base("SpPermisoUsuario")
        {
            this.AddParameter("@pIdPerfil", System.Data.SqlDbType.Int, DBNull.Value);
        }

        public int IdPerfil
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdPerfil"].Value, 0); }
            set { this.Command.Parameters["@pIdPerfil"].Value = value; }
        }
    }
}
