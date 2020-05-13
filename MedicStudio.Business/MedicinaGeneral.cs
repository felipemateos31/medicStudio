using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class MedicinaGeneral : BaseBusinessObject
    {
        private Data.MedicinaGeneral Data
        {
            get { return this.DataObject as Data.MedicinaGeneral; }
        }

        public MedicinaGeneral()
        {
            this.DataObject = new Data.MedicinaGeneral();
        }

        public List<Entities.Medico> ComboM()
        {
            return this.Data.ComboGrlMed();
        }
        public List<Entities.Paciente> ComboP()
        {
            return this.Data.ComboPaciente();
        }
        public string Delete(List<Entities.MedicinaGeneral> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.MedicinaGeneral item in lst)
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
