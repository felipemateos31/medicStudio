using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Medico:BaseBusinessObject
    {
         private Data.Medico Data
        {
            get { return this.DataObject as Data.Medico; }
        }

        public Medico()
        {
            this.DataObject = new Data.Medico();
        }

        public List<Entities.Medico> ListaMedico (string buscar)
        {
            return this.Data.LsitaMedico(buscar);
        }

        public List<Entities.Medico> Combo()
        {
            return this.Data.Combo();
        }

        public string Delete(List<Entities.Medico> lst)
        {
            string response = string.Empty;
            try
            {
                foreach (Entities.Medico item in lst)
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
