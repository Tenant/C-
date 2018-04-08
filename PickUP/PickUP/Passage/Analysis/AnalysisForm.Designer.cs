namespace PickUP.Passage.Analysis
{
    partial class AnalysisForm
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
            this.gb_Analysis = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_Path = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.gb_Result = new System.Windows.Forms.GroupBox();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_Analysis.SuspendLayout();
            this.gb_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Analysis
            // 
            this.gb_Analysis.Controls.Add(this.btn_Cancel);
            this.gb_Analysis.Controls.Add(this.btn_Start);
            this.gb_Analysis.Controls.Add(this.lb_Path);
            this.gb_Analysis.Controls.Add(this.tb_path);
            this.gb_Analysis.Location = new System.Drawing.Point(12, 13);
            this.gb_Analysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Analysis.Name = "gb_Analysis";
            this.gb_Analysis.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Analysis.Size = new System.Drawing.Size(265, 110);
            this.gb_Analysis.TabIndex = 0;
            this.gb_Analysis.TabStop = false;
            this.gb_Analysis.Text = "Analysis";
            this.gb_Analysis.Enter += new System.EventHandler(this.gb_Analysis_Enter);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(164, 66);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(32, 66);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_Path
            // 
            this.lb_Path.AutoSize = true;
            this.lb_Path.Location = new System.Drawing.Point(29, 28);
            this.lb_Path.Name = "lb_Path";
            this.lb_Path.Size = new System.Drawing.Size(34, 17);
            this.lb_Path.TabIndex = 1;
            this.lb_Path.Text = "path";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(64, 25);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(189, 23);
            this.tb_path.TabIndex = 0;
            // 
            // gb_Result
            // 
            this.gb_Result.Controls.Add(this.lv_Result);
            this.gb_Result.Location = new System.Drawing.Point(12, 137);
            this.gb_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Result.Name = "gb_Result";
            this.gb_Result.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Result.Size = new System.Drawing.Size(265, 205);
            this.gb_Result.TabIndex = 0;
            this.gb_Result.TabStop = false;
            this.gb_Result.Text = "Result";
            // 
            // lv_Result
            // 
            this.lv_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Frequency});
            this.lv_Result.GridLines = true;
            this.lv_Result.Location = new System.Drawing.Point(6, 23);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(253, 175);
            this.lv_Result.TabIndex = 0;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 157;
            // 
            // Frequency
            // 
            this.Frequency.Text = "Frequency";
            this.Frequency.Width = 91;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 363);
            this.Controls.Add(this.gb_Result);
            this.Controls.Add(this.gb_Analysis);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnalysisForm";
            this.Text = "PickUP";
            this.gb_Analysis.ResumeLayout(false);
            this.gb_Analysis.PerformLayout();
            this.gb_Result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Analysis;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_Path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.GroupBox gb_Result;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Frequency;
    }
}