using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Nutricion :BaseBusinessObject
    {
        private Data.Nutricion Data
        {
            get { return this.DataObject as Data.Nutricion; }
        }

        public Nutricion()
        {
            this.DataObject = new Data.Nutricion();
        }

        public List<Entities.Medico> ComboM()
        {
            return this.Data.ComboMedico();
        }
        public List<Entities.Paciente> ComboP()
        {
            return this.Data.ComboPaciente();
        }
        public string Delete(List<Entities.Nutricion> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.Nutricion item in lst)
                {
                    //string tmp = this.Data.Delete(item);
                    //if (tmp != string.Empty)
                    //{
                    //    response += string.Format("</p>{0}</p>", tmp);

                    this.Data.Delete(item);
                }
                response = "";
            }
            catch (Exception ex)
            {

                response = ex.Message;
            }
            return response;
        }
    }
}
