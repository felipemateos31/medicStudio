using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.Business
{
    public class Usuarios : BaseBusinessObject
    {
         private Data.Usuarios Data
        {
            get { return this.DataObject as Data.Usuarios; }
        }

        public Usuarios()
        {
            this.DataObject = new Data.Usuarios();
        }
        public List<Entities.Perfiles> ComborPerfiles()
        {
            return this.Data.ComboPerfiles();
        }
    }
}
