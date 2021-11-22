namespace Threading
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.pbxRed = new System.Windows.Forms.PictureBox();
            this.pbxGreen = new System.Windows.Forms.PictureBox();
            this.pbxBlue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(93, 15);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(100, 20);
            this.tbxRed.TabIndex = 1;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(305, 15);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(100, 20);
            this.tbxBlue.TabIndex = 2;
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(199, 15);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(100, 20);
            this.tbxGreen.TabIndex = 3;
            // 
            // pbxRed
            // 
            this.pbxRed.BackColor = System.Drawing.Color.Red;
            this.pbxRed.Location = new System.Drawing.Point(93, 470);
            this.pbxRed.Name = "pbxRed";
            this.pbxRed.Size = new System.Drawing.Size(100, 10);
            this.pbxRed.TabIndex = 4;
            this.pbxRed.TabStop = false;
            // 
            // pbxGreen
            // 
            this.pbxGreen.BackColor = System.Drawing.Color.Green;
            this.pbxGreen.Location = new System.Drawing.Point(199, 470);
            this.pbxGreen.Name = "pbxGreen";
            this.pbxGreen.Size = new System.Drawing.Size(100, 10);
            this.pbxGreen.TabIndex = 5;
            this.pbxGreen.TabStop = false;
            // 
            // pbxBlue
            // 
            this.pbxBlue.BackColor = System.Drawing.Color.Blue;
            this.pbxBlue.Location = new System.Drawing.Point(305, 470);
            this.pbxBlue.Name = "pbxBlue";
            this.pbxBlue.Size = new System.Drawing.Size(100, 10);
            this.pbxBlue.TabIndex = 6;
            this.pbxBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 492);
            this.Controls.Add(this.pbxBlue);
            this.Controls.Add(this.pbxGreen);
            this.Controls.Add(this.pbxRed);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxRed);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.PictureBox pbxRed;
        private System.Windows.Forms.PictureBox pbxGreen;
        private System.Windows.Forms.PictureBox pbxBlue;
    }
}

