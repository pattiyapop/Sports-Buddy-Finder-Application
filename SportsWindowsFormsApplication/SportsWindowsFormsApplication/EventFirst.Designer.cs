namespace SportsWindowsFormsApplication
{
    partial class EventFirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventFirst));
            this.sportname = new System.Windows.Forms.TextBox();
            this.showevent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buddiesneeded = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locationnear = new System.Windows.Forms.TextBox();
            this.sportslevel = new System.Windows.Forms.TextBox();
            this.genderneeded = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.endtime = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.profileview = new System.Windows.Forms.Button();
            this.join = new System.Windows.Forms.Button();
            this.waitlistbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sportname
            // 
            this.sportname.Location = new System.Drawing.Point(149, 89);
            this.sportname.Name = "sportname";
            this.sportname.Size = new System.Drawing.Size(192, 20);
            this.sportname.TabIndex = 0;
            this.sportname.TextChanged += new System.EventHandler(this.sportname_TextChanged);
            // 
            // showevent
            // 
            this.showevent.Location = new System.Drawing.Point(22, 41);
            this.showevent.Name = "showevent";
            this.showevent.Size = new System.Drawing.Size(75, 23);
            this.showevent.TabIndex = 1;
            this.showevent.Text = "Show!";
            this.showevent.UseVisualStyleBackColor = true;
            this.showevent.Click += new System.EventHandler(this.showevent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Time";
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(149, 131);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(192, 20);
            this.starttime.TabIndex = 4;
            this.starttime.TextChanged += new System.EventHandler(this.starttime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Description:";
            // 
            // sport
            // 
            this.sport.Location = new System.Drawing.Point(149, 306);
            this.sport.Name = "sport";
            this.sport.Size = new System.Drawing.Size(192, 20);
            this.sport.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Gender Needed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sports Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sport:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Location Near";
            // 
            // buddiesneeded
            // 
            this.buddiesneeded.Location = new System.Drawing.Point(149, 203);
            this.buddiesneeded.Name = "buddiesneeded";
            this.buddiesneeded.Size = new System.Drawing.Size(192, 20);
            this.buddiesneeded.TabIndex = 22;
            this.buddiesneeded.TextChanged += new System.EventHandler(this.buddiesneeded_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Buddies Needed";
            // 
            // locationnear
            // 
            this.locationnear.Location = new System.Drawing.Point(149, 235);
            this.locationnear.Name = "locationnear";
            this.locationnear.Size = new System.Drawing.Size(192, 20);
            this.locationnear.TabIndex = 36;
            this.locationnear.TextChanged += new System.EventHandler(this.locationnear_TextChanged);
            // 
            // sportslevel
            // 
            this.sportslevel.Location = new System.Drawing.Point(149, 342);
            this.sportslevel.Name = "sportslevel";
            this.sportslevel.Size = new System.Drawing.Size(192, 20);
            this.sportslevel.TabIndex = 37;
            // 
            // genderneeded
            // 
            this.genderneeded.Location = new System.Drawing.Point(149, 384);
            this.genderneeded.Name = "genderneeded";
            this.genderneeded.Size = new System.Drawing.Size(192, 20);
            this.genderneeded.TabIndex = 38;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(282, 474);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(85, 28);
            this.backbutton.TabIndex = 39;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(149, 168);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(192, 20);
            this.endtime.TabIndex = 40;
            this.endtime.TextChanged += new System.EventHandler(this.endtime_TextChanged);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(149, 273);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(192, 20);
            this.location.TabIndex = 41;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(149, 421);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(192, 20);
            this.description.TabIndex = 42;
            // 
            // profileview
            // 
            this.profileview.Location = new System.Drawing.Point(12, 474);
            this.profileview.Name = "profileview";
            this.profileview.Size = new System.Drawing.Size(85, 28);
            this.profileview.TabIndex = 43;
            this.profileview.Text = "View Profile";
            this.profileview.UseVisualStyleBackColor = true;
            this.profileview.Click += new System.EventHandler(this.profileview_Click);
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(100, 475);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(85, 28);
            this.join.TabIndex = 44;
            this.join.Text = "Join";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // waitlistbutton
            // 
            this.waitlistbutton.Location = new System.Drawing.Point(191, 475);
            this.waitlistbutton.Name = "waitlistbutton";
            this.waitlistbutton.Size = new System.Drawing.Size(85, 28);
            this.waitlistbutton.TabIndex = 45;
            this.waitlistbutton.Text = "Waitlist";
            this.waitlistbutton.UseVisualStyleBackColor = true;
            // 
            // EventFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 516);
            this.Controls.Add(this.waitlistbutton);
            this.Controls.Add(this.join);
            this.Controls.Add(this.profileview);
            this.Controls.Add(this.description);
            this.Controls.Add(this.location);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.genderneeded);
            this.Controls.Add(this.sportslevel);
            this.Controls.Add(this.locationnear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buddiesneeded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showevent);
            this.Controls.Add(this.sportname);
            this.Name = "EventFirst";
            this.Text = "Sports Buddy Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sportname;
        private System.Windows.Forms.Button showevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buddiesneeded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox locationnear;
        private System.Windows.Forms.TextBox sportslevel;
        private System.Windows.Forms.TextBox genderneeded;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button profileview;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button waitlistbutton;
    }
}