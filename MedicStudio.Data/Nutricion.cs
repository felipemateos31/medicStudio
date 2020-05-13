using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Nutricion : BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpNutricionIns sp = new DataEntities.SpNutricionIns();
            Entities.Nutricion item = entity as Entities.Nutricion;
            sp.IdConsultaNut = item.ID;
            sp.IdMedico = item.Medico.ID;
            sp.IdPaciente = item.Paciente.ID;
            sp.MotivoConsulta = item.MotivoConsulta;
            sp.ProblemasActuales = item.ProblemasActuales;
            sp.Peso = item.Peso;
            sp.Estatura = item.Estatura;
            sp.Talla = item.Talla;
            sp.IMC = item.IMC;
            sp.Pecho = item.Pecho;
            sp.Abdomen = item.Abdomen;
            sp.Cuello = item.Cuello;
            sp.Brazo = item.Brazo;
            sp.EnfermedadImp = item.EnfermedadImp;
            sp.InfoMedicamentos = item.InfoMedicamentos;
            sp.Cirugia = item.Cirugia;
            sp.TipoDeCirugia = item.TipoDeCirugia;
            sp.EnfermedadesCornicas = item.EnfermedadesCornicas;
            sp.ActividadFisica = item.ActividadFisica;
            sp.Observaciones = item.Observaciones;

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
            DataEntities.SpNutricionDel sp = new DataEntities.SpNutricionDel();
            Entities.Nutricion item = entity as Entities.Nutricion;
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

        public List<Entities.Medico> ComboMedico()
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
