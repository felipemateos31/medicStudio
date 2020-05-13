using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Nutricion
{
    public partial class Nutricion : Form
    {
        public Nutricion()
        {
            InitializeComponent();
        }

        private void Nutricion_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Business.Nutricion nut = new Business.Nutricion();
            cmbMedico.DataSource = nut.ComboM();
            cmbMedico.DisplayMember = "NombreCompleto";
            cmbMedico.ValueMember = "ID";

            cmbPaciente.DataSource = nut.ComboP();
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "ID";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm");
        }

        public int IdConsultaNut
        {
            get;
            set;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (txtMotivo.Text=="")
            {
                errorProvider1.SetError(txtMotivo, "Su contraseña no cicide");
                valido = false;
            }
            return valido;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            bool valido;
            Business.Nutricion Med = new Business.Nutricion();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.Nutricion N = new Entities.Nutricion(IdConsultaNut != 0);
                N.Medico = new Entities.Medico();
                N.Paciente = new Entities.Paciente();
                N.ID = this.IdConsultaNut;
                N.Medico.ID = Framework.Utils.IsNull(cmbMedico.SelectedValue,0);
                N.Paciente.ID = Framework.Utils.IsNull(cmbPaciente.SelectedValue,0);
                N.MotivoConsulta = txtMotivo.Text;
                N.ProblemasActuales = txtProblemas.Text;
                N.Peso = txtPeso.Text;
                N.Estatura = txtEstatura.Text;
                N.Talla = txtTalla.Text;
                N.IMC = txtIMC.Text;
                N.Pecho = txtPecho.Text;
                N.Brazo = txtBrazo.Text;
                N.Abdomen = txtAbd.Text;
                N.Cuello = txtCuello.Text;
                N.EnfermedadImp = txtEI.Text;
                N.InfoMedicamentos = txtMed.Text;
                if (rbsi.Checked)
                {
                    N.Cirugia = true;
                }
                else if(rbno.Checked)
                {
                    N.Cirugia = false;
                }
                N.TipoDeCirugia = txtTipoC.Text;
                N.EnfermedadesCornicas = txtEC.Text;
                N.ActividadFisica = txtActFis.Text;
                N.Observaciones = txtObs.Text;
                Med.Save(N);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
