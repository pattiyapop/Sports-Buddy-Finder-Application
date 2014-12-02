namespace SportsWindowsFormsApplication
{
    partial class Sports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sports));
            this.SportsName = new System.Windows.Forms.Label();
            this.BuddiesNeeded = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.Label();
            this.sport1 = new System.Windows.Forms.LinkLabel();
            this.sport2 = new System.Windows.Forms.LinkLabel();
            this.sport3 = new System.Windows.Forms.LinkLabel();
            this.sport4 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SportsName
            // 
            this.SportsName.AutoSize = true;
            this.SportsName.Location = new System.Drawing.Point(38, 72);
            this.SportsName.Name = "SportsName";
            this.SportsName.Size = new System.Drawing.Size(68, 13);
            this.SportsName.TabIndex = 0;
            this.SportsName.Text = "Sports Name";
            this.SportsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuddiesNeeded
            // 
            this.BuddiesNeeded.AutoSize = true;
            this.BuddiesNeeded.Location = new System.Drawing.Point(169, 72);
            this.BuddiesNeeded.Name = "BuddiesNeeded";
            this.BuddiesNeeded.Size = new System.Drawing.Size(86, 13);
            this.BuddiesNeeded.TabIndex = 1;
            this.BuddiesNeeded.Text = "Buddies Needed";
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Location = new System.Drawing.Point(304, 72);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(34, 13);
            this.Detail.TabIndex = 2;
            this.Detail.Text = "Detail";
            // 
            // sport1
            // 
            this.sport1.AutoSize = true;
            this.sport1.Location = new System.Drawing.Point(38, 132);
            this.sport1.Name = "sport1";
            this.sport1.Size = new System.Drawing.Size(111, 13);
            this.sport1.TabIndex = 3;
            this.sport1.TabStop = true;
            this.sport1.Text = "Sunday Night Football";
            this.sport1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // sport2
            // 
            this.sport2.AutoSize = true;
            this.sport2.Location = new System.Drawing.Point(38, 185);
            this.sport2.Name = "sport2";
            this.sport2.Size = new System.Drawing.Size(57, 13);
            this.sport2.TabIndex = 4;
            this.sport2.TabStop = true;
            this.sport2.Text = "Girl Tennis";
            // 
            // sport3
            // 
            this.sport3.AutoSize = true;
            this.sport3.Location = new System.Drawing.Point(38, 238);
            this.sport3.Name = "sport3";
            this.sport3.Size = new System.Drawing.Size(65, 13);
            this.sport3.TabIndex = 5;
            this.sport3.TabStop = true;
            this.sport3.Text = "Soccer King";
            // 
            // sport4
            // 
            this.sport4.AutoSize = true;
            this.sport4.Location = new System.Drawing.Point(38, 294);
            this.sport4.Name = "sport4";
            this.sport4.Size = new System.Drawing.Size(58, 13);
            this.sport4.TabIndex = 6;
            this.sport4.TabStop = true;
            this.sport4.Text = "Tennis Pro";
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 514);
            this.Controls.Add(this.sport4);
            this.Controls.Add(this.sport3);
            this.Controls.Add(this.sport2);
            this.Controls.Add(this.sport1);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.BuddiesNeeded);
            this.Controls.Add(this.SportsName);
            this.Name = "Sports";
            this.Text = "Sports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SportsName;
        private System.Windows.Forms.Label BuddiesNeeded;
        private System.Windows.Forms.Label Detail;
        private System.Windows.Forms.LinkLabel sport1;
        private System.Windows.Forms.LinkLabel sport2;
        private System.Windows.Forms.LinkLabel sport3;
        private System.Windows.Forms.LinkLabel sport4;

    }
}