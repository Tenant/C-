using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TJU.SoftCourse;
using System.Data.OleDb;

namespace PickUP.Vocabulary.Add_a_single_word
{
    public partial class AddASingleWordForm : Form
    {
        public AddASingleWordForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "insert into tbl_Vocabulary('spelling','meaning') Values('"+tb_Spelling+"','"+tb_Meaning+"')";
            OleDbConn.execNonQuery(sql);
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
