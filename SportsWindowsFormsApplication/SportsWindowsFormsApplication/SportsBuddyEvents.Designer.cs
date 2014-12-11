namespace SportsWindowsFormsApplication
{
    partial class SportsBuddyEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsBuddyEvents));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.profileview = new System.Windows.Forms.Button();
            this.endtime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sportname = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Location = new System.Drawing.Point(74, 334);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 90);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "You are now a sports buddy of Happy Tennis! \nEnjoy your time.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirmation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sports List View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileview
            // 
            this.profileview.Location = new System.Drawing.Point(32, 465);
            this.profileview.Name = "profileview";
            this.profileview.Size = new System.Drawing.Size(85, 28);
            this.profileview.TabIndex = 44;
            this.profileview.Text = "View Profile";
            this.profileview.UseVisualStyleBackColor = true;
            this.profileview.Click += new System.EventHandler(this.profileview_Click);
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(151, 181);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(192, 20);
            this.endtime.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "End Time";
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(151, 144);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(192, 20);
            this.starttime.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Event Name";
            // 
            // sportname
            // 
            this.sportname.Location = new System.Drawing.Point(151, 102);
            this.sportname.Name = "sportname";
            this.sportname.Size = new System.Drawing.Size(192, 20);
            this.sportname.TabIndex = 62;
            this.sportname.TextChanged += new System.EventHandler(this.sportname_TextChanged);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(151, 221);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(192, 20);
            this.location.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Location";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 70;
            this.button3.Text = "Show Confirmation!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EventConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 533);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sportname);
            this.Controls.Add(this.profileview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "EventConfirmation";
            this.Text = "Sports Buddy Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button profileview;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sportname;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}