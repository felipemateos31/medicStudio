using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Empleados
{
    public partial class EmpleadosEdit : Form
    {
        public EmpleadosEdit()
        {
            InitializeComponent();
        }

        public int IdMedico
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
            if (txtTel2.Text == "")
            {
                errorProvider1.SetError(txtTel2, "Capture su correo");
                valido = false;
            }

            return valido;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            bool valido;
            Business.Medico Med = new Business.Medico();
            valido = ValidarDatos();
            
            if (valido == true)
            {
                Entities.Medico M = new Entities.Medico(IdMedico != 0);
                M.ID = this.IdMedico;
                M.Nombre = txtNombre.Text;
                M.ApellidoP = txtApPaterno.Text;
                M.ApellidoM = txtApMaterno.Text;
                M.Edad = int.Parse(txtEdad.Text);
                M.EstadoCiv = cmbEstado.Text;
                M.Area = cmbArea.Text;
                M.Telefono1 = txtTel.Text;
                M.Telefono2 = txtTel2.Text;
                M.Email = txtCorreo.Text;
                M.FechaNac = dateTimePicker1.Value;
                Med.Save(M);
                this.Close();
            }
        }

        private void CargarDatos()
        {
            if (IdMedico != 0)
            {
                Entities.Medico Med = new Entities.Medico(true);
                Med.ID = this.IdMedico;
                Business.Medico bo = new Business.Medico();
                bo.PrepareEntityForEdition(Med);
                this.txtNombre.Text = Med.Nombre;
                this.txtApPaterno.Text = Med.ApellidoP;
                this.txtApMaterno.Text = Med.ApellidoM;
                this.txtEdad.Text = Med.Edad.ToString();
                this.txtTel.Text = Med.Telefono1;
                this.txtTel2.Text = Med.Telefono2;
                this.txtCorreo.Text = Med.Email;
                this.cmbArea.SelectedText = Med.Area;
                this.cmbEstado.SelectedText=Med.EstadoCiv;
            }
        }

        private void EmpleadosEdit_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            CargarDatos();
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
