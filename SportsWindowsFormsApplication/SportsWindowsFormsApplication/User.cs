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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=4010;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from sportsbuddydb.userdata where username ='" + this.username_text.Text + "' and password ='" + this.password_text.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("You are now logged in");
                    // After login is completed, we need to go to our homepage
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error: Invalid username or password! Please register as a user.");
                }
                myConn.Close();
            }
           catch (Exception ex) {
               MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IUser home = new IUser();
            home.ShowDialog();
        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
