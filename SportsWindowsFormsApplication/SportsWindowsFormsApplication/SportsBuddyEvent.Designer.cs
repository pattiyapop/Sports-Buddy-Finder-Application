namespace SportsWindowsFormsApplication
{
    partial class SportsBuddyEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsBuddyEvent));
            this.EventDetails = new System.Windows.Forms.DataGridView();
            this.Events = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDetails
            // 
            this.EventDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDetails.Location = new System.Drawing.Point(46, 46);
            this.EventDetails.Name = "EventDetails";
            this.EventDetails.Size = new System.Drawing.Size(299, 170);
            this.EventDetails.TabIndex = 1;
            this.EventDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Events
            // 
            this.Events.Location = new System.Drawing.Point(122, 362);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(111, 47);
            this.Events.TabIndex = 2;
            this.Events.Text = "Load Events";
            this.Events.UseVisualStyleBackColor = true;
            this.Events.Click += new System.EventHandler(this.Events_Click);
            // 
            // SportsBuddyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 513);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.EventDetails);
            this.Name = "SportsBuddyEvent";
            this.Text = "Event Details";
            ((System.ComponentModel.ISupportInitialize)(this.EventDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EventDetails;
        private System.Windows.Forms.Button Events;
    }
}