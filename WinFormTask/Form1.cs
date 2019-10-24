using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, r;
            if (!double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Wrong value X ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Wrong value Y ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBox3.Text, out z))
            {
                MessageBox.Show("Wrong value Z ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            r = ((2 * Math.Cos(x * x) - (1 / 2)) / ((1 / 2) + Math.Sin(Math.Pow(y, 2 - z)))) + ((z * z) / (7 - (z / 3)));
            textBox4.Text = r.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
