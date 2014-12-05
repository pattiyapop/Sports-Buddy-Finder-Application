namespace SportsWindowsFormsApplication
{
    partial class SportsCreated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsCreated));
            this.showevent = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endtime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sportname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showevent
            // 
            this.showevent.Location = new System.Drawing.Point(48, 436);
            this.showevent.Name = "showevent";
            this.showevent.Size = new System.Drawing.Size(141, 23);
            this.showevent.TabIndex = 44;
            this.showevent.Text = "Show Sport Details!";
            this.showevent.UseVisualStyleBackColor = true;
            this.showevent.Click += new System.EventHandler(this.showevent_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(152, 216);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(192, 20);
            this.location.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Location";
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(152, 176);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(192, 20);
            this.endtime.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "End Time";
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(152, 139);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(192, 20);
            this.starttime.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Event Name";
            // 
            // sportname
            // 
            this.sportname.Location = new System.Drawing.Point(152, 97);
            this.sportname.Name = "sportname";
            this.sportname.Size = new System.Drawing.Size(192, 20);
            this.sportname.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Sports Created";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Location = new System.Drawing.Point(75, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 90);
            this.richTextBox1.TabIndex = 79;
            this.richTextBox1.Text = "You have successfully created a sport!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SportsCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sportname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showevent);
            this.Name = "SportsCreated";
            this.Text = "Sports Buddy Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showevent;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sportname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;

    }
}