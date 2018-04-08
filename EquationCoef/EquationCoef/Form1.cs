using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EquationCoef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader ( "S:\\equationCoef.txt" );
            rtb.Text="root1"+'\t'+'\t'+"root2";//为了格式好看一点，加了两个tab
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                char[] deli = { '\t', ' ' };
                string[] unit = line.Split(deli , StringSplitOptions.RemoveEmptyEntries) ;
                double a = double.Parse(unit[0]);
                double b = double.Parse(unit[1]);
                double c = double.Parse(unit[2]);
                EquationCoef eq = new EquationCoef( a , b , c );
                double root1, root2;
                if (eq.getRoot( out root1 , out root2))
                {
                    rtb.AppendText("\n"+root1.ToString("0.000")+'\t'+'\t'+root2.ToString("0.000"));
                }
                else
                    rtb.AppendText('\n'+"方程无根");
            }
            sr.Close();
       }

        private void tbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
