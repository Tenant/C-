using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA01
{
    public partial class Form1 : Form
    {
        Circle c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botton1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            c = new Circle(r);
            textBox2.Text = c.getArea().ToString();
            textBox3.Text = c.getGirth().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
