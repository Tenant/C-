using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connstr=@"Provider=SQLNCLI10.1;Data Source=PC-GAOSHQ\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ScoreManager";
            OleDbConnection conn=new OleDbConnection();
            conn.ConnectionString=connstr;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string sql = "select studentno,name,birthday,sex from tblstudent ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = rd["studentno"].ToString();
                li.SubItems.Add(rd["name"].ToString());
                li.SubItems.Add(rd["birthday"].ToString());
                li.SubItems.Add(rd["sex"].ToString());
                lv_score.Items.Add(li);
            }
            rd.Close();
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString="Provider=SQLNCLI10.1;Data Source=lx-058\\JD;Integrated Security=SSPI;Initial Catalog=score";
            string sql;
            sql = "insert into tblStudent(studentno, name, birthday,sex)";
            sql += "  values('" + tbNo.Text + "', '" + tbName.Text;
            sql += "', '" + tbBirthday.Text + "', '" + tbSex.Text + "') ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
