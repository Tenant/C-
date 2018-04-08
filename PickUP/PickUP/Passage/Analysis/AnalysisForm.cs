using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace PickUP.Passage.Analysis
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void gb_Analysis_Enter(object sender, EventArgs e)
        {

        }
        
        private void btn_Start_Click(object sender, EventArgs e)
        {
            string inputFilePath = tb_path.Text;
            Hashtable allWords = AnalysisCtrl.getAllWords(inputFilePath);
            List<WordInfo> allWordInfos = new List<WordInfo>();
            foreach (string key in allWords.Keys)
            {
                allWordInfos.Add(new WordInfo(key, allWords[key].ToString()));
            }
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
