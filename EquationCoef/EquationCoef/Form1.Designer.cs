namespace EquationCoef
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
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.tbClose = new System.Windows.Forms.Button();
            this.tbRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb.Location = new System.Drawing.Point(161, 33);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(249, 116);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // tbClose
            // 
            this.tbClose.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbClose.Location = new System.Drawing.Point(31, 100);
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(91, 28);
            this.tbClose.TabIndex = 1;
            this.tbClose.Text = "关闭";
            this.tbClose.UseVisualStyleBackColor = true;
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // tbRead
            // 
            this.tbRead.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRead.Location = new System.Drawing.Point(31, 49);
            this.tbRead.Name = "tbRead";
            this.tbRead.Size = new System.Drawing.Size(91, 28);
            this.tbRead.TabIndex = 1;
            this.tbRead.Text = "计算";
            this.tbRead.UseVisualStyleBackColor = true;
            this.tbRead.Click += new System.EventHandler(this.tbRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 191);
            this.Controls.Add(this.tbClose);
            this.Controls.Add(this.tbRead);
            this.Controls.Add(this.rtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button tbClose;
        private System.Windows.Forms.Button tbRead;
    }
}

