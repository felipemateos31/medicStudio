using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Agenda : BaseBusinessObject
    {
         private Data.Agenda Data
        {
            get { return this.DataObject as Data.Agenda; }
        }

        public Agenda()
        {
            this.DataObject = new Data.Agenda();
        }

        public List<Entities.Agenda> ListaAgenda (string buscar)
        {
            return this.Data.ListaAgenda(buscar);
        }

        public List<Entities.Agenda> Combo()
        {
            return this.Data.Combo();
        }

        public string Delete(List<Entities.Agenda> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.Agenda item in lst)
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
