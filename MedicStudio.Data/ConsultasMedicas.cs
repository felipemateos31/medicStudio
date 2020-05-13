using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class ConsultasMedicas : BaseDataObject
    {
        public List<Entities.ConsultasMedicas> Consultas(string Buscar)
        {
            List<Entities.ConsultasMedicas> list = new List<Entities.ConsultasMedicas>();
            DataEntities.SpConsultasMedicasGrd sp = new DataEntities.SpConsultasMedicasGrd();
            sp.Buscar = Buscar;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.ConsultasMedicas item = new Entities.ConsultasMedicas(true);
                item.IdMedico = Utils.GetDataRowValue(dr, "IdMedico", 0);
                item.NombreMedico = Utils.GetDataRowValue(dr, "NombreMedico", "");
                item.Area = Utils.GetDataRowValue(dr, "Area", "");
                item.IdPaciente = Utils.GetDataRowValue(dr, "IdPaciente", 0);
                item.NombrePaciente = Utils.GetDataRowValue(dr, "NombrePaciente", "");
                item.IdConsulta = Utils.GetDataRowValue(dr, "IdConsulta", 0);
                item.Fecha = Utils.GetDataRowValue(dr, "Fecha", DateTime.MinValue);

                list.Add(item);
            }

            return list;
        }
    }
}
