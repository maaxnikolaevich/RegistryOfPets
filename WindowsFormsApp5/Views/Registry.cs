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
            vaccinations1.Visible = false;
            header.Visible = false;
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
            vaccinations1.SendToBack();
            vaccinations1.Visible = false;
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
            vaccinations1.Visible = true;
            vaccinations1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button8.Enabled = false;
            panel7.Visible = true;
            panel6.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Найти...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Найти...";
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Найти...";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button8.Enabled = true;
            panel7.Visible = false;
            panel6.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = false;
            button6.Enabled = true;
            button8.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void authorization11_VisibleChanged(object sender, EventArgs e)
        {
               header.Visible = true;

        }
    }
}
