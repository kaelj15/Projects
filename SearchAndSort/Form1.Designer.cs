namespace SearchAndSort
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
            this.gbxLoad = new System.Windows.Forms.GroupBox();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.lbxSorted = new System.Windows.Forms.ListBox();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rdoEndsWith = new System.Windows.Forms.RadioButton();
            this.rdoContains = new System.Windows.Forms.RadioButton();
            this.rdoStartsWith = new System.Windows.Forms.RadioButton();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.lbxSearch = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxLoad.SuspendLayout();
            this.gbxSort.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load People";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbxLoad
            // 
            this.gbxLoad.Controls.Add(this.lbxPeople);
            this.gbxLoad.Controls.Add(this.btnLoad);
            this.gbxLoad.Location = new System.Drawing.Point(12, 12);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(216, 344);
            this.gbxLoad.TabIndex = 6;
            this.gbxLoad.TabStop = false;
            this.gbxLoad.Text = "Load";
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(6, 52);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(199, 277);
            this.lbxPeople.TabIndex = 8;
            // 
            // gbxSort
            // 
            this.gbxSort.Controls.Add(this.btnSortZA);
            this.gbxSort.Controls.Add(this.lbxSorted);
            this.gbxSort.Controls.Add(this.btnSortAZ);
            this.gbxSort.Location = new System.Drawing.Point(247, 12);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Size = new System.Drawing.Size(216, 344);
            this.gbxSort.TabIndex = 7;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "Sort";
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(121, 19);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(84, 23);
            this.btnSortZA.TabIndex = 9;
            this.btnSortZA.Text = "Sort ZA";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // lbxSorted
            // 
            this.lbxSorted.FormattingEnabled = true;
            this.lbxSorted.Location = new System.Drawing.Point(6, 52);
            this.lbxSorted.Name = "lbxSorted";
            this.lbxSorted.Size = new System.Drawing.Size(199, 277);
            this.lbxSorted.TabIndex = 8;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(6, 19);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(85, 23);
            this.btnSortAZ.TabIndex = 0;
            this.btnSortAZ.Text = "Sort AZ";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.rdoEndsWith);
            this.gbxSearch.Controls.Add(this.rdoContains);
            this.gbxSearch.Controls.Add(this.rdoStartsWith);
            this.gbxSearch.Controls.Add(this.btnSaveSelected);
            this.gbxSearch.Controls.Add(this.lbxSearch);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Location = new System.Drawing.Point(469, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(405, 344);
            this.gbxSearch.TabIndex = 10;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(188, 20);
            this.tbxSearch.TabIndex = 13;
            // 
            // rdoEndsWith
            // 
            this.rdoEndsWith.AutoSize = true;
            this.rdoEndsWith.Location = new System.Drawing.Point(6, 109);
            this.rdoEndsWith.Name = "rdoEndsWith";
            this.rdoEndsWith.Size = new System.Drawing.Size(74, 17);
            this.rdoEndsWith.TabIndex = 12;
            this.rdoEndsWith.TabStop = true;
            this.rdoEndsWith.Text = "Ends With";
            this.rdoEndsWith.UseVisualStyleBackColor = true;
            // 
            // rdoContains
            // 
            this.rdoContains.AutoSize = true;
            this.rdoContains.Location = new System.Drawing.Point(6, 132);
            this.rdoContains.Name = "rdoContains";
            this.rdoContains.Size = new System.Drawing.Size(66, 17);
            this.rdoContains.TabIndex = 11;
            this.rdoContains.TabStop = true;
            this.rdoContains.Text = "Contains";
            this.rdoContains.UseVisualStyleBackColor = true;
            // 
            // rdoStartsWith
            // 
            this.rdoStartsWith.AutoSize = true;
            this.rdoStartsWith.Location = new System.Drawing.Point(6, 86);
            this.rdoStartsWith.Name = "rdoStartsWith";
            this.rdoStartsWith.Size = new System.Drawing.Size(77, 17);
            this.rdoStartsWith.TabIndex = 10;
            this.rdoStartsWith.TabStop = true;
            this.rdoStartsWith.Text = "Starts With";
            this.rdoStartsWith.UseVisualStyleBackColor = true;
            this.rdoStartsWith.CheckedChanged += new System.EventHandler(this.rdoStartsWith_CheckedChanged);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Location = new System.Drawing.Point(25, 262);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(107, 50);
            this.btnSaveSelected.TabIndex = 9;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // lbxSearch
            // 
            this.lbxSearch.FormattingEnabled = true;
            this.lbxSearch.Location = new System.Drawing.Point(200, 52);
            this.lbxSearch.Name = "lbxSearch";
            this.lbxSearch.Size = new System.Drawing.Size(199, 277);
            this.lbxSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 392);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxSort);
            this.Controls.Add(this.gbxLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLoad.ResumeLayout(false);
            this.gbxSort.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox gbxLoad;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.GroupBox gbxSort;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.ListBox lbxSorted;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rdoEndsWith;
        private System.Windows.Forms.RadioButton rdoContains;
        private System.Windows.Forms.RadioButton rdoStartsWith;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.ListBox lbxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

