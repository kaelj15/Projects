namespace LINQ
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxStaff = new System.Windows.Forms.ListBox();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnZA = new System.Windows.Forms.Button();
            this.lbxSearch = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxStaff
            // 
            this.lbxStaff.FormattingEnabled = true;
            this.lbxStaff.Location = new System.Drawing.Point(12, 41);
            this.lbxStaff.Name = "lbxStaff";
            this.lbxStaff.Size = new System.Drawing.Size(165, 147);
            this.lbxStaff.TabIndex = 1;
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(93, 12);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(39, 23);
            this.btnAZ.TabIndex = 2;
            this.btnAZ.Text = "AZ";
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(138, 12);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(39, 23);
            this.btnZA.TabIndex = 3;
            this.btnZA.Text = "ZA";
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // lbxSearch
            // 
            this.lbxSearch.FormattingEnabled = true;
            this.lbxSearch.Location = new System.Drawing.Point(193, 41);
            this.lbxSearch.Name = "lbxSearch";
            this.lbxSearch.Size = new System.Drawing.Size(165, 147);
            this.lbxSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(193, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(84, 20);
            this.tbxSearch.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 203);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnZA);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.lbxStaff);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "CS - LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxStaff;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.ListBox lbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}

