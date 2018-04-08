namespace ToKey
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Key,
            this.Path,
            this.User});
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.LabelEdit = true;
            this.mainListView.Location = new System.Drawing.Point(12, 13);
            this.mainListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(518, 338);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Key
            // 
            this.Key.Text = "Key";
            this.Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Key.Width = 140;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Path.Width = 254;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 375);
            this.Controls.Add(this.mainListView);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name.Text = "Name";
            this.Text = "ToKey";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Key;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader User;
    }
}

