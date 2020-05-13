using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Citas
{
    public partial class MedicinaGrl : Form
    {
        public MedicinaGrl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void MedicinaGrl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Business.MedicinaGeneral Med = new Business.MedicinaGeneral();
            cmbMedico.DataSource = Med.ComboM();
            cmbMedico.DisplayMember = "NombreCompleto";
            cmbMedico.ValueMember = "ID";

            cmbPaciente.DataSource = Med.ComboP();
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "ID";
        }

        public int IdConsultaGrl
        {
            get;
            set;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (txtMotivo.Text == "")
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
            Business.MedicinaGeneral Med = new Business.MedicinaGeneral();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.MedicinaGeneral M = new Entities.MedicinaGeneral(IdConsultaGrl != 0);
                M.Medico = new Entities.Medico();
                M.Paciente = new Entities.Paciente();
                M.ID = this.IdConsultaGrl;
                M.Medico.ID = Framework.Utils.IsNull(cmbMedico.SelectedValue, 0);
                M.Paciente.ID = Framework.Utils.IsNull(cmbPaciente.SelectedValue, 0);
                M.MotivoConsulta = txtMotivo.Text;
                M.ProblemasActuales = txtProblemas.Text;
                M.Medicamentos = txtMed.Text;
                M.Observaciones = txtObs.Text;
                M.EnfermedadesCronicas = txtEC.Text;
                M.EnfermedadesImportantes = txtEI.Text;
                M.Diagnstico = txtDiag.Text;
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


    }
}
