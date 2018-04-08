namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.conn = new System.Data.OleDb.OleDbConnection();
            this.lv_score = new System.Windows.Forms.ListView();
            this.studentno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsdf = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conn
            // 
            this.conn.ConnectionString = "Provider=SQLNCLI10.1;Data Source=PC-GAOSHQ\\SQLEXPRESS;Integrated Security=SSPI;In" +
                "itial Catalog=ScoreManager";
            // 
            // lv_score
            // 
            this.lv_score.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentno,
            this.name,
            this.birthday,
            this.sex});
            this.lv_score.FullRowSelect = true;
            this.lv_score.GridLines = true;
            this.lv_score.Location = new System.Drawing.Point(64, 66);
            this.lv_score.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_score.Name = "lv_score";
            this.lv_score.Size = new System.Drawing.Size(942, 302);
            this.lv_score.TabIndex = 0;
            this.lv_score.UseCompatibleStateImageBehavior = false;
            this.lv_score.View = System.Windows.Forms.View.Details;
            // 
            // studentno
            // 
            this.studentno.Text = "studentno";
            this.studentno.Width = 71;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 51;
            // 
            // birthday
            // 
            this.birthday.Text = "birthday";
            this.birthday.Width = 103;
            // 
            // sex
            // 
            this.sex.Text = "sex";
            this.sex.Width = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(893, 384);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加信息";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(64, 18);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 29);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "显示所有数据";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(913, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(254, 392);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(101, 23);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名";
            // 
            // tbsdf
            // 
            this.tbsdf.AutoSize = true;
            this.tbsdf.Location = new System.Drawing.Point(362, 396);
            this.tbsdf.Name = "tbsdf";
            this.tbsdf.Size = new System.Drawing.Size(32, 17);
            this.tbsdf.TabIndex = 7;
            this.tbsdf.Text = "生日";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(403, 392);
            this.tbBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(101, 23);
            this.tbBirthday.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "学号";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(105, 392);
            this.tbNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(101, 23);
            this.tbNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "性别";
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(553, 392);
            this.tbSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(101, 23);
            this.tbSex.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.tbsdf);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lv_score);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection conn;
        private System.Windows.Forms.ListView lv_score;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbsdf;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.ColumnHeader studentno;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSex;
    }
}

