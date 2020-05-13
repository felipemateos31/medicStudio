using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace MedicStudio.DataEntities
{
    public class MedicoGrl: StoredProcedure
    {
        public MedicoGrl()
            : base("SpMedicoGrl")
        {

        }
    }
}
