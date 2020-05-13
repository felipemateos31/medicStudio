using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Psicologia : BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpPsicologiaIns sp = new DataEntities.SpPsicologiaIns();
            Entities.Psicologia item = entity as Entities.Psicologia;
            sp.IdConsultaPs = item.ID;
            sp.IdMedico = item.Medico.ID;
            sp.IdPaciente = item.Paciente.ID;
            sp.Motivo=item.Motivo;
            sp.Antecedentes=item.Antecedentes;
            sp.RelacionFamiliar=item.RelacionFamiliar;
            sp.DescripcionCircAmigos=item.DescripcionCircAmigos;
            sp.ActividadesIndividuales=item.ActividadesIndividuales;
            sp.Casado=item.Casado;
            sp.UnionLibre=item.UnionLibre;
            sp.Soltero=item.Soltero;
            sp.Alcohol=item.Alcohol;
            sp.Fuma=item.Fuma;
            sp.Sustancias=item.Sustancias;
            sp.ExpectativaTerapia=item.ExpectativaTerapia;
            sp.Compromisos=item.Compromisos;
            sp.Resultados=item.Resultados;
            sp.Recomendaciones=item.Recomendaciones;
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
            DataEntities.SpPsicologiaDel sp = new DataEntities.SpPsicologiaDel();
            Entities.Psicologia item = entity as Entities.Psicologia;
            sp.IdConsulta = item.ID;

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

        public List<Entities.Medico> ComboPsMed()
        {
            List<Entities.Medico> list = new List<Entities.Medico>();
            DataEntities.SpMedicoPs sp = new DataEntities.SpMedicoPs();
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
