using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class ValidarAcceso : BaseBusinessObject
    {
         private Data.Acceso Data
        {
            get { return this.DataObject as Data.Acceso; }
        }

         public ValidarAcceso()
        {
            this.DataObject = new Data.Acceso();
        }

        public Entities.Usuarios Validar(string Usuario,string Pass)
        {
            return this.Data.ValidarAcceso(Usuario,Pass);
        }
    }
}
