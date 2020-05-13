using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicStudio.UI.Citas;
using MedicStudio.UI.Nutricion;
using MedicStudio;

namespace MedicStudio.UI.Citas
{
    public partial class MenuCitas : Form
    {
        public MenuCitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicinaGrl mG = new MedicinaGrl();
            mG.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nutricion.Nutricion Nut = new Nutricion.Nutricion();
            Nut.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Psicologia Ps = new Psicologia();
            Ps.Show();
        }

        private void MenuCitas_Load(object sender, EventArgs e)
        {
  
        }
        public static int IdOpcion =2;

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
