using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassLib
{
    public partial class Form1 : Form
    {
        public LinkedList MyList = new LinkedList();
        public LinkedList RevList = new LinkedList();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void printList(LinkedList newlist)
        {
            rtbScoreList.Clear();
            rtbScoreList.Text = "学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机" + '\n';
            Node newNode = newlist.head;
            while (newNode != null)
            {
                Student data = newNode.data;
                rtbScoreList.Text += data.no + '\t' + data.name + '\t' + data.math.ToString("0") + '\t' + data.english.ToString("0") + '\t' + data.computer.ToString("0") + '\n';
                newNode = newNode.next;
            }        
        }

        public void WriteInFile(LinkedList newlist , string FileName)
            {
                StreamWriter sw = new StreamWriter(FileName);
                Node newnode = newlist.head;
                sw.WriteLine("学号" + '\t' + "姓名" + '\t' + "数学" + '\t' + "英语" + '\t' + "计算机");
                while (newnode != null)
                {
                    sw.WriteLine(newnode.data.no + '\t' + newnode.data.name + '\t' + newnode.data.math + '\t' + newnode.data.english + '\t' + newnode.data.computer);
                    newnode = newnode.next;
                }
                sw.Close();
            }

        //从文件读取 链表
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("student.txt");
            char[] deli = { '\t' ,' ' , ',' };
            sr.ReadLine();  //跳过表头
            MyList = new LinkedList();
            while (sr.Peek() > 0)
            {
                string[] data = sr.ReadLine().Split(deli, StringSplitOptions.RemoveEmptyEntries);
                Student newStudent = new Student(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]));
                MyList.append(newStudent);
            }
            btnPrintAll_Click(sender, e);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            printList(MyList);
            WriteInFile(MyList, "MyList.txt");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(tbNo.Text, tbName.Text, double.Parse(tbMath.Text), double.Parse(tbEnglish.Text), double.Parse(tbComputer.Text));
            MyList.append(newStudent);
            //MyList.insertInFront(newNode);
            printList(MyList); 
            tbNo.Text = "";
            tbName.Text = "";
            tbMath.Text = "";
            tbEnglish.Text = "";
            tbComputer.Text = "";
            tbNo.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete_no = tbNoDelete.Text;
            MyList.delete(delete_no);
            printList(MyList);
            tbNoDelete.Clear();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            RevList= MyList.reverse();
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
            printList(simList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Node max=MyList.search();
            tbNoSearch.Text = max.data.no;
            tbNameSearch.Text = max.data.name;
            tbTotal.Text = max.data.total.ToString("0");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
