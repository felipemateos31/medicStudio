using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace MedicStudio.Data
{
    public class Paciente:BaseDataObject
    {
        public override int Insert(Entity entity, DataTransaction tran)
        {
            DataEntities.SpPacienteIns sp = new DataEntities.SpPacienteIns();
            Entities.Paciente item = entity as Entities.Paciente;
            sp.IdPaciente = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApellidoP = item.ApellidoP;
            sp.ApellidoM = item.ApellidoM;
            sp.Edad = item.Edad;
            sp.FechaNac = item.FechaNac;
            sp.LugardeNacimiento = item.LugardeNacimiento;
            sp.LugardeResidencia = item.LugardeResidencia;
            sp.EstadoCiv = item.EstadoCiv;
            sp.Escolaridad = item.Escolaridad;
            sp.Ocupacion = item.Ocupacion;
            sp.Direccion = item.Direccion;
            sp.Telefono = item.Telefono;
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
            DataEntities.SpPacienteUpd sp = new DataEntities.SpPacienteUpd();
            Entities.Paciente item = entity as Entities.Paciente;
            sp.IdPaciente = item.ID;
            sp.Nombre = item.Nombre;
            sp.ApellidoP = item.ApellidoP;
            sp.ApellidoM = item.ApellidoM;
            sp.Edad = item.Edad;
            sp.FechaNac = item.FechaNac;
            sp.LugardeNacimiento = item.LugardeNacimiento;
            sp.LugardeResidencia = item.LugardeResidencia;
            sp.EstadoCiv = item.EstadoCiv;
            sp.Escolaridad = item.Escolaridad;
            sp.Ocupacion = item.Ocupacion;
            sp.Direccion = item.Direccion;
            sp.Telefono = item.Telefono;
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
            DataEntities.SpPacienteDel sp = new DataEntities.SpPacienteDel();
            Entities.Paciente item = entity as Entities.Paciente;
            sp.IdPaciente = item.ID;

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
            Entities.Paciente item = entity as Entities.Paciente;
            DataEntities.SpPacienteSel sp = new DataEntities.SpPacienteSel();
            sp.IdPaciente = item.ID;
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.ApellidoP = Utils.GetDataRowValue(dr, "ApellidoP", "");
                item.ApellidoM = Utils.GetDataRowValue(dr, "ApellidoM", "");
                item.Edad = Utils.GetDataRowValue(dr, "Edad", 0);
                item.FechaNac = Utils.GetDataRowValue(dr, "FechaNac", DateTime.MinValue);
                item.LugardeNacimiento = Utils.GetDataRowValue(dr, "LugardeNacimiento", "");
                item.LugardeResidencia = Utils.GetDataRowValue(dr, "LugardeResidencia", "");
                item.EstadoCiv = Utils.GetDataRowValue(dr, "EstadoCiv", "");
                item.Escolaridad = Utils.GetDataRowValue(dr, "Escolaridad", "");
                item.Ocupacion = Utils.GetDataRowValue(dr, "Ocupacion", "");
                item.Direccion = Utils.GetDataRowValue(dr, "Direccion", "");
                item.Telefono = Utils.GetDataRowValue(dr, "Telefono", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
            }
        }



        public List<Entities.Paciente> ListaPaciente(string Buscar)
        {
            List<Entities.Paciente> list = new List<Entities.Paciente>();
            DataEntities.SpPacienteGrd sp = new DataEntities.SpPacienteGrd();
            sp.Buscar = Buscar;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Paciente item = new Entities.Paciente(true);
                item.ID = Utils.GetDataRowValue(dr, "IdPaciente", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.ApellidoP = Utils.GetDataRowValue(dr, "ApellidoP", "");
                item.ApellidoM = Utils.GetDataRowValue(dr, "ApellidoM", "");
                item.Edad = Utils.GetDataRowValue(dr, "Edad", 0);
                item.FechaNac = Utils.GetDataRowValue(dr, "FechaNac", DateTime.MinValue);
                item.LugardeNacimiento = Utils.GetDataRowValue(dr, "LugardeNacimiento", "");
                item.LugardeResidencia = Utils.GetDataRowValue(dr, "LugardeResidencia", "");
                item.EstadoCiv = Utils.GetDataRowValue(dr, "EstadoCiv", "");
                item.Escolaridad = Utils.GetDataRowValue(dr, "Escolaridad", "");
                item.Ocupacion = Utils.GetDataRowValue(dr, "Ocupacion", "");
                item.Direccion = Utils.GetDataRowValue(dr, "Direccion", "");
                item.Telefono = Utils.GetDataRowValue(dr, "Telefono", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");

                list.Add(item);
            }

            return list;
        }

        public List<Entities.Paciente> Combo()
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
