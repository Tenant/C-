using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ListTest2
{
    public partial class Form1 : Form
    {
        private ArrayList MyList = new ArrayList(200);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStudent = new Student(tbNum.Text, tbName.Text, double.Parse(tbMath.Text), double.Parse(tbEnglish.Text), double.Parse(tbComputer.Text));
                bool ensure = MyList.append(newStudent);
                if (ensure)
                    btnPrintAll_Click(sender,  e);
                else
                    rtbScoreList.Text = "追加失败";
            }
            catch
            {
                MessageBox.Show("你输错了哟木有");
            }
           //清空控件
            tbNum.Text = "";
            tbName.Text = "";
            tbMath.Text = "";
            tbEnglish.Text = "";
            tbComputer.Text = "";
            tbNum.Focus(); //为控件设置焦点
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            int length = MyList.getLength();
            rtbScoreList.Text = "学号" + '\t' +"姓名" + '\t' + "数学"+ '\t' + "英语" + '\t' + "计算机"+'\n';
            for (int i = 0; i < length; i++)
            {
               Student data = MyList.getValue(i);
                rtbScoreList.Text +=data .num + '\t' + data.name + '\t' +data.math.ToString("0") + '\t' + data.english.ToString("0") + '\t' + data.computer.ToString("0")+'\n';
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MyList.sort();
            btnPrintAll_Click(sender, e);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("student.txt");
            char[] deli = { '\t', ' ', ',' };
            bool ensure = true;
            MyList.Clear();
            sr.ReadLine();
            while (sr.Peek() > 0 && ensure== true)
            {
            string[] data = sr.ReadLine().Split(deli , StringSplitOptions.RemoveEmptyEntries);
            Student newStudent=new Student(data[0] , data[1] , double.Parse(data[2]) , double.Parse(data[3]), double.Parse(data[4]));
            ensure = MyList.append(newStudent);
            }
            if (sr.Peek() > 0)
                rtbScoreList.Text= "从文件读入失败";
            else
                btnPrintAll_Click(sender, e);           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string num = tbNumDelete.Text;
            bool ensure = MyList.delete(num);
            if (ensure)
                btnPrintAll_Click(sender, e);
            else
                rtbScoreList.Text = "不存在满足条件的学生信息";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student Max = MyList.getMax();
            tbNumSearch.Text = Max.num;
            tbNameSearch.Text = Max.name;
            tbTotal.Text = Max.total.ToString("0");
        }

        private void btndelRep_Click(object sender, EventArgs e)
        {
            ArrayList temp = new ArrayList(MyList.getLength());
            MyList.sort();
            for (int i = 0; i < MyList.getLength(); i++)
            {
                if(temp.checkExist(MyList.getValue(i))==-1)
                    temp.append(MyList.getValue(i));
            }
            MyList = temp;
            btnPrintAll_Click(sender, e);
        }
    }
}
