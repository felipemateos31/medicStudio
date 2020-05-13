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
    public partial class Psicologia : Form
    {
        public Psicologia()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhota.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Psicologia_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Business.Psicologia nut = new Business.Psicologia();
            cmbMedico.DataSource = nut.ComboM();
            cmbMedico.DisplayMember = "NombreCompleto";
            cmbMedico.ValueMember = "ID";

            cmbPaciente.DataSource = nut.ComboP();
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "ID";
        }

        public int IdConsultaPs
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
            Business.Psicologia Med = new Business.Psicologia();
            valido = ValidarDatos();

            if (valido == true)
            {
                Entities.Psicologia P = new Entities.Psicologia(IdConsultaPs != 0);
                P.Medico = new Entities.Medico();
                P.Paciente = new Entities.Paciente();
                P.ID = this.IdConsultaPs;
                P.Medico.ID = Framework.Utils.IsNull(cmbMedico.SelectedValue, 0);
                P.Paciente.ID = Framework.Utils.IsNull(cmbPaciente.SelectedValue, 0);
                P.Motivo = txtMotivo.Text;
                P.Antecedentes = txtAntecedentes.Text;
                P.RelacionFamiliar = txtRFam.Text;
                P.DescripcionCircAmigos = txtCir.Text;
                P.ActividadesIndividuales = txtAcSo.Text;
                P.ExpectativaTerapia = txtExpe.Text;
                P.Compromisos = txtCom.Text;
                P.Resultados = txtRes.Text;
                P.Recomendaciones = txtReco.Text;
                if (rbCasado.Checked)
                {
                    P.Casado = true;
                }
                if (rbSoltero.Checked)
                {
                    P.Soltero = true;
                }
                if (rbUnion.Checked)
                {
                    P.UnionLibre = true;
                }
                if (rbAl.Checked)
                {
                    P.Alcohol = true;
                }
                if (rbFuma.Checked)
                {
                    P.Fuma = true;
                }
                if (rbOtra.Checked)
                {
                    P.Sustancias = true;
                }
            
                Med.Save(P);
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
