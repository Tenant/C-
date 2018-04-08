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

namespace PickUP.Vocabulary.Search_Words
{
    public partial class SearchWordsForm : Form
    {
        public SearchWordsForm()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "select spelling, meaning from tbl_Vocabulary where spelling%' "+tb_Spelling;
            sql = sql + "'　AND meaning%'" + tb_Meaning + "'";
            String[] title = { "Spelling", "Meaning" };
            Utils.dbReaderToListView(lv_Result, title, sql, conn);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_Search_Enter(object sender, EventArgs e)
        {

        }
    }
}
