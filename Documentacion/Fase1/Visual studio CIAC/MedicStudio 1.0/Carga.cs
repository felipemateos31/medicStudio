using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicStudio_1._0
{
    public partial class Form1 : Form
    {
        int tiempo = 5;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (tiempo == 0)
            {
                login id = new login();
                id.Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {
                tiempo -= 1;
            }
            label3.Text = tiempo + " % ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
