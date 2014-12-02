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
    public partial class SportsBuddyEvent : Form
    {
        public SportsBuddyEvent()
        {
            InitializeComponent();
            load_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void load_table()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=4010;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            // Select only event name from database
            MySqlCommand cmdDataBase = new MySqlCommand("select * from sportsbuddydb.sportsbuddyeventsv4 ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                EventDetails.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Events_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=4010;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from sportsbuddydb.sportsbuddyeventsv4 ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                EventDetails.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
