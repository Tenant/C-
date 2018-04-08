using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueueTest
{
    public partial class Form1 : Form
    {
        LikedQueue MyQueue = new LikedQueue();
        int GenetateLength=1000;

        private double[] GenerateRandom(int length)
        {
            Random newRandom=new Random();
            double[] RandomArray = new double[length];
            for (int i = 0; i < length; i++)
            {
                RandomArray[i] = newRandom.Next(2*GenetateLength);
            }
            return RandomArray;
        }

        public void PopAll(LikedQueue newQueue)
        {
            rtbPopAll.Clear();
            Student newstudent;
            if (newQueue.isEmpty())
            {
                MessageBox.Show("队列为空。");
                return;
            }
            rtbPopAll.Text = "学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机" + '\n';
            while (newQueue.pop(out newstudent))
            {
                rtbPopAll.Text += newstudent.no + '\t' + newstudent.name + '\t' + newstudent.math.ToString("0") + '\t' + newstudent.english.ToString("0") + '\t' + newstudent.computer.ToString("0") + '\n';
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushData_Click(object sender, EventArgs e)
        {
            Student newstudent = new Student(tbNoPush.Text, tbNamePush.Text, double.Parse(tbMathPush.Text), double.Parse(tbEnglishPush.Text), double.Parse(tbComputerPush.Text));
            MyQueue.push(newstudent);
            MessageBox.Show("数据添加成功。");
            //清除输入控件
            tbNoPush.Clear();
            tbNamePush.Clear();
            tbMathPush.Clear();
            tbEnglishPush.Clear();
            tbComputerPush.Clear();
            tbNoPush.Focus();
        }

        private void btnPopData_Click(object sender, EventArgs e)
        {
            Student newstudent;
            if (MyQueue.pop(out newstudent))
            {
                tbNoPop.Text = newstudent.no;
                tbNamePop.Text = newstudent.name;
                tbMathPop.Text = newstudent.math.ToString("0");
                tbEnglishPop.Text = newstudent.english.ToString("0");
                tbComputerPop.Text = newstudent.computer.ToString("0");
            }
            else
                MessageBox.Show("队列为空。");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double[] RandomArray = GenerateRandom(GenetateLength);
            for (int i = 0; i < GenetateLength; i++)
            {
                Student newstudent = new Student((RandomArray[i]+1000).ToString("0"), "学生"+(i+1).ToString(), RandomArray[i] % 100, RandomArray[i] % 99, RandomArray[i] % 98);
                MyQueue.push(newstudent);
            }
            MessageBox.Show("队列自动追加成功。");
        }

        private void btnPopAll_Click(object sender, EventArgs e)
        {
            PopAll(MyQueue);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("队列的作业。");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
