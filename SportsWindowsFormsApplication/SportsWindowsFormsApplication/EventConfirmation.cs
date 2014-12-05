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
    public partial class EventConfirmation : Form
    {
        public EventConfirmation()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sportname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                location.Text = dt.Rows[0][6] + "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
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
