using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Pacientes
{
    public partial class PacientesEdit : Form
    {
        public PacientesEdit()
        {
            InitializeComponent();
        }

        private void PacientesEdit_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public int IdPaciente
        {
            get;
            set;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Capture el usuario");
                valido = false;
            }
            if (txtApPaterno.Text == "")
            {
                errorProvider1.SetError(txtApPaterno, "Capture el apellido paterno");
                valido = false;
            }
            if (txtApMaterno.Text == "")
            {
                errorProvider1.SetError(txtApMaterno, "Capture el apellido paterno");
                valido = false;
            }
            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Capture el apellido paterno");
                valido = false;
            }
            if (txtTel.Text == "")
            {
                errorProvider1.SetError(txtTel, "Capture su correo");
                valido = false;
            }
            if (txtLugarNa.Text == "") 
            {
                errorProvider1.SetError(txtLugarNa, "Capture su correo");
                valido = false;
            }
            if (txtLugarR.Text=="")
            {
                errorProvider1.SetError(txtLugarR, "Capture su correo");
                valido = false;
            }
            if (txtOcupa.Text=="")
            {
                errorProvider1.SetError(txtOcupa, "Capture su correo");
                valido = false;
            }
            if (txtDirecion.Text=="")
            {
                errorProvider1.SetError(txtDirecion, "Capture su correo");
                valido = false;
            }
            if(cmbEsco.Text=="")
            {
                errorProvider1.SetError(cmbEsco, "Capture su correo");
                valido = false;
            }
            if (cmbEstadoCi.Text=="")
            {
                errorProvider1.SetError(cmbEstadoCi, "Capture su correo");
                valido = false;
            }
            
            return valido;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            bool valido;
            Business.Paciente Med = new Business.Paciente();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.Paciente P = new Entities.Paciente(IdPaciente != 0);
                P.ID = this.IdPaciente;
                P.Nombre = txtNombre.Text;
                P.ApellidoP = txtApPaterno.Text;
                P.ApellidoM = txtApMaterno.Text;
                P.Edad = int.Parse(txtEdad.Text);
                P.FechaNac = dateTimePicker1.Value;
                P.LugardeNacimiento = txtLugarNa.Text;
                P.LugardeResidencia = txtLugarR.Text;
                P.Escolaridad = cmbEsco.Text;
                P.EstadoCiv = cmbEstadoCi.Text;
                P.Ocupacion = txtOcupa.Text;
                P.Direccion = txtDirecion.Text;
                P.Telefono = txtTel.Text;
                P.Email = txtCorreo.Text;
                Med.Save(P);
                this.Close();
            }
        }
        private void CargarDatos()
        {
            if (IdPaciente != 0)
            {
                Entities.Paciente Med = new Entities.Paciente(true);
                Med.ID = this.IdPaciente;
                Business.Paciente bo = new Business.Paciente();
                bo.PrepareEntityForEdition(Med);
                this.txtNombre.Text = Med.Nombre;
                this.txtApPaterno.Text = Med.ApellidoP;
                this.txtApMaterno.Text = Med.ApellidoM;
                this.txtEdad.Text = Med.Edad.ToString();
                this.dateTimePicker1.Value = Med.FechaNac;
                this.txtLugarNa.Text = Med.LugardeNacimiento;
                this.txtLugarR.Text = Med.LugardeResidencia;
                this.cmbEsco.SelectedText = Med.Escolaridad;
                this.cmbEstadoCi.SelectedText = Med.EstadoCiv;
                this.txtOcupa.Text = Med.Ocupacion;
                this.txtDirecion.Text = Med.Direccion;
                this.txtTel.Text = Med.Telefono;
                this.txtCorreo.Text = Med.Email;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
