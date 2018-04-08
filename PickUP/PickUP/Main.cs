using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PickUP.Login;
using PickUP.Vocabulary.Add_a_single_word;
using PickUP.Vocabulary.Add_from_passages;
using PickUP.Vocabulary.Search_Words;
using PickUP.Passage.Analysis;
using PickUP.Plan;
using PickUP.Help;

namespace PickUP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm newLoginform = new LoginForm();
            newLoginform.ShowDialog();
            /*
            if (newLoginform.getUsers() == null)
              this.Close();
             */
        }

        private void addSingleWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddASingleWordForm newAddASingleWordForm = new AddASingleWordForm();
            newAddASingleWordForm.Show();
        }

        private void addFromPassageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFromPassgaesForm newAddFromPassagesForm = new AddFromPassgaesForm();
            newAddFromPassagesForm.Show();
        }

        private void searchWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWordsForm newSearchWordsForm = new SearchWordsForm();
            newSearchWordsForm.Show();
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalysisForm newAnalysisForm = new AnalysisForm();
            newAnalysisForm.Show();

        }

        private void newPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlan newNewPlan=new NewPlan();
            newNewPlan.Show();
        }

        private void openMyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMyPlan newOpenMyPlan = new OpenMyPlan();
            newOpenMyPlan.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm newHelpForm = new HelpForm();
            newHelpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
