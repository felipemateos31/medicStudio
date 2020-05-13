using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class OpcionesPerfiles : BaseDataObject
    {
        public List<Entities.OpcionesPerfiles> Perfiles(int IdPerfil)
        {
            List<Entities.OpcionesPerfiles> list = new List<Entities.OpcionesPerfiles>();
            DataEntities.SpPermisosUsuario sp = new DataEntities.SpPermisosUsuario();
            sp.IdPerfil = IdPerfil;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.OpcionesPerfiles item = new Entities.OpcionesPerfiles(true);
                item.Opciones = new Entities.Opciones();
                item.Perfiles = new Entities.Perfiles();
                item.Opciones.ID = Utils.GetDataRowValue(dr, "IdOpcion", 0);
                item.Perfiles.ID = Utils.GetDataRowValue(dr, "IdPerfil", 0);
                item.Acceso = Utils.GetDataRowValue(dr, "Acceso", false);
                list.Add(item);
            }

            return list;
        }
    }
}
