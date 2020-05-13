using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class MedicinaGeneral : BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpMedicinaGeneralIns sp = new DataEntities.SpMedicinaGeneralIns();
            Entities.MedicinaGeneral item = entity as Entities.MedicinaGeneral;
            sp.IdConsultaMG = item.ID;
            sp.IdMedico = item.Medico.ID;
            sp.IdPaciente = item.Paciente.ID;
            sp.MotivoConsulta = item.MotivoConsulta;
            sp.ProblemasActuales = item.ProblemasActuales;
            sp.Medicamentos = item.Medicamentos;
            sp.Observaciones = item.Observaciones;
            sp.EnfermedadesCronicas = item.EnfermedadesCronicas;
            sp.EnfermedadesImportantes = item.EnfermedadesImportantes;
            sp.Diagnstico = item.Diagnstico;
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
            DataEntities.SpMedicinaGeneralDel sp = new DataEntities.SpMedicinaGeneralDel();
            Entities.MedicinaGeneral item = entity as Entities.MedicinaGeneral;
            sp.IdConsultaMG = item.ID;

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

        public List<Entities.Medico> ComboGrlMed()
        {
            List<Entities.Medico> list = new List<Entities.Medico>();
            DataEntities.MedicoGrl sp = new DataEntities.MedicoGrl();
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

        public List<Entities.Paciente> ComboPaciente()
        {
            List<Entities.Paciente> list = new List<Entities.Paciente>();
            DataEntities.SpPacienteCmb sp = new DataEntities.SpPacienteCmb();
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Entities.Paciente item = new Entities.Paciente(true);
                    item.ID = Utils.GetDataRowValue(dr, "IdPaciente", 0);
                    item.NombreCompleto = Utils.GetDataRowValue(dr, "NombreCompleto", "");
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
