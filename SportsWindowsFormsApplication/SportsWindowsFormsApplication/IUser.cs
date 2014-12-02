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
    public partial class IUser : Form
    {
        public IUser()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=4010;";
            string Query = "insert into sportsbuddydb.userdata (name,lastname,email,username,password) values( '" + this.name.Text + "','" + this.lastname.Text + "','" + this.email.Text + "','" + this.username.Text + "','" + this.password.Text + "') ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("User is created successfully!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
