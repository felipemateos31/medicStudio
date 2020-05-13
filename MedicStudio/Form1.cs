using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicStudio.UI.Pacientes;
using MedicStudio.UI.Empleados;
using MedicStudio.UI.Agenda;
using MedicStudio.UI;
using MedicStudio.UI.Nutricion;
using MedicStudio.UI.Citas;


namespace MedicStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Entities.Usuarios Us
        {
            get;
            set;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados Emp = new Empleados();
            Emp.Show();

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes Pacientes = new Pacientes();
            Pacientes.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Agenda Ag = new Agenda();
            Ag.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            if (!lg.UserValido)
            {
                this.Close();
            }
            else
            {
                this.Us = lg.Us;
                this.btnEmpleados.Enabled = this.ObtenerPermisos(UI.Empleados.Empleados.IdOpcion).Acceso;
                this.btnCitas.Enabled = this.ObtenerPermisos(UI.Citas.MenuCitas.IdOpcion).Acceso;
                this.btnUsuarios.Enabled = this.ObtenerPermisos(UI.Medico.Usuarios.IdOpcion).Acceso;
                this.btnAgenda.Enabled = this.ObtenerPermisos(UI.Agenda.Agenda.IdOpcion).Acceso;
                this.btnPacientes.Enabled = this.ObtenerPermisos(UI.Pacientes.Pacientes.IdOpcion).Acceso;
                this.button7.Enabled = this.ObtenerPermisos(UI.Citas.Citas.IdOpcion).Acceso;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            if (lg.UserValido)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            MenuCitas mc = new MenuCitas();
            mc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Citas c = new Citas();
            c.Show();
        }

        private Entities.OpcionesPerfiles ObtenerPermisos(int IdOpcion)
        {
            Entities.OpcionesPerfiles entity=this.Us.Opciones.Where(p=>p.Opciones.ID==IdOpcion).FirstOrDefault();
            return entity != null ? entity : new Entities.OpcionesPerfiles(); 
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UI.Medico.Usuarios U= new UI.Medico.Usuarios();
            U.Show();

        }
        
    }
}
