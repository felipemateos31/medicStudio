using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Medico
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        public int IdUsuario
        {
            get;
            set;
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (txtPass.Text != txtCPass.Text)
            {
                errorProvider1.SetError(txtCPass, "Su contraseña no cicide");
                valido = false;
            }
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "Capture su nombre de usuario");
                valido = false;
            }
            return valido;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            bool valido;
            Business.Usuarios Med = new Business.Usuarios();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.Usuarios M = new Entities.Usuarios(IdUsuario != 0);
                M.Perfiles = new Entities.Perfiles();
                M.ID = this.IdUsuario;
                M.Nick = txtUsuario.Text;
                M.Pass = txtPass.Text;
                M.Perfiles.ID = Framework.Utils.IsNull(cmbPerfiles.SelectedValue, 0);
                Med.Save(M);
                this.Close();
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Business.Usuarios nut = new Business.Usuarios();
            cmbPerfiles.DataSource = nut.ComborPerfiles();
            cmbPerfiles.DisplayMember = "NombrePerfil";
            cmbPerfiles.ValueMember = "ID";

        }

        public static int IdOpcion = 3;
      




    }
}
