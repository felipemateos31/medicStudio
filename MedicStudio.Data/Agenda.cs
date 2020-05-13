using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Agenda:BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpAgendaIns sp = new DataEntities.SpAgendaIns();
            Entities.Agenda item = entity as Entities.Agenda;
            sp.IdContacto = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApPaterno = item.ApPaterno;
            sp.ApMaterno= item.ApMaterno;
            sp.Telefeno1 = item.Telefeno1;
            sp.Telefeno2 = item.Telefeno2;
            sp.Email = item.Email;
            sp.Direccion = item.Direccion;
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
            DataEntities.SpAgendaUpd sp = new DataEntities.SpAgendaUpd();
            Entities.Agenda item = entity as Entities.Agenda;
            sp.IdContacto = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApPaterno = item.ApPaterno;
            sp.ApMaterno = item.ApMaterno;
            sp.Telefeno1 = item.Telefeno1;
            sp.Telefeno2 = item.Telefeno2;
            sp.Email = item.Email;
            sp.Direccion = item.Direccion;
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
            DataEntities.SpAgendaDel sp = new DataEntities.SpAgendaDel();
            Entities.Agenda item = entity as Entities.Agenda;
            sp.IdContacto = item.ID;

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
            Entities.Agenda item = entity as Entities.Agenda;
            DataEntities.SpAgendaSel sp = new DataEntities.SpAgendaSel();
            sp.IdContacto = item.ID;
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.ApPaterno = Utils.GetDataRowValue(dr, "ApPaterno", "");
                item.ApMaterno = Utils.GetDataRowValue(dr, "ApMaterno", "");
                item.Telefeno1 = Utils.GetDataRowValue(dr, "Telefeno1", "");
                item.Telefeno2 = Utils.GetDataRowValue(dr, "Telefeno2", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.Direccion = Utils.GetDataRowValue(dr, "Direccion", "");
            }
        }



        public List<Entities.Agenda> ListaAgenda(string Buscar)
        {
            List<Entities.Agenda> list = new List<Entities.Agenda>();
            DataEntities.SpAgendaGrd sp = new DataEntities.SpAgendaGrd();
            sp.Buscar = Buscar;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Agenda item = new Entities.Agenda(true);
                item.ID = Utils.GetDataRowValue(dr, "IdContacto", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.ApPaterno = Utils.GetDataRowValue(dr, "ApPaterno", "");
                item.ApMaterno = Utils.GetDataRowValue(dr, "ApMaterno", "");
                item.Telefeno1 = Utils.GetDataRowValue(dr, "Telefeno1", "");
                item.Telefeno2 = Utils.GetDataRowValue(dr, "Telefeno2", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.Direccion = Utils.GetDataRowValue(dr, "Direccion", "");

                list.Add(item);
            }

            return list;
        }

        public List<Entities.Agenda> Combo()
        {
            List<Entities.Agenda> list = new List<Entities.Agenda>();
            DataEntities.SpAgendaCmb sp = new DataEntities.SpAgendaCmb();
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Entities.Agenda item = new Entities.Agenda(true);
                    item.ID = Utils.GetDataRowValue(dr, "IdContacto", 0);
                    item.Nombre = Utils.GetDataRowValue(dr, "NombreCompleto", "");
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
