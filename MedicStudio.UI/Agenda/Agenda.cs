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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgendaEdit Ag = new AgendaEdit();
            Ag.ShowDialog();
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LLenarGrid();
        }
        public static int IdOpcion = 4;
      
        private void Agenda_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = false;
            LLenarGrid();
        }
        private void LLenarGrid()
        {
            Business.Agenda bo = new Business.Agenda();
            this.dataGridView1.DataSource = bo.ListaAgenda(txtBuscar.Text);
        }
        private Entities.Agenda Obtener()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object fila = dataGridView1.SelectedRows[0].DataBoundItem;
                return fila as Entities.Agenda;
            }

            return null;
        }
        private void Eliminar()
        {
            Entities.Agenda Med = Obtener();
            Business.Agenda bo = new Business.Agenda();
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
            Entities.Agenda Med = Obtener();

            if (Med != null)
            {
                AgendaEdit New = new AgendaEdit();
                New.IdContacto = Med.ID;
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
