using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Agenda
{
    public partial class AgendaEdit : Form
    {
        public AgendaEdit()
        {
            InitializeComponent();
        }

        public int IdContacto
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
            if (txtDirecion.Text == "") 
            {
                errorProvider1.SetError(txtDirecion, "Capture el apellido paterno");
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
            Business.Agenda Med = new Business.Agenda();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.Agenda M = new Entities.Agenda(IdContacto != 0);
                M.ID = this.IdContacto;
                M.Nombre = txtNombre.Text;
                M.ApPaterno = txtApPaterno.Text;
                M.ApMaterno = txtApMaterno.Text;
                M.Telefeno1 = txtTel.Text;
                M.Telefeno2 = txtTel2.Text;
                M.Email = txtCorreo.Text;
                M.Direccion = txtDirecion.Text;
                Med.Save(M);
                this.Close();
            }
        }
        private void CargarDatos()
        {
            if (IdContacto != 0)
            {
                Entities.Agenda Med = new Entities.Agenda(true);
                Med.ID = this.IdContacto;
                Business.Agenda bo = new Business.Agenda();
                bo.PrepareEntityForEdition(Med);
                this.txtNombre.Text = Med.Nombre;
                this.txtApPaterno.Text = Med.ApPaterno;
                this.txtApMaterno.Text = Med.ApMaterno;
                this.txtTel.Text = Med.Telefeno1;
                this.txtTel2.Text = Med.Telefeno2;
                this.txtCorreo.Text = Med.Email;
                this.txtDirecion.Text = Med.Direccion;
            }
        }

        private void AgendaEdit_Load(object sender, EventArgs e)
        {
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
