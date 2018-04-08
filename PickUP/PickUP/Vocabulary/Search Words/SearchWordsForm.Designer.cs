namespace PickUP.Vocabulary.Search_Words
{
    partial class SearchWordsForm
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Meaning = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Spelling = new System.Windows.Forms.TextBox();
            this.lb_Meaning = new System.Windows.Forms.Label();
            this.lb_Spelling = new System.Windows.Forms.Label();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.Spelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Meaning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.btn_Cancel);
            this.gb_Search.Controls.Add(this.tb_Meaning);
            this.gb_Search.Controls.Add(this.btn_Search);
            this.gb_Search.Controls.Add(this.tb_Spelling);
            this.gb_Search.Controls.Add(this.lb_Meaning);
            this.gb_Search.Controls.Add(this.lb_Spelling);
            this.gb_Search.Location = new System.Drawing.Point(12, 13);
            this.gb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Search.Size = new System.Drawing.Size(251, 138);
            this.gb_Search.TabIndex = 0;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Search";
            this.gb_Search.Enter += new System.EventHandler(this.gb_Search_Enter);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(151, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Meaning
            // 
            this.tb_Meaning.Location = new System.Drawing.Point(80, 61);
            this.tb_Meaning.Name = "tb_Meaning";
            this.tb_Meaning.Size = new System.Drawing.Size(146, 23);
            this.tb_Meaning.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(23, 99);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Spelling
            // 
            this.tb_Spelling.Location = new System.Drawing.Point(80, 21);
            this.tb_Spelling.Name = "tb_Spelling";
            this.tb_Spelling.Size = new System.Drawing.Size(146, 23);
            this.tb_Spelling.TabIndex = 1;
            // 
            // lb_Meaning
            // 
            this.lb_Meaning.AutoSize = true;
            this.lb_Meaning.Location = new System.Drawing.Point(20, 64);
            this.lb_Meaning.Name = "lb_Meaning";
            this.lb_Meaning.Size = new System.Drawing.Size(59, 17);
            this.lb_Meaning.TabIndex = 0;
            this.lb_Meaning.Text = "Meaning";
            // 
            // lb_Spelling
            // 
            this.lb_Spelling.AutoSize = true;
            this.lb_Spelling.Location = new System.Drawing.Point(20, 24);
            this.lb_Spelling.Name = "lb_Spelling";
            this.lb_Spelling.Size = new System.Drawing.Size(54, 17);
            this.lb_Spelling.TabIndex = 0;
            this.lb_Spelling.Text = "Spelling";
            // 
            // lv_Result
            // 
            this.lv_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Spelling,
            this.Meaning});
            this.lv_Result.Location = new System.Drawing.Point(12, 175);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(251, 136);
            this.lv_Result.TabIndex = 1;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            // 
            // Spelling
            // 
            this.Spelling.Text = "Spelling";
            this.Spelling.Width = 115;
            // 
            // Meaning
            // 
            this.Meaning.Text = "Meaning";
            this.Meaning.Width = 132;
            // 
            // SearchWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 338);
            this.Controls.Add(this.lv_Result);
            this.Controls.Add(this.gb_Search);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchWordsForm";
            this.Text = "PickUP";
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.TextBox tb_Meaning;
        private System.Windows.Forms.TextBox tb_Spelling;
        private System.Windows.Forms.Label lb_Meaning;
        private System.Windows.Forms.Label lb_Spelling;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.ColumnHeader Spelling;
        private System.Windows.Forms.ColumnHeader Meaning;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Search;
    }
}