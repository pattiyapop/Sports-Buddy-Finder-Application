using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportsWindowsFormsApplication
{
    public partial class IEvent : Form
    {
        public IEvent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string constring = "datasource=localhost;port=3306;username=root;password=4010;";
            string Query = "insert into sportsbuddydb.sportsbuddyevents (eventname,eventstartdatetime,eventenddatetime,buddiesneeded,locationnear,location,sport,sportslevel,needequipment,genderneeded,description) values( '" + this.eventname.Text + "','" + this.eventstartdatetime.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + this.eventenddatetime.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + this.buddiesneeded.Text + "','" + this.locationnear.Text + "','" + this.location.Text + "','" + this.sport.Text + "','" + this.sportslevel.Text + "','" + this.needequipment.Text + "','" + this.genderneeded.Text + "','" + this.description.Text + "') ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try{
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Event is created successfully!");
                while(myReader.Read()) {

                }
                this.Hide();
                SportsCreated home = new SportsCreated();
                home.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eventstartdatetime_ValueChanged(object sender, EventArgs e)
        {
            eventstartdatetime.Format = DateTimePickerFormat.Custom;
            eventstartdatetime.CustomFormat = "MM/dd/yyyy hh:mm";
        }

        private void eventenddatetime_ValueChanged(object sender, EventArgs e)
        {
            eventenddatetime.Format = DateTimePickerFormat.Custom;
            eventenddatetime.CustomFormat = "MM dd yyyy hh mm ss";
        }

        private void locationnear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void needequipment_CheckedChanged(object sender, EventArgs e)
        {
            if (needequipment.Checked)
            {
                needequipment.Text = "Checked";
            }
            else
            {
                needequipment.Text = "Unchecked";
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderneeded_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sportslevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sport_TextChanged(object sender, EventArgs e)
        {

        }

        private void buddiesneeded_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
