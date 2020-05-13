﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio.UI.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmpleadosEdit New = new EmpleadosEdit();
            New.ShowDialog();
            LLenarGrid();
        }

        public static int IdOpcion = 1;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LLenarGrid();
        }

        private void LLenarGrid()
        {
            Business.Medico bo = new Business.Medico();
            this.dataGridView1.DataSource = bo.ListaMedico(txtBuscar.Text);
        }


        private Entities.Medico ObtenerEmpleadoSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object fila = dataGridView1.SelectedRows[0].DataBoundItem;
                return fila as Entities.Medico;
            }

            return null;
        }
        private void EliminarEmpleado()
        {

            Entities.Medico Med = ObtenerEmpleadoSeleccionado();
            Business.Medico bo = new Business.Medico();
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
             Entities.Medico Med = ObtenerEmpleadoSeleccionado();

             if (Med != null)
             {
                 EmpleadosEdit New = new EmpleadosEdit();
                 New.IdMedico = Med.ID;
                 New.ShowDialog();
                 LLenarGrid();
             }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
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
