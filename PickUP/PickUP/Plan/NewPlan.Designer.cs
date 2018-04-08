namespace PickUP.Plan
{
    partial class NewPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.lb_Meaning = new System.Windows.Forms.Label();
            this.lb_Spelling = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Meaning = new System.Windows.Forms.TextBox();
            this.tb_Spelling = new System.Windows.Forms.TextBox();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.spelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meaning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_NewPlan = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lb_PlanName = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.tb_PlanName = new System.Windows.Forms.TextBox();
            this.lv_Plan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_Search.SuspendLayout();
            this.gb_NewPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.lb_Meaning);
            this.gb_Search.Controls.Add(this.lb_Spelling);
            this.gb_Search.Controls.Add(this.btn_Search);
            this.gb_Search.Controls.Add(this.tb_Meaning);
            this.gb_Search.Controls.Add(this.tb_Spelling);
            this.gb_Search.Location = new System.Drawing.Point(12, 13);
            this.gb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Search.Size = new System.Drawing.Size(192, 134);
            this.gb_Search.TabIndex = 0;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Search Words";
            // 
            // lb_Meaning
            // 
            this.lb_Meaning.AutoSize = true;
            this.lb_Meaning.Location = new System.Drawing.Point(6, 59);
            this.lb_Meaning.Name = "lb_Meaning";
            this.lb_Meaning.Size = new System.Drawing.Size(58, 17);
            this.lb_Meaning.TabIndex = 2;
            this.lb_Meaning.Text = "meaning";
            // 
            // lb_Spelling
            // 
            this.lb_Spelling.AutoSize = true;
            this.lb_Spelling.Location = new System.Drawing.Point(6, 28);
            this.lb_Spelling.Name = "lb_Spelling";
            this.lb_Spelling.Size = new System.Drawing.Size(53, 17);
            this.lb_Spelling.TabIndex = 2;
            this.lb_Spelling.Text = "spelling";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(100, 95);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Meaning
            // 
            this.tb_Meaning.Location = new System.Drawing.Point(84, 57);
            this.tb_Meaning.Name = "tb_Meaning";
            this.tb_Meaning.Size = new System.Drawing.Size(91, 23);
            this.tb_Meaning.TabIndex = 0;
            // 
            // tb_Spelling
            // 
            this.tb_Spelling.Location = new System.Drawing.Point(84, 28);
            this.tb_Spelling.Name = "tb_Spelling";
            this.tb_Spelling.Size = new System.Drawing.Size(91, 23);
            this.tb_Spelling.TabIndex = 0;
            // 
            // lv_Result
            // 
            this.lv_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spelling,
            this.meaning});
            this.lv_Result.GridLines = true;
            this.lv_Result.Location = new System.Drawing.Point(12, 154);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(192, 195);
            this.lv_Result.TabIndex = 1;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            // 
            // spelling
            // 
            this.spelling.Text = "spelling";
            this.spelling.Width = 96;
            // 
            // meaning
            // 
            this.meaning.Text = "meaning";
            this.meaning.Width = 91;
            // 
            // gb_NewPlan
            // 
            this.gb_NewPlan.Controls.Add(this.btn_Confirm);
            this.gb_NewPlan.Controls.Add(this.lb_PlanName);
            this.gb_NewPlan.Controls.Add(this.btn_New);
            this.gb_NewPlan.Controls.Add(this.tb_PlanName);
            this.gb_NewPlan.Location = new System.Drawing.Point(223, 13);
            this.gb_NewPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_NewPlan.Name = "gb_NewPlan";
            this.gb_NewPlan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_NewPlan.Size = new System.Drawing.Size(192, 134);
            this.gb_NewPlan.TabIndex = 0;
            this.gb_NewPlan.TabStop = false;
            this.gb_NewPlan.Text = "New Plan";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(100, 95);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lb_PlanName
            // 
            this.lb_PlanName.AutoSize = true;
            this.lb_PlanName.Location = new System.Drawing.Point(6, 28);
            this.lb_PlanName.Name = "lb_PlanName";
            this.lb_PlanName.Size = new System.Drawing.Size(69, 17);
            this.lb_PlanName.TabIndex = 2;
            this.lb_PlanName.Text = "plan name";
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(9, 95);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // tb_PlanName
            // 
            this.tb_PlanName.Location = new System.Drawing.Point(84, 28);
            this.tb_PlanName.Name = "tb_PlanName";
            this.tb_PlanName.Size = new System.Drawing.Size(91, 23);
            this.tb_PlanName.TabIndex = 0;
            // 
            // lv_Plan
            // 
            this.lv_Plan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_Plan.GridLines = true;
            this.lv_Plan.Location = new System.Drawing.Point(223, 154);
            this.lv_Plan.Name = "lv_Plan";
            this.lv_Plan.Size = new System.Drawing.Size(192, 195);
            this.lv_Plan.TabIndex = 1;
            this.lv_Plan.UseCompatibleStateImageBehavior = false;
            this.lv_Plan.View = System.Windows.Forms.View.Details;
            this.lv_Plan.DoubleClick += new System.EventHandler(this.lv_Plan_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "spelling";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "meaning";
            this.columnHeader2.Width = 93;
            // 
            // NewPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 365);
            this.Controls.Add(this.lv_Plan);
            this.Controls.Add(this.lv_Result);
            this.Controls.Add(this.gb_NewPlan);
            this.Controls.Add(this.gb_Search);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewPlan";
            this.Text = "PickUP";
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.gb_NewPlan.ResumeLayout(false);
            this.gb_NewPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.Label lb_Meaning;
        private System.Windows.Forms.Label lb_Spelling;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Meaning;
        private System.Windows.Forms.TextBox tb_Spelling;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.GroupBox gb_NewPlan;
        private System.Windows.Forms.Label lb_PlanName;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.TextBox tb_PlanName;
        private System.Windows.Forms.ListView lv_Plan;
        private System.Windows.Forms.ColumnHeader spelling;
        private System.Windows.Forms.ColumnHeader meaning;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_Confirm;
    }
}