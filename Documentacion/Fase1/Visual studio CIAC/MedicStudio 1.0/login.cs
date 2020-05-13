using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicStudio_1._0
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Lbl_ErrorName.ResetText();
            Lbl_ErrorPass.ResetText();

            if (Txt_User.Text == "" || Txt_Pass.Text == "")
            {
                //Verifica que los textbox no esten vacio.
                if (Txt_User.Text == "" && Txt_Pass.Text == "")
                { Lbl_ErrorName.Text = "Este campo no puede estar vacio"; Lbl_ErrorPass.Text = "Este campo no puede estar vacio"; }

                else //Verifica que el textbox para el usuario no este vacio.
                {
                    if (Txt_User.Text == "") { Lbl_ErrorName.Text = "Este campo no puede estar vacio"; }

                    else //Verifica que el textbox para la contraseña no este vacio.
                    { Lbl_ErrorPass.Text = "Este campo no puede estar vacio"; }
                }
            }
            else //Si no estan vacios verifica que la informacion sea la correcta.
            {
                string Consulta = "Select IdUsuario, Nombre + ' ' + ApPaterno + ' ' + isnull(ApMaterno,'') as NombreUsuario From Usuarios where (nick = @cuenta or Email = @cuenta) and Password = @Pass";
                string CadenaConexion = "Server = ACADEM410\\UNE;Database=Login;Trusted_Connection=True;";
                DataTable Dt = new DataTable();
                SqlDataAdapter Adap = new SqlDataAdapter(Consulta, CadenaConexion);
                Adap.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.VarChar, 50);
                Adap.SelectCommand.Parameters.Add("@Pass", SqlDbType.VarChar, 100);
                Adap.SelectCommand.Parameters["@Cuenta"].Value = Txt_User.Text;
                Adap.SelectCommand.Parameters["@Pass"].Value = Txt_Pass.Text;
                Adap.Fill(Dt);

                if (Dt.Rows.Count == 0)
                {
                    //Mostrar mensaje de usuario o contraseña incorrecto.
                    Lbl_ErrorName.Text = "Introduzca un Usuario o Email Valido";
                    Lbl_ErrorPass.Text = "Introduzca una Contraseña Valida";
                }
                else if (Dt.Rows.Count == 1)
                {
                    //Entrar a la aplicacion.
                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                    RegistroPaciente ver = new RegistroPaciente();
                    ver.Show();
                    this.Hide();
                }
                else
                {
                    //No entrar a la App y mostrar error de usuario duplicado.
                    MessageBox.Show("Usuario Duplicado");
                }
            }
        }

        private void Txt_User_Enter(object sender, EventArgs e)
        {
            Txt_User.ResetText();
            Lbl_ErrorName.ResetText();
        }

        private void Txt_Pass_Enter(object sender, EventArgs e)
        {
            Lbl_ErrorPass.ResetText();
            Txt_Pass.ResetText();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
