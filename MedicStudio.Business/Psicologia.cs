using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Psicologia : BaseBusinessObject
    {
        private Data.Psicologia Data
        {
            get { return this.DataObject as Data.Psicologia; }
        }

        public Psicologia()
        {
            this.DataObject = new Data.Psicologia();
        }

        public List<Entities.Medico> ComboM()
        {
            return this.Data.ComboPsMed();
        }
        public List<Entities.Paciente> ComboP()
        {
            return this.Data.ComboPaciente();
        }
        public string Delete(List<Entities.Psicologia> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.Psicologia item in lst)
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
