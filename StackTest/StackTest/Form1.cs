using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StackTest
{
    public partial class Form1 : Form
    {
        private LinkedList MyList = new LinkedList();
        private ListedStack MyStack=new ListedStack();
        
        public Form1()
        {
            InitializeComponent();
            tbNoPush.Focus();
            btnHelp_Click(null, null);
        }

        
       public void printList(LinkedList newlist)
        {
            rtbPopAll.Clear();
            rtbPopAll.Text = "学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机" + '\n';
            Node newNode = newlist.getHead();
            while (newNode != null)
            {
                Student data = newNode.getValue();
                rtbPopAll.Text += data.no + '\t' + data.name + '\t' + data.math.ToString("0") + '\t' + data.english.ToString("0") + '\t' + data.computer.ToString("0") + '\n';
                newNode = newNode.next;
            }        
        }

       public void PopAll(ListedStack newstack)
       {
           Student newstudent;
            if (newstack.isEmpty())
            {
                 MessageBox.Show("堆栈为空。");
                return;
            }
           rtbPopAll.Text = "学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机" + '\n';
           while (MyStack.pop(out newstudent))
            {
                rtbPopAll.Text += newstudent.no + '\t' + newstudent.name + '\t' + newstudent.math.ToString("0") + '\t' + newstudent.english.ToString("0") + '\t' + newstudent.computer.ToString("0") + '\n';
            }
       }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPushData_Click(object sender, EventArgs e)
        {
            Student newstudent = new Student(tbNoPush.Text, tbNamePush.Text, double.Parse(tbMathPush.Text), double.Parse(tbEnglishPush.Text), double.Parse(tbComputerPush.Text));
            MyStack.push(newstudent);
            MessageBox.Show("数据添加成功。");
            //清除输入控件
            tbNoPush.Text="";
            tbNamePush.Text = "";
            tbMathPush.Text = "";
            tbEnglishPush.Text = "";
            tbComputerPush.Text = "";
            tbNoPush.Focus();
        }

        private void btnPopData_Click(object sender, EventArgs e)
        {
            Student newstudent ;
            if (MyStack.pop(out newstudent))
            {
                tbNoPop.Text = newstudent.no;
                tbNamePop.Text = newstudent.name;
                tbMathPop.Text = newstudent.math.ToString("0");
                tbEnglishPop.Text = newstudent.english.ToString("0");
                tbComputerPop.Text = newstudent.computer.ToString("0");
            }
            else
                MessageBox.Show("堆栈为空。");
        }

        private void btnPopAll_Click(object sender, EventArgs e)
        {
            PopAll(MyStack);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("student.txt");
            char[] deli = { '\t', ' ', ',' };
            sr.ReadLine();  //跳过表头
            MyList = new LinkedList();
            while (sr.Peek() > 0)
            {
                string[] data = sr.ReadLine().Split(deli, StringSplitOptions.RemoveEmptyEntries);
                Student newstudent = new Student(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]));
                MyList.append(newstudent);
            }
            printList(MyList);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            LinkedList RevList = MyList.Reverse();
            printList(RevList);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("堆栈数据从用户界面输入，链表数据从\"bin/Debug/student.txt\"文件读入，请运行时注意。");
        }        

    }
}
