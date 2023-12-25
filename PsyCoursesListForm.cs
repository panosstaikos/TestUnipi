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
    public partial class PsyCoursesListForm : Form
    {
        int new_current_user_id;
        public PsyCoursesListForm(int current_user_id)
        {
            InitializeComponent();
            this.new_current_user_id = current_user_id;
        }

        private void cryptographyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(8, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 8);
            Close();
            showTheory.Show();
        }


        private void hlektronikonEpixeirinLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 1);
            Close();
            showTheory.Show();
        }

        private void systhmataApofasewnLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(9, new_current_user_id);
            UpdateUserClicks(new_current_user_id, 9);
            Close();
            showTheory.Show();
        }

        //Code for updating the clicks form a specific user to a specific course in 
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
