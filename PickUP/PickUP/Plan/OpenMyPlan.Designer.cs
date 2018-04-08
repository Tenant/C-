namespace PickUP.Plan
{
    partial class OpenMyPlan
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
            this.gb_OpenMyPlan = new System.Windows.Forms.GroupBox();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_PlanName = new System.Windows.Forms.TextBox();
            this.lb_PlanName = new System.Windows.Forms.Label();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.planName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.gb_OpenMyPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_OpenMyPlan
            // 
            this.gb_OpenMyPlan.Controls.Add(this.btn_All);
            this.gb_OpenMyPlan.Controls.Add(this.btn_Search);
            this.gb_OpenMyPlan.Controls.Add(this.tb_PlanName);
            this.gb_OpenMyPlan.Controls.Add(this.lb_PlanName);
            this.gb_OpenMyPlan.Location = new System.Drawing.Point(12, 13);
            this.gb_OpenMyPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_OpenMyPlan.Name = "gb_OpenMyPlan";
            this.gb_OpenMyPlan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_OpenMyPlan.Size = new System.Drawing.Size(233, 114);
            this.gb_OpenMyPlan.TabIndex = 0;
            this.gb_OpenMyPlan.TabStop = false;
            this.gb_OpenMyPlan.Text = "Open my plan";
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(122, 72);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(75, 23);
            this.btn_All.TabIndex = 2;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(19, 72);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_PlanName
            // 
            this.tb_PlanName.Location = new System.Drawing.Point(112, 24);
            this.tb_PlanName.Name = "tb_PlanName";
            this.tb_PlanName.Size = new System.Drawing.Size(100, 23);
            this.tb_PlanName.TabIndex = 1;
            // 
            // lb_PlanName
            // 
            this.lb_PlanName.AutoSize = true;
            this.lb_PlanName.Location = new System.Drawing.Point(16, 30);
            this.lb_PlanName.Name = "lb_PlanName";
            this.lb_PlanName.Size = new System.Drawing.Size(69, 17);
            this.lb_PlanName.TabIndex = 0;
            this.lb_PlanName.Text = "plan name";
            // 
            // lv_Result
            // 
            this.lv_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.planName,
            this.Data});
            this.lv_Result.Location = new System.Drawing.Point(12, 134);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(233, 205);
            this.lv_Result.TabIndex = 1;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            this.lv_Result.DoubleClick += new System.EventHandler(this.lv_Result_DoubleClick);
            // 
            // planName
            // 
            this.planName.Text = "PlanName";
            this.planName.Width = 115;
            // 
            // Data
            // 
            this.Data.Text = "Date";
            this.Data.Width = 113;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(262, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 314);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // OpenMyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 351);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lv_Result);
            this.Controls.Add(this.gb_OpenMyPlan);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpenMyPlan";
            this.Text = "PickUP";
            this.gb_OpenMyPlan.ResumeLayout(false);
            this.gb_OpenMyPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_OpenMyPlan;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_PlanName;
        private System.Windows.Forms.Label lb_PlanName;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.ColumnHeader planName;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ListView listView1;
    }
}