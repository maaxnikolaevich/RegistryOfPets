using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Vaccinations : UserControl
    {
        public Vaccinations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            owners1.BringToFront();
            owners1.Visible = true;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            owners1.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
