using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PickUP.Vocabulary.Add_from_passages
{
    public partial class AddFromPassgaesForm : Form
    {
        AddFromPassageCtrl newAddFromPassageCtrl=new AddFromPassageCtrl();
        Hashtable allWords = new Hashtable(10240);

        public AddFromPassgaesForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string path = tb_Path.Text;
            allWords=newAddFromPassageCtrl.getAllWords(path);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
