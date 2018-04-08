using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CourseManagement.TeacherManager
{
    public partial class InputTeacherForm : Form
    {
        public InputTeacherForm()
        {
            InitializeComponent();
        }

        private void InputTeacherForm_Load(object sender, EventArgs e)
        {
            Hashtable htDept = TeacherCtrl.getDeptList();
            cbDept.Items.Clear();
            foreach (DictionaryEntry de in htDept)
            {
                cbDept.Items.Add((string)de.Key);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Teacher newteacher=new Teacher(tbstaffNo.Text, tbstaffName.Text, cbSex.Text, cbDept.Text);
           TeacherCtrl tc = new TeacherCtrl();
            tc.InputTeacher(newteacher);
            if (tc.saveDataBase())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = tbstaffNo.Text;
                li.SubItems.Add(tbstaffName.Text);
                li.SubItems.Add(cbSex.Text);
                li.SubItems.Add(cbDept.Text);
                lvStaff.Items.Add(li);
            }

        }
    }
}
