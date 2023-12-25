//Code for updating the clicks form a specific user to a specific course in 
using System.Data.SQLite;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCareerApp
{
    public partial class TlesCoursesListForm : Form
    {
        int new_current_user_id;
        public TlesCoursesListForm(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }


        private void sdvdProcessLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(3, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 3);
            Close();
            showTheory.Show();
        }

        private void logikosProgrammatismosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(4, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 4);
            Close();
            showTheory.Show();
        }

        private void eikonikiPragmatikotitaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(2, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 2);
            Close();
            showTheory.Show();
        }

        private void UpdateUserClicks(int userId, int specialityId)
        {
            string connectionString = "Data Source=User.db;Version=3;";
            string sql = "INSERT INTO User_clicks (User_id, Specialities_id, Clicks) " +
                         "VALUES (@userId, @specialityId, 1) " +
                         "ON CONFLICT(User_id, Specialities_id) DO UPDATE SET Clicks = Clicks + 1";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@specialityId", specialityId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Theory theory = new Theory(new_current_user_id);
            Close();
            theory.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διαλέξτε ένα από τα μαθήματα της κατεύθυνσης το οποίο θα σας ενδιέφερε να μελετήσετε και να ασχοληθείτε περαιτέρω.", "Βοήθεια");
        }
    }
}
