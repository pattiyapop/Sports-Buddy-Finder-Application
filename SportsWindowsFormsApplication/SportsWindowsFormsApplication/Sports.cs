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
    public partial class Sports : Form
    {

        public string sportname;
        public Sports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }


        private void detail1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventFirst eventfirst = new EventFirst();
            eventfirst.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EventFirst eventfirst = new EventFirst();
            eventfirst.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void showevent_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;user=root;password=4010;database=sportsbuddydb;";
            MySqlConnection myconn = new MySqlConnection(conn);
            //string sql = "SELECT * FROM `sportsbuddyevents` WHERE `id` = '" + 1 + "';";
            string sql = "SELECT * FROM `sportsbuddyevents`;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                linkLabel1.Text = dt.Rows[0][1] + "";
                buddy1.Text = dt.Rows[0][4] + "";      
                sport2.Text = dt.Rows[1][1] + "";
                buddy2.Text = dt.Rows[1][4] + "";
                sport3.Text = dt.Rows[2][1] + "";
                buddy3.Text = dt.Rows[2][4] + "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void event1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buddy1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sport2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EventSecond eventsecond = new EventSecond();
            eventsecond.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sport3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EventSecond eventsecond = new EventSecond();
            eventsecond.ShowDialog();
        }
    }
}
