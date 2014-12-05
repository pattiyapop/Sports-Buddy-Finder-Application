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
    public partial class StaticProfilePage : Form
    {
        public StaticProfilePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void editprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile eprofile = new EditProfile();
            eprofile.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateprofile_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;user=root;password=4010;database=sportsbuddydb;";
            MySqlConnection myconn = new MySqlConnection(conn);
            string sql = "SELECT * FROM `userdata` WHERE `id` = '" + 1 + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                label1.Text = dt.Rows[0][1] + "";
                label5.Text = dt.Rows[0][2] + "";
                label7.Text = dt.Rows[0][3] + "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
