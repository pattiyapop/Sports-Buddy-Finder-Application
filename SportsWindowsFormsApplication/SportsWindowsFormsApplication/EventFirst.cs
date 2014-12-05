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
    public partial class EventFirst : Form
    {
        public EventFirst()
        {
            InitializeComponent();
        }

        // A button that once clicks everything shows up!
        private void sportname_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // A button that once clicks everything shows up!
        private void showevent_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;user=root;password=4010;database=sportsbuddydb;";
            MySqlConnection myconn = new MySqlConnection(conn);
            string sql = "SELECT * FROM `sportsbuddyevents` WHERE `id` = '" + 1 + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                sportname.Text = dt.Rows[0][1] + "";
                starttime.Text = dt.Rows[0][2] + "";
                endtime.Text = dt.Rows[0][3] + "";
                buddiesneeded.Text = dt.Rows[0][4] + "";
                locationnear.Text = dt.Rows[0][5] + "";
                location.Text = dt.Rows[0][6] + "";
                sport.Text = dt.Rows[0][7] + "";
                sportslevel.Text = dt.Rows[0][8] + "";
                genderneeded.Text = dt.Rows[0][10] + "";
                description.Text = dt.Rows[0][11] + "";
                Console.WriteLine(dt.Rows.Count);  
                // This part is for debugging only.
                foreach (DataRow dataRow in dt.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                    Console.WriteLine(item);
                    }
                }
           }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void starttime_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sports list = new Sports();
            list.ShowDialog();
        }

        private void endtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void buddiesneeded_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void locationnear_TextChanged(object sender, EventArgs e)
        {

        }

        private void join_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventConfirmation confirm = new EventConfirmation();
            confirm.ShowDialog();
        }

        private void profileview_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticProfilePage profile = new StaticProfilePage();
            profile.ShowDialog();
        }
    }
}
