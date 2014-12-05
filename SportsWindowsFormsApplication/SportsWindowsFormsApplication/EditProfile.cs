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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticProfilePage eprofile = new StaticProfilePage();
            eprofile.ShowDialog();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=4010;";
            string Query = "update sportsbuddydb.userdata set name='" + this.firstname.Text + "',lastname='" + this.lastname.Text + "',email='" + this.emailText.Text + "' where username='" + this.usernameText.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Profile is updated!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            StaticProfilePage eprofile = new StaticProfilePage();
            eprofile.ShowDialog();
        }
    }
}
