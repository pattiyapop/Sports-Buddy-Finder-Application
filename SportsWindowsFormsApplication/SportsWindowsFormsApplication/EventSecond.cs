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
    public partial class EventSecond : Form
    {
        public EventSecond()
        {
            InitializeComponent();
        }

        private void showevent_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;user=root;password=4010;database=sportsbuddydb;";
            //string conn = "datasource=localhost;port=3306;username=root;password=4010;";
            MySqlConnection myconn = new MySqlConnection(conn);
            string sql = "SELECT * FROM `sportsbuddyevents` WHERE `id` = '" + 2 + "';";
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
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sports list = new Sports();
            list.ShowDialog();
        }

        private void profileview_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticProfilePage profile = new StaticProfilePage();
            profile.ShowDialog();
        }
    }
}
