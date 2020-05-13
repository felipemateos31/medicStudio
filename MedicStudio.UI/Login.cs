using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MedicStudio.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool UserValido
        {
            get;
            set;
        }
       public Entities.Usuarios Us
        {
            get;
            set;
        }
        private void btnAcept_Click(object sender, EventArgs e)
        {
            Business.ValidarAcceso br = new Business.ValidarAcceso();
            Us=br.Validar(txtUsuario.Text, TxtContra.Text);
            if (Us!=null)
            {
                UserValido = true;
                this.Close();
            }
            else
            {
                label3.Text = "Datos incorrectos";
            }
        }
    }
}
