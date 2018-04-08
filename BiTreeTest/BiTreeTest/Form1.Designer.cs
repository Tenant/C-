namespace BiTreeTest
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnmidOrder = new System.Windows.Forms.Button();
            this.btnrevOrder = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(205, 38);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "创建树";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnmidOrder
            // 
            this.btnmidOrder.Location = new System.Drawing.Point(205, 95);
            this.btnmidOrder.Name = "btnmidOrder";
            this.btnmidOrder.Size = new System.Drawing.Size(75, 23);
            this.btnmidOrder.TabIndex = 2;
            this.btnmidOrder.Text = "正序遍历";
            this.btnmidOrder.UseVisualStyleBackColor = true;
            this.btnmidOrder.Click += new System.EventHandler(this.btnmidOrder_Click);
            // 
            // btnrevOrder
            // 
            this.btnrevOrder.Location = new System.Drawing.Point(205, 157);
            this.btnrevOrder.Name = "btnrevOrder";
            this.btnrevOrder.Size = new System.Drawing.Size(75, 23);
            this.btnrevOrder.TabIndex = 2;
            this.btnrevOrder.Text = "逆序遍历";
            this.btnrevOrder.UseVisualStyleBackColor = true;
            this.btnrevOrder.Click += new System.EventHandler(this.btnrevOrder_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(33, 38);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(146, 211);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(205, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 296);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnrevOrder);
            this.Controls.Add(this.btnmidOrder);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "二叉树";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnmidOrder;
        private System.Windows.Forms.Button btnrevOrder;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnClose;
    }
}

