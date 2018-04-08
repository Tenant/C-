using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(tb1.Text);
            int[,] a = new int[m, m];
            int s = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = i * 3 + j;
            foreach (int d in a)
                s = s + d;
            tb2.Text = s.ToString();
            double f=Math.Sqrt (s);
            tb3.Text =f.ToString ();
        }
    }
}
