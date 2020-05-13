using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Paciente : BaseBusinessObject
    {
         private Data.Paciente Data
        {
            get { return this.DataObject as Data.Paciente; }
        }

        public Paciente()
        {
            this.DataObject = new Data.Paciente();
        }

        public List<Entities.Paciente> ListaPaciente(string buscar)
        {
            return this.Data.ListaPaciente(buscar);
        }

        public List<Entities.Paciente> Combo()
        {
            return this.Data.Combo();
        }

        public string Delete(List<Entities.Paciente> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.Paciente item in lst)
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
