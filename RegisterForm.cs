using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCareerApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void haveAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";
            string query;

            string username = registerUsernameTextBox.Text.Trim();
            string password = registerPasswordTextBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            // Check if the username already exists.
            query = "SELECT * FROM Users WHERE Username=@username";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                }
            }

            // If we get here, the username does not exist and the fields are not empty, so we can proceed with the registration.
            query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!");
                    Close();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συμπληρώστε τα στοιχεία που θα χρησιμοποιείτε για να συνδέεστε στο λογαριασμό σας στην εφαρμογή..", "Βοήθεια");
        }
    }
 }
