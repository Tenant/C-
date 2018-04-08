namespace CourseManagement.TeacherManager
{
    partial class InputTeacherForm
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
            this.tbstaffNo = new System.Windows.Forms.TextBox();
            this.lbstaffNo = new System.Windows.Forms.Label();
            this.tbstaffName = new System.Windows.Forms.TextBox();
            this.lbstaffName = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbdeptID = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvStaff = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbstaffNo
            // 
            this.tbstaffNo.Location = new System.Drawing.Point(81, 25);
            this.tbstaffNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbstaffNo.Name = "tbstaffNo";
            this.tbstaffNo.Size = new System.Drawing.Size(84, 23);
            this.tbstaffNo.TabIndex = 0;
            // 
            // lbstaffNo
            // 
            this.lbstaffNo.AutoSize = true;
            this.lbstaffNo.Location = new System.Drawing.Point(43, 28);
            this.lbstaffNo.Name = "lbstaffNo";
            this.lbstaffNo.Size = new System.Drawing.Size(32, 17);
            this.lbstaffNo.TabIndex = 1;
            this.lbstaffNo.Text = "工号";
            // 
            // tbstaffName
            // 
            this.tbstaffName.Location = new System.Drawing.Point(229, 25);
            this.tbstaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbstaffName.Name = "tbstaffName";
            this.tbstaffName.Size = new System.Drawing.Size(81, 23);
            this.tbstaffName.TabIndex = 0;
            // 
            // lbstaffName
            // 
            this.lbstaffName.AutoSize = true;
            this.lbstaffName.Location = new System.Drawing.Point(191, 28);
            this.lbstaffName.Name = "lbstaffName";
            this.lbstaffName.Size = new System.Drawing.Size(32, 17);
            this.lbstaffName.TabIndex = 1;
            this.lbstaffName.Text = "姓名";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(338, 28);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(32, 17);
            this.lbSex.TabIndex = 1;
            this.lbSex.Text = "性别";
            // 
            // lbdeptID
            // 
            this.lbdeptID.AutoSize = true;
            this.lbdeptID.Location = new System.Drawing.Point(506, 28);
            this.lbdeptID.Name = "lbdeptID";
            this.lbdeptID.Size = new System.Drawing.Size(32, 17);
            this.lbdeptID.TabIndex = 1;
            this.lbdeptID.Text = "院系";
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Items.AddRange(new object[] {
            "数学系",
            "物理系",
            "化学系"});
            this.cbDept.Location = new System.Drawing.Point(544, 25);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 25);
            this.cbDept.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(376, 25);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(98, 25);
            this.cbSex.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "本次新增的教师信息";
            // 
            // lvStaff
            // 
            this.lvStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvStaff.GridLines = true;
            this.lvStaff.Location = new System.Drawing.Point(46, 114);
            this.lvStaff.MultiSelect = false;
            this.lvStaff.Name = "lvStaff";
            this.lvStaff.Size = new System.Drawing.Size(629, 209);
            this.lvStaff.TabIndex = 6;
            this.lvStaff.UseCompatibleStateImageBehavior = false;
            this.lvStaff.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "工号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "院系";
            // 
            // InputTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 353);
            this.Controls.Add(this.lvStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.lbdeptID);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbstaffName);
            this.Controls.Add(this.lbstaffNo);
            this.Controls.Add(this.tbstaffName);
            this.Controls.Add(this.tbstaffNo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InputTeacherForm";
            this.Text = "InputTeacherForm";
            this.Load += new System.EventHandler(this.InputTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbstaffNo;
        private System.Windows.Forms.Label lbstaffNo;
        private System.Windows.Forms.TextBox tbstaffName;
        private System.Windows.Forms.Label lbstaffName;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbdeptID;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvStaff;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}