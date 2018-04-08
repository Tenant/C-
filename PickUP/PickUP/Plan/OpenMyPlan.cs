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

namespace PickUP.Plan
{
    public partial class OpenMyPlan : Form
    {
        public OpenMyPlan()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "select spelling, meaning from tbl_Plan where planName %' " + tb_PlanName + "'";
            String[] title = { "PlanName", "Date" };
            Utils.dbReaderToListView(lv_Result, title, sql, conn);
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "select planName, date from tbl_Plan";
            String[] title = { "PlanName", "Date" };
            Utils.dbReaderToListView(lv_Result, title, sql, conn);
        }

        private void lv_Result_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "select spelling, meaning from tbl_Vocabulay v, tbl_SelectWord s where v.spelling=s.spelling AND s.planName='"+tb_PlanName+"'";
            String[] title = { "Spelling", "Meaning" };
            Utils.dbReaderToListView(lv_Result, title, sql, conn);
        }
    }
}
