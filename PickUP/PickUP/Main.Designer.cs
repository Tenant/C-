namespace PickUP
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ms_Main = new System.Windows.Forms.MenuStrip();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSingleWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFromPassageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.planName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vocabulary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ms_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Main
            // 
            this.ms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planToolStripMenuItem,
            this.vocabularyToolStripMenuItem,
            this.passageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ms_Main.Location = new System.Drawing.Point(0, 0);
            this.ms_Main.Name = "ms_Main";
            this.ms_Main.Size = new System.Drawing.Size(609, 25);
            this.ms_Main.TabIndex = 0;
            this.ms_Main.Text = "ms_Main";
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSingleWordToolStripMenuItem,
            this.addFromPassageToolStripMenuItem,
            this.searchWordsToolStripMenuItem});
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.vocabularyToolStripMenuItem.Text = "Vocabulary";
            // 
            // addSingleWordToolStripMenuItem
            // 
            this.addSingleWordToolStripMenuItem.Name = "addSingleWordToolStripMenuItem";
            this.addSingleWordToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addSingleWordToolStripMenuItem.Text = "Add a single word";
            this.addSingleWordToolStripMenuItem.Click += new System.EventHandler(this.addSingleWordToolStripMenuItem_Click);
            // 
            // addFromPassageToolStripMenuItem
            // 
            this.addFromPassageToolStripMenuItem.Name = "addFromPassageToolStripMenuItem";
            this.addFromPassageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addFromPassageToolStripMenuItem.Text = "Add from passages";
            this.addFromPassageToolStripMenuItem.Click += new System.EventHandler(this.addFromPassageToolStripMenuItem_Click);
            // 
            // searchWordsToolStripMenuItem
            // 
            this.searchWordsToolStripMenuItem.Name = "searchWordsToolStripMenuItem";
            this.searchWordsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.searchWordsToolStripMenuItem.Text = "Search words";
            this.searchWordsToolStripMenuItem.Click += new System.EventHandler(this.searchWordsToolStripMenuItem_Click);
            // 
            // passageToolStripMenuItem
            // 
            this.passageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analysisToolStripMenuItem});
            this.passageToolStripMenuItem.Name = "passageToolStripMenuItem";
            this.passageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.passageToolStripMenuItem.Text = "Passage";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMyPlanToolStripMenuItem,
            this.newPlanToolStripMenuItem});
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.planToolStripMenuItem.Text = "Plan";
            // 
            // openMyPlanToolStripMenuItem
            // 
            this.openMyPlanToolStripMenuItem.Name = "openMyPlanToolStripMenuItem";
            this.openMyPlanToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openMyPlanToolStripMenuItem.Text = "Open my plan";
            this.openMyPlanToolStripMenuItem.Click += new System.EventHandler(this.openMyPlanToolStripMenuItem_Click);
            // 
            // newPlanToolStripMenuItem
            // 
            this.newPlanToolStripMenuItem.Name = "newPlanToolStripMenuItem";
            this.newPlanToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newPlanToolStripMenuItem.Text = "New plan";
            this.newPlanToolStripMenuItem.Click += new System.EventHandler(this.newPlanToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.planName,
            this.Date,
            this.Author,
            this.Vocabulary,
            this.Priority});
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 241);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // planName
            // 
            this.planName.Text = "plan name";
            this.planName.Width = 144;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 119;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 135;
            // 
            // Vocabulary
            // 
            this.Vocabulary.Text = "Vocabulary";
            this.Vocabulary.Width = 117;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 281);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ms_Main);
            this.MainMenuStrip = this.ms_Main;
            this.Name = "Main";
            this.Text = "PickUP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ms_Main.ResumeLayout(false);
            this.ms_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Main;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSingleWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFromPassageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMyPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader planName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Vocabulary;
        private System.Windows.Forms.ColumnHeader Priority;
    }
}

