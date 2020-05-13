using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Acceso : BaseDataObject
    {
        public Entities.Usuarios ValidarAcceso(string Usuario, string Pass)
        {
            Entities.Usuarios Us = null;

            DataEntities.ValidarAccesoAlSistema Va = new DataEntities.ValidarAccesoAlSistema();
            Va.Usuario = Usuario;
            Va.Pass = Pass;
            DataTable dt = Va.GetDataTable(this.ConnectionString);
            bool Validar =  dt.Rows.Count == 1;

            if (Validar == true)
            {
                Us = new Entities.Usuarios();
                DataRow fj=dt.Rows[0];
                Us.Perfiles = new Entities.Perfiles();
                Us.Perfiles.ID = Utils.GetDataRowValue(fj, "IdPerfil", 0);
                Us.Nick = Usuario;
                Us.Opciones = new List<Entities.OpcionesPerfiles>();
                Data.OpcionesPerfiles Op = new OpcionesPerfiles();
                Us.Opciones = Op.Perfiles(Us.Perfiles.ID); 
            }
            return Us;
        }
    }
}
