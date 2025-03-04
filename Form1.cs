using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Admin Login"; // Set form title
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open the Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            string connectionString = "Data Source=users.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Check if Users table exists
                string checkTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='Users'";
                using (SQLiteCommand tableCheckCmd = new SQLiteCommand(checkTableQuery, conn))
                {
                    object result = tableCheckCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Users table does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Authenticate user
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        private bool TableExists(string tableName)
        {
            string connectionString = "Data Source=users.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tableName", tableName);
                    object result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Leave empty if not needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
