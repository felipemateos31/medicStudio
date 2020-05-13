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
    public partial class RegistroPaciente : Form
    {
        public RegistroPaciente()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {

        }

        private void RegistroPaciente_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            LlenarComboBox();
        }
        //Llenar el grid en la ventana de registroPaciente.
            private void LlenarGrid()
            {
                string Consulta = "Select IdUsuario, Nombre + ' ' + ApPaterno + ' ' + isnull(ApMaterno,'') as NombreUsuario From Usuarios"; //where (nick = @cuenta or Email = @cuenta) and Password = @Pass";
                string CadenaConexion = "Server = ACADEM410\\UNE;Database=Login;Trusted_Connection=True;";
                DataTable Dt = new DataTable();
                SqlDataAdapter Adap = new SqlDataAdapter(Consulta, CadenaConexion);
                Adap.Fill(Dt);
            }
            private void LlenarComboBox()
            {
                string Consulta = "Select IdUsuario, Nombre + ' ' + ApPaterno + ' ' + isnull(ApMaterno,'') as NombreUsuario From Usuarios"; //where (nick = @cuenta or Email = @cuenta) and Password = @Pass";
                string CadenaConexion = "Server = ACADEM410\\UNE;Database=Login;Trusted_Connection=True;";
                DataTable Dt = new DataTable();
                SqlDataAdapter Adap = new SqlDataAdapter(Consulta, CadenaConexion);
                Adap.Fill(Dt);
                comboBox1.DataSource = Dt;
                comboBox1.ValueMember = "IdUsuario";
                comboBox1.DisplayMember = "Nombre";
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void groupBox3_Enter_1(object sender, EventArgs e)
            {

            }
        }
    }

