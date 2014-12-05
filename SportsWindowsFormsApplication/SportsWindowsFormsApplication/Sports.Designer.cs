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
            this.sport2 = new System.Windows.Forms.LinkLabel();
            this.sport3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.backbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showevent = new System.Windows.Forms.Button();
            this.buddy1 = new System.Windows.Forms.TextBox();
            this.buddy2 = new System.Windows.Forms.TextBox();
            this.buddy3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SportsName
            // 
            this.SportsName.AutoSize = true;
            this.SportsName.Location = new System.Drawing.Point(40, 72);
            this.SportsName.Name = "SportsName";
            this.SportsName.Size = new System.Drawing.Size(68, 13);
            this.SportsName.TabIndex = 0;
            this.SportsName.Text = "Sports Name";
            this.SportsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuddiesNeeded
            // 
            this.BuddiesNeeded.AutoSize = true;
            this.BuddiesNeeded.Location = new System.Drawing.Point(186, 72);
            this.BuddiesNeeded.Name = "BuddiesNeeded";
            this.BuddiesNeeded.Size = new System.Drawing.Size(86, 13);
            this.BuddiesNeeded.TabIndex = 1;
            this.BuddiesNeeded.Text = "Buddies Needed";
            // 
            // sport2
            // 
            this.sport2.AutoSize = true;
            this.sport2.Location = new System.Drawing.Point(53, 185);
            this.sport2.Name = "sport2";
            this.sport2.Size = new System.Drawing.Size(41, 13);
            this.sport2.TabIndex = 4;
            this.sport2.TabStop = true;
            this.sport2.Text = "Event2";
            this.sport2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sport2_LinkClicked);
            // 
            // sport3
            // 
            this.sport3.AutoSize = true;
            this.sport3.Location = new System.Drawing.Point(53, 238);
            this.sport3.Name = "sport3";
            this.sport3.Size = new System.Drawing.Size(41, 13);
            this.sport3.TabIndex = 5;
            this.sport3.TabStop = true;
            this.sport3.Text = "Event3";
            this.sport3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sport3_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(53, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Event1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(266, 438);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(91, 26);
            this.backbutton.TabIndex = 11;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "View On Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Advanced Filter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // showevent
            // 
            this.showevent.Location = new System.Drawing.Point(137, 397);
            this.showevent.Name = "showevent";
            this.showevent.Size = new System.Drawing.Size(115, 23);
            this.showevent.TabIndex = 15;
            this.showevent.Text = "Show Event!";
            this.showevent.UseVisualStyleBackColor = true;
            this.showevent.Click += new System.EventHandler(this.showevent_Click);
            // 
            // buddy1
            // 
            this.buddy1.Location = new System.Drawing.Point(207, 120);
            this.buddy1.Name = "buddy1";
            this.buddy1.Size = new System.Drawing.Size(27, 20);
            this.buddy1.TabIndex = 16;
            this.buddy1.TextChanged += new System.EventHandler(this.buddy1_TextChanged);
            // 
            // buddy2
            // 
            this.buddy2.Location = new System.Drawing.Point(207, 181);
            this.buddy2.Name = "buddy2";
            this.buddy2.Size = new System.Drawing.Size(26, 20);
            this.buddy2.TabIndex = 17;
            this.buddy2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buddy3
            // 
            this.buddy3.Location = new System.Drawing.Point(207, 238);
            this.buddy3.Name = "buddy3";
            this.buddy3.Size = new System.Drawing.Size(26, 20);
            this.buddy3.TabIndex = 18;
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 514);
            this.Controls.Add(this.buddy3);
            this.Controls.Add(this.buddy2);
            this.Controls.Add(this.buddy1);
            this.Controls.Add(this.showevent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sport3);
            this.Controls.Add(this.sport2);
            this.Controls.Add(this.BuddiesNeeded);
            this.Controls.Add(this.SportsName);
            this.Name = "Sports";
            this.Text = "Sports Buddy Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SportsName;
        private System.Windows.Forms.Label BuddiesNeeded;
        private System.Windows.Forms.LinkLabel sport2;
        private System.Windows.Forms.LinkLabel sport3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showevent;
        private System.Windows.Forms.TextBox buddy1;
        private System.Windows.Forms.TextBox buddy2;
        private System.Windows.Forms.TextBox buddy3;

    }
}