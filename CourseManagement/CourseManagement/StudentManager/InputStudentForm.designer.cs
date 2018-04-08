namespace CourseManagement.StudentManager
{
    partial class InputStudentForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("工号");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("姓名");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("性别");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("院系");
            this.tbstaffNo = new System.Windows.Forms.TextBox();
            this.lbstaffNo = new System.Windows.Forms.Label();
            this.tbstaffName = new System.Windows.Forms.TextBox();
            this.lbstaffName = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbdeptID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lvInputTeacgerInfo = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbstaffNo.Text = "学号";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(376, 25);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(98, 25);
            this.cbSex.TabIndex = 2;
            // 
            // lvInputTeacgerInfo
            // 
            this.lvInputTeacgerInfo.GridLines = true;
            this.lvInputTeacgerInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvInputTeacgerInfo.Location = new System.Drawing.Point(46, 105);
            this.lvInputTeacgerInfo.Name = "lvInputTeacgerInfo";
            this.lvInputTeacgerInfo.Size = new System.Drawing.Size(717, 219);
            this.lvInputTeacgerInfo.TabIndex = 3;
            this.lvInputTeacgerInfo.UseCompatibleStateImageBehavior = false;
            this.lvInputTeacgerInfo.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(688, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "本次新增的学生信息";
            // 
            // InputStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvInputTeacgerInfo);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbdeptID);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbstaffName);
            this.Controls.Add(this.lbstaffNo);
            this.Controls.Add(this.tbstaffName);
            this.Controls.Add(this.tbstaffNo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InputStudentForm";
            this.Text = "InputStudentForm";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ListView lvInputTeacgerInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}