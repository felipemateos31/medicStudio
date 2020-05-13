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
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PacientesEdit frm = new PacientesEdit();
            frm.ShowDialog();
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LLenarGrid();
        }
        public  static int IdOpcion = 5;
        
        private void LLenarGrid()
        {
            Business.Paciente bo = new Business.Paciente();
            this.dataGridView1.DataSource = bo.ListaPaciente(txtBuscar.Text);
        }

        private Entities.Paciente Obtener()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object fila = dataGridView1.SelectedRows[0].DataBoundItem;
                return fila as Entities.Paciente;
            }

            return null;
        }
        private void Eliminar()
        {

            Entities.Paciente Med = Obtener();
            Business.Paciente bo = new Business.Paciente();
            if (Med != null)
            {
                DialogResult mnsj = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "", MessageBoxButtons.YesNo);
                if (mnsj == DialogResult.Yes)
                {
                    bo.Delete(Med);
                    LLenarGrid();
                }

            }

        }

        private void Editar()
        {
            Entities.Paciente Med = Obtener();

            if (Med != null)
            {
                PacientesEdit New = new PacientesEdit();
                New.IdPaciente = Med.ID;
                New.ShowDialog();
                LLenarGrid();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            LLenarGrid();
        }
    }
}
