namespace SportsWindowsFormsApplication
{
    partial class IEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.eventname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventstartdatetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.eventenddatetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buddiesneeded = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.locationnear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.needequipment = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genderneeded = new System.Windows.Forms.ComboBox();
            this.sport = new System.Windows.Forms.TextBox();
            this.sportslevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.SubmitEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // eventname
            // 
            this.eventname.Location = new System.Drawing.Point(138, 48);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(199, 20);
            this.eventname.TabIndex = 1;
            this.eventname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Start Date";
            // 
            // eventstartdatetime
            // 
            this.eventstartdatetime.Location = new System.Drawing.Point(138, 78);
            this.eventstartdatetime.Name = "eventstartdatetime";
            this.eventstartdatetime.Size = new System.Drawing.Size(200, 20);
            this.eventstartdatetime.TabIndex = 3;
            this.eventstartdatetime.ValueChanged += new System.EventHandler(this.eventstartdatetime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event End Date";
            // 
            // eventenddatetime
            // 
            this.eventenddatetime.Location = new System.Drawing.Point(138, 114);
            this.eventenddatetime.Name = "eventenddatetime";
            this.eventenddatetime.Size = new System.Drawing.Size(200, 20);
            this.eventenddatetime.TabIndex = 5;
            this.eventenddatetime.ValueChanged += new System.EventHandler(this.eventenddatetime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buddies Needed";
            // 
            // buddiesneeded
            // 
            this.buddiesneeded.Location = new System.Drawing.Point(138, 146);
            this.buddiesneeded.Name = "buddiesneeded";
            this.buddiesneeded.Size = new System.Drawing.Size(135, 20);
            this.buddiesneeded.TabIndex = 7;
            this.buddiesneeded.TextChanged += new System.EventHandler(this.buddiesneeded_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Location Near";
            // 
            // locationnear
            // 
            this.locationnear.FormattingEnabled = true;
            this.locationnear.Items.AddRange(new object[] {
            "Foggy Metro Metro Station",
            "G Street Garage",
            "Health and Wellness Center",
            "Marvin Center",
            "Mount Vernon Campus",
            "Crystal City Metro Station"});
            this.locationnear.Location = new System.Drawing.Point(138, 177);
            this.locationnear.Name = "locationnear";
            this.locationnear.Size = new System.Drawing.Size(199, 21);
            this.locationnear.TabIndex = 9;
            this.locationnear.SelectedIndexChanged += new System.EventHandler(this.locationnear_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(138, 213);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(200, 61);
            this.location.TabIndex = 11;
            this.location.Text = "";
            this.location.TextChanged += new System.EventHandler(this.location_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sport:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sports Level:";
            // 
            // needequipment
            // 
            this.needequipment.AutoSize = true;
            this.needequipment.Location = new System.Drawing.Point(42, 345);
            this.needequipment.Name = "needequipment";
            this.needequipment.Size = new System.Drawing.Size(111, 17);
            this.needequipment.TabIndex = 14;
            this.needequipment.Text = "Need Equipment?";
            this.needequipment.UseVisualStyleBackColor = true;
            this.needequipment.CheckedChanged += new System.EventHandler(this.needequipment_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gender Needed:";
            // 
            // genderneeded
            // 
            this.genderneeded.FormattingEnabled = true;
            this.genderneeded.Items.AddRange(new object[] {
            "Female Only",
            "Male Only",
            "Both Genders"});
            this.genderneeded.Location = new System.Drawing.Point(138, 364);
            this.genderneeded.Name = "genderneeded";
            this.genderneeded.Size = new System.Drawing.Size(121, 21);
            this.genderneeded.TabIndex = 16;
            this.genderneeded.SelectedIndexChanged += new System.EventHandler(this.genderneeded_SelectedIndexChanged);
            // 
            // sport
            // 
            this.sport.Location = new System.Drawing.Point(138, 291);
            this.sport.Name = "sport";
            this.sport.Size = new System.Drawing.Size(134, 20);
            this.sport.TabIndex = 17;
            this.sport.TextChanged += new System.EventHandler(this.sport_TextChanged);
            // 
            // sportslevel
            // 
            this.sportslevel.FormattingEnabled = true;
            this.sportslevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Professional"});
            this.sportslevel.Location = new System.Drawing.Point(138, 317);
            this.sportslevel.Name = "sportslevel";
            this.sportslevel.Size = new System.Drawing.Size(132, 21);
            this.sportslevel.TabIndex = 18;
            this.sportslevel.SelectedIndexChanged += new System.EventHandler(this.sportslevel_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Description:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(138, 405);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(196, 54);
            this.description.TabIndex = 20;
            this.description.Text = "";
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // SubmitEvent
            // 
            this.SubmitEvent.Location = new System.Drawing.Point(138, 487);
            this.SubmitEvent.Name = "SubmitEvent";
            this.SubmitEvent.Size = new System.Drawing.Size(93, 26);
            this.SubmitEvent.TabIndex = 21;
            this.SubmitEvent.Text = "Submit";
            this.SubmitEvent.UseVisualStyleBackColor = true;
            this.SubmitEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // IEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 551);
            this.Controls.Add(this.SubmitEvent);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sportslevel);
            this.Controls.Add(this.sport);
            this.Controls.Add(this.genderneeded);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.needequipment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.locationnear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buddiesneeded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventenddatetime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventstartdatetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.label1);
            this.Name = "IEvent";
            this.Text = "Create Sport Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker eventstartdatetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker eventenddatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buddiesneeded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox locationnear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox needequipment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox genderneeded;
        private System.Windows.Forms.TextBox sport;
        private System.Windows.Forms.ComboBox sportslevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button SubmitEvent;
    }
}