using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DATABASEINFOMAN
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtNewPassword.Text.Trim();
                string confirmPass = txtConfirmPassword.Text.Trim();

                if (password != confirmPass)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, MyConn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }

                    string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, MyConn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Sign-up successful! You can now sign in.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
