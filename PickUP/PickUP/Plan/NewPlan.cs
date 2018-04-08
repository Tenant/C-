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
using PickUP.Vocabulary;


namespace PickUP.Plan
{
    public partial class NewPlan : Form
    {
        PlanCtrl newPlanCtrl = new PlanCtrl();
        Plan newPlan = new Plan("");
        string planName = "";

        public NewPlan()
        {
            InitializeComponent();
        }

        private void refreshListView(ListView lv)
        {
            string spelling, meaning;
            Word newWord;
            for (int i = 0; i <= newPlan.getData().Count; i++)
            {
                newWord= newPlan.getData()[i];
                spelling=newWord.getSpelling();
                meaning=newWord.getMeaning();
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = spelling;
                li.SubItems.Add(meaning);
                lv.Items.Add(li);    
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            String sql = "select spelling, meaning from tbl_Vocabulary where spelling %' " + tb_Spelling;
            sql = sql + "'　AND meaning %'" + tb_Meaning + "'";
            String[] title = { "Spelling", "Meaning" };
            Utils.dbReaderToListView(lv_Result, title, sql, conn);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            planName = tb_PlanName.Text;
            newPlan = newPlanCtrl.setNewPlan(planName);            
        }

        private void lv_Plan_DoubleClick(object sender, EventArgs e)
        {
            if (this.lv_Plan.SelectedItems.Count != 1)
                return;  
           string spelling= this.lv_Result.SelectedItems[0].Text.ToString();
           string meaning = this.lv_Result.SelectedItems[0].SubItems[1].Text.ToString();
           newPlan = newPlanCtrl.addWord(newPlan, spelling, meaning);
           refreshListView(lv_Plan);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = OleDbConn.getConn();
            string spelling, planName;
            for (int i = 0; i <= lv_Plan.Items.Count; i++)
            {
                ListViewItem li = lv_Plan.Items[i];
                spelling = li.SubItems[0].ToString();
                planName = li.SubItems[1].ToString();
                String sql = "insert into tbl_SelectWord('spelling','planName') Values('" + spelling + "','" + planName + "')";
                OleDbConn.execNonQuery(sql);
            }            
        }
    }
}
