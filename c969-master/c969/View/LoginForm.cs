using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace c969
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Test all of this
            using (MySqlCommand getUserCommand = new MySqlCommand("SELECT COUNT(*) FROM user WHERE userName = @username AND password = @password", Database.connection))
            {
                string userName = usernameBox.Text;
                Database.OpenDatabase();
                getUserCommand.Parameters.AddWithValue("@username", usernameBox.Text);
                getUserCommand.Parameters.AddWithValue("@password", passwordBox.Text);
                int userCount = Convert.ToInt32(getUserCommand.ExecuteScalar());
                if (userCount > 0)
                {
                    new MainForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username and Password do not match.");
                }
            }

            //get user culture
            //var culture = new System.Threading.Thread(() => { }).CurrentCulture;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
