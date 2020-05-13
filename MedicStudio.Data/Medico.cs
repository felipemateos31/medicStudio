using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Medico:BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpMedicoIns sp = new DataEntities.SpMedicoIns();
            Entities.Medico item = entity as Entities.Medico;
            sp.IdMedico = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApellidoP = item.ApellidoP;
            sp.ApellidoM = item.ApellidoM;
            sp.Edad = item.Edad;
            sp.FechaNac = item.FechaNac;
            sp.EstadoCiv = item.EstadoCiv;
            sp.Area = item.Area;
            sp.Telefono1 = item.Telefono1;
            sp.Telefono2 = item.Telefono2;
            sp.Email = item.Email;

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
            DataEntities.SpMedicoUpd sp = new DataEntities.SpMedicoUpd();
            Entities.Medico item = entity as Entities.Medico;
            sp.IdMedico = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApellidoP = item.ApellidoP;
            sp.ApellidoM = item.ApellidoM;
            sp.Edad = item.Edad;
            sp.FechaNac = item.FechaNac;
            sp.EstadoCiv = item.EstadoCiv;
            sp.Area = item.Area;
            sp.Telefono1 = item.Telefono1;
            sp.Telefono2 = item.Telefono2;
            sp.Email = item.Email;

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

        public override int Delete(Entity entity, DataTransaction tran)
        {
            DataEntities.SpMedicoDel sp = new DataEntities.SpMedicoDel();
            Entities.Medico item = entity as Entities.Medico;
            sp.IdMedico = item.ID;

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


        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Medico item = entity as Entities.Medico;
            DataEntities.SpMedicoSel sp = new DataEntities.SpMedicoSel();
            sp.IdMedico = item.ID;
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.ApellidoP = Utils.GetDataRowValue(dr, "ApellidoP", "");
                item.ApellidoM = Utils.GetDataRowValue(dr, "ApellidoM", "");
                item.Edad = Utils.GetDataRowValue(dr, "Edad", 0);
                item.FechaNac = Utils.GetDataRowValue(dr, "FechaNac", DateTime.MinValue);
                item.EstadoCiv = Utils.GetDataRowValue(dr, "EstadoCiv", "");
                item.Area = Utils.GetDataRowValue(dr, "Area", "");
                item.Telefono1 = Utils.GetDataRowValue(dr, "Telefono1", "");
                item.Telefono2 = Utils.GetDataRowValue(dr, "Telefono2", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");

            }
        }



        public List<Entities.Medico> LsitaMedico(string Buscar)
        {
            List<Entities.Medico> list = new List<Entities.Medico>();
            DataEntities.SpMedicoGrd sp = new DataEntities.SpMedicoGrd();
            sp.Buscar = Buscar;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                    Entities.Medico item = new Entities.Medico(true);
                    item.ID = Utils.GetDataRowValue(dr, "IdMedico", 0);
                    item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                    item.ApellidoP = Utils.GetDataRowValue(dr, "ApellidoP", "");
                    item.ApellidoM = Utils.GetDataRowValue(dr, "ApellidoM", "");
                    item.Edad = Utils.GetDataRowValue(dr, "Edad", 0);
                    item.FechaNac = Utils.GetDataRowValue(dr, "FechaNac", DateTime.MinValue);
                    item.EstadoCiv = Utils.GetDataRowValue(dr, "EstadoCiv", "");
                    item.Area = Utils.GetDataRowValue(dr, "Area", "");
                    item.Telefono1 = Utils.GetDataRowValue(dr, "Telefono1", "");
                    item.Telefono2 = Utils.GetDataRowValue(dr, "Telefono2", "");
                    item.Email = Utils.GetDataRowValue(dr, "Email", "");


                list.Add(item);
            }

            return list;
        }

        public List<Entities.Medico> Combo()
        {
            List<Entities.Medico> list = new List<Entities.Medico>();
            DataEntities.SpMedicoCmb sp = new DataEntities.SpMedicoCmb();
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Entities.Medico item = new Entities.Medico(true);
                    item.ID = Utils.GetDataRowValue(dr, "IdMedico", 0);
                    item.NombreCompleto = Utils.GetDataRowValue(dr, "NombreCompleto", "");
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
