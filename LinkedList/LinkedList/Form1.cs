using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //读写文件相关

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public LinkedList MyList = new LinkedList();

        public Form1()
        {
            InitializeComponent();
        }
        public void printList(LinkedList newList) //遍历指定链表，输出全部元素到rtbScoreList
        {
            rtbScoreList.Clear();
            rtbScoreList.Text = "学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机" + '\n';
            Node newNode = newList.head;
            while (newNode != null)
            {
                Student data = newNode.data;
                rtbScoreList.Text += data.no + '\t' + data.name + '\t' + data.math.ToString("0") + '\t' + data.english.ToString("0") + '\t' + data.computer.ToString("0") + '\n';
                newNode = newNode.next;
            }        
        } 
        public void WriteInFile(LinkedList newList , string FileName) //将指定链表写入指定文件
            {
                StreamWriter sw = new StreamWriter(FileName);
                Node newNode = newList.head;
                sw.WriteLine("学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机");
                while (newNode != null)
                {
                    sw.WriteLine(newNode.data.no + '\t' + newNode.data.name + '\t' + newNode.data.math + '\t' + newNode.data.english + '\t' + newNode.data.computer);
                    newNode = newNode.next;
                }
                sw.Close();
            }
        public void ReadFromFile(LinkedList newList, string FileName) //从指定文件读取数据到指定链表
        {
            StreamReader sr = new StreamReader(FileName);
            char[] deli = { '\t', ' ', ',' };
            sr.ReadLine();  //跳过表头
            while (sr.Peek() > 0)
            {
                string[] data = sr.ReadLine().Split(deli, StringSplitOptions.RemoveEmptyEntries);
                Student newStudent = new Student(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]));
                newList.append(newStudent);
            }
        }
        
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            ReadFromFile(MyList, "student.txt");
            lbScoreList.Text = "MyList";
            printList(MyList);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            lbScoreList.Text = "MyList";
            printList(MyList);
            WriteInFile(MyList, "MyList.txt");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            lbScoreList.Text = "MyList";
            try
            {
                Student newStudent = new Student(tbNo.Text, tbName.Text, double.Parse(tbMath.Text), double.Parse(tbEnglish.Text), double.Parse(tbComputer.Text));
                MyList.append(newStudent);
                printList(MyList);
                tbNo.Text = "";
                tbName.Text = "";
                tbMath.Text = "";
                tbEnglish.Text = "";
                tbComputer.Text = "";
                tbNo.Focus();
            }
            catch
            {
                MessageBox.Show("你输错了有木有哟！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string NoDelete = tbNoDelete.Text;
            MyList.delete(NoDelete);
            lbScoreList.Text = "MyList";
            printList(MyList);
            tbNoDelete.Clear();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            LinkedList RevList = new LinkedList();
            RevList= MyList.reverse();
            lbScoreList.Text = "RevList";
            printList(RevList);
            
        }

        private void division_Click(object sender, EventArgs e)
        {
            LinkedList[] divList = MyList.division();
            LinkedList even = divList[0];
            LinkedList odd = divList[1];
            WriteInFile(even, "even.txt");
            WriteInFile(odd, "odd.txt");
        }

        private void btnSimplify_Click(object sender, EventArgs e)
        {
            LinkedList simList = MyList.Simplify();
            lbScoreList.Text = "simList";
            printList(simList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Node max=MyList.searchMaxTotal();
            if (max == null)
                MessageBox.Show("并没有找到最高分学生哟!");
            else
            {
                tbNoSearch.Text = max.data.no;
                tbNameSearch.Text = max.data.name;
                tbTotal.Text = max.data.total.ToString("0");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
