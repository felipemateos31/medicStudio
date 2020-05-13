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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }


        public static int IdOpcion = 6;
        

        private void Citas_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = false;
            LLenarGrid();
        }
        private void LLenarGrid()
        {
            Business.ConsultasMedicas bo = new Business.ConsultasMedicas();
            this.dataGridView1.DataSource = bo.ListaConsulta(txtBuscar.Text);
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            string buscar = "";
            this.errorProvider1.Clear();

            try
            {
                buscar = txtBuscar.Text;
            }
            catch
            {
                this.errorProvider1.SetError(this.txtBuscar, "No has introducido ningun dato");
                ok = false;
            }
            return ok;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            bool ok = this.ValidarDatos();
            if (ok)
            {
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "Archivos de Excel (*.xlsx)|.xlsx";
                DialogResult dlg = file.ShowDialog();
                if (dlg == System.Windows.Forms.DialogResult.OK)
                {
                    String buscar = this.txtBuscar.Text;
                    Business.ConsultasMedicas bo = new Business.ConsultasMedicas();
                    bo.Exportar(buscar, file.FileName);
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            LLenarGrid();
        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
