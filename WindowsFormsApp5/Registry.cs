using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Registry : Form
    {
        public Registry()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.Goldenrod;
            button5.ForeColor = Color.White;
            panel2.Width = button4.Width;
            panel2.Location= new Point(72, 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Goldenrod;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            panel2.Width = button2.Width;
            panel2.Location = new Point(0, 30);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Goldenrod;
            button4.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            panel2.Width = button5.Width;
            panel2.Location = new Point(165, 30);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vaccinations1.BringToFront();
        }
    }
}
