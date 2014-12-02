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
        public Sports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            IUser home = new IUser();
            home.ShowDialog();
        }
    }
}
