namespace PickUP.Vocabulary.Add_a_single_word
{
    partial class AddASingleWordForm
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
            this.gb_Add = new System.Windows.Forms.GroupBox();
            this.tb_Meaning = new System.Windows.Forms.TextBox();
            this.tb_Spelling = new System.Windows.Forms.TextBox();
            this.lb_Meaning = new System.Windows.Forms.Label();
            this.lb_Spelling = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add
            // 
            this.gb_Add.Controls.Add(this.tb_Meaning);
            this.gb_Add.Controls.Add(this.tb_Spelling);
            this.gb_Add.Controls.Add(this.lb_Meaning);
            this.gb_Add.Controls.Add(this.lb_Spelling);
            this.gb_Add.Location = new System.Drawing.Point(12, 13);
            this.gb_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Add.Name = "gb_Add";
            this.gb_Add.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Add.Size = new System.Drawing.Size(225, 118);
            this.gb_Add.TabIndex = 0;
            this.gb_Add.TabStop = false;
            this.gb_Add.Text = "Add";
            // 
            // tb_Meaning
            // 
            this.tb_Meaning.Location = new System.Drawing.Point(94, 68);
            this.tb_Meaning.Name = "tb_Meaning";
            this.tb_Meaning.Size = new System.Drawing.Size(113, 23);
            this.tb_Meaning.TabIndex = 1;
            // 
            // tb_Spelling
            // 
            this.tb_Spelling.Location = new System.Drawing.Point(94, 28);
            this.tb_Spelling.Name = "tb_Spelling";
            this.tb_Spelling.Size = new System.Drawing.Size(113, 23);
            this.tb_Spelling.TabIndex = 1;
            // 
            // lb_Meaning
            // 
            this.lb_Meaning.AutoSize = true;
            this.lb_Meaning.Location = new System.Drawing.Point(21, 71);
            this.lb_Meaning.Name = "lb_Meaning";
            this.lb_Meaning.Size = new System.Drawing.Size(59, 17);
            this.lb_Meaning.TabIndex = 0;
            this.lb_Meaning.Text = "Meaning";
            // 
            // lb_Spelling
            // 
            this.lb_Spelling.AutoSize = true;
            this.lb_Spelling.Location = new System.Drawing.Point(21, 31);
            this.lb_Spelling.Name = "lb_Spelling";
            this.lb_Spelling.Size = new System.Drawing.Size(54, 17);
            this.lb_Spelling.TabIndex = 0;
            this.lb_Spelling.Text = "Spelling";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(36, 149);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(144, 149);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddASingleWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 201);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_Add);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddASingleWordForm";
            this.Text = "PickUP";
            this.gb_Add.ResumeLayout(false);
            this.gb_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add;
        private System.Windows.Forms.TextBox tb_Meaning;
        private System.Windows.Forms.TextBox tb_Spelling;
        private System.Windows.Forms.Label lb_Meaning;
        private System.Windows.Forms.Label lb_Spelling;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
    }
}