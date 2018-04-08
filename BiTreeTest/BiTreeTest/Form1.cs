using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiTreeTest
{
    public partial class Form1 : Form
    {
        BiTree MyBiTree = new BiTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void publishList(List<double> newlist)
        {
            rtb.Clear();
            for (int i = 0; i < newlist.Count; i++)
                rtb.Text += newlist[i].ToString("0.000000")+'\n';
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random RandomGeneration = new Random();
            double data;
            for (int i = 0; i < 200; i++)
            {
                data = RandomGeneration.NextDouble();
                MyBiTree.growBiTree(data);
            }
        }

        private void btnmidOrder_Click(object sender, EventArgs e)
        {
            List<double> MyList = MyBiTree.midOrder();
            publishList(MyList);
        }

        private void btnrevOrder_Click(object sender, EventArgs e)
        {
            List<double> MyList = MyBiTree.revOrder();
            publishList(MyList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
