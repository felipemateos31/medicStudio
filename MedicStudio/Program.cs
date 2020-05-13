using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MedicStudio.UI.Empleados;
using MedicStudio.UI.Pacientes;
using MedicStudio.UI.Agenda;
using MedicStudio.UI;
using MedicStudio.UI.Citas;
using MedicStudio.UI.Nutricion;
using MedicStudio.UI.Medico;

namespace MedicStudio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pacientes());
        }
    }
}
