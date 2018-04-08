using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseManagement.TeacherManager;
using CourseManagement.StudentManager;

namespace CourseManagement
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void 输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTeacherForm inputteacherform1 = new InputTeacherForm();
            inputteacherform1.ShowDialog();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStudentForm inputstudentform1 = new InputStudentForm();
            inputstudentform1.ShowDialog();
        }
    }
}
