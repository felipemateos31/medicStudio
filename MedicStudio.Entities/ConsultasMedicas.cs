using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Entities
{
    public class ConsultasMedicas:Entity 
    {
        private int _idMedico;
        private string _nombreMedico;
        private string _area;
        private int _idPaciente;
        private string _NombrePaciente;
        private int _idConsulta;
        private DateTime _fecha;

        public int IdMedico
        {
            get { return this._idMedico; }
            set { this._idMedico = value; }
        }
        public string NombreMedico
        {
            get { return this._nombreMedico; }
            set { this._nombreMedico = value; }
        }
        public string Area
        {
            get { return this._area; }
            set { this._area = value; }
        }
       public int IdPaciente
        {
            get { return this._idPaciente; }
            set { this._idPaciente = value; }
        }
       public string NombrePaciente
       {
           get { return this._NombrePaciente; }
           set { this._NombrePaciente = value; }
       }

       public int IdConsulta
       {
           get { return this._idConsulta; }
           set { this._idConsulta = value; }
       }
       public DateTime Fecha
       {
           get { return this._fecha; }
           set { this._fecha = value; }
       }
        public ConsultasMedicas():this(false)
        {
        }

        public ConsultasMedicas(bool fromDataSource): base(fromDataSource)
        {
        }

    }
}
