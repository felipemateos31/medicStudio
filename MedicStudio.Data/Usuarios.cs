using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Usuarios : BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpUsuariosIns sp = new DataEntities.SpUsuariosIns();
            Entities.Usuarios item = entity as Entities.Usuarios;
            sp.IdUsuario = item.ID;
            sp.Nick = item.Nick;
            sp.Pass = item.Pass;
            sp.IdPerfil = item.Perfiles.ID;
            int rowsAffected = 0;
            if (tran != null)
            {
                rowsAffected = sp.ExecuteNonQuery(tran);
            }
            else
            {
                rowsAffected = sp.ExecuteNonQuery(this.ConnectionString);
            } return rowsAffected;
        }

        public override int Update(Entity entity, DataTransaction tran)
        {
            DataEntities.SpUsuariosUpd sp = new DataEntities.SpUsuariosUpd();
            Entities.Usuarios item = entity as Entities.Usuarios;
            sp.IdUsuario = item.ID;
            sp.Nick = item.Nick;
            sp.Pass = item.Pass;
            sp.IdPerfil = item.Perfiles.ID;
            int rowsAffected = 0;
            if (tran != null)
            {
                rowsAffected = sp.ExecuteNonQuery(tran);
            }
            else
            {
                rowsAffected = sp.ExecuteNonQuery(this.ConnectionString);
            } return rowsAffected;
        }

        public List<Entities.Perfiles> ComboPerfiles()
        {
            List<Entities.Perfiles> list = new List<Entities.Perfiles>();
            DataEntities.SpPerfilesCmb sp = new DataEntities.SpPerfilesCmb();
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Entities.Perfiles item = new Entities.Perfiles(true);
                    item.ID = Utils.GetDataRowValue(dr, "IdPerfil", 0);
                    item.NombrePerfil = Utils.GetDataRowValue(dr, "NombrePerfil", "");
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
