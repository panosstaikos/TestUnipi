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
    public partial class Recommendation : Form
    {
        public int new_current_user_id;
        public Recommendation(int new_current_user_id)
        {
            InitializeComponent();
            this.new_current_user_id = new_current_user_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new Menu(new_current_user_id);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {
            // Establish connection to the SQLite database
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Retrieve the top 3 scores with specialty names, considering the number of clicks
                string query = @"SELECT s.Name AS SpecialtyName, st.Score, uc.Clicks
                         FROM Score_tracking st
                         INNER JOIN Specialities s ON st.Speciality_ID = s.ID
                         LEFT JOIN User_clicks uc ON st.Speciality_ID = uc.Specialities_id AND st.User_ID = uc.User_id
                         WHERE st.User_ID = @userId
                         ORDER BY st.Score DESC, uc.Clicks ASC
                         LIMIT 3";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Set parameter value for the query
                    command.Parameters.AddWithValue("@userId", new_current_user_id);  // Replace with the actual user ID

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int position = 1;

                        // Iterate over the result set
                        while (reader.Read())
                        {
                            string specialtyName = reader.GetString(0);
                            int score = reader.GetInt32(1);
                            int clicks = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);  // Consider the case when clicks are NULL

                            // Update the labels with specialty names, scores, and clicks
                            string recommendation = $"{specialtyName} - Score: {score}, Clicks: {clicks}";

                            if (position == 1)
                            {
                                chosenSpeciality1.Text = recommendation;
                            }
                            else if (position == 2)
                            {
                                chosenSpeciality2.Text = recommendation;
                            }
                            else if (position == 3)
                            {
                                chosenSpeciality3.Text = recommendation;
                            }

                            position++;
                        }
                    }
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Έδώ είναι η φόρμα σύστασης των τριών καλύτερων ειδικοτήτων για τον κάθε χρήστη, σύμφωνα με το μάθημα που θεώρησε ο ίδιος πιο ενδιαφέρον και επισκέφθηκε περισσότερες φορές, αλλά και πέτυχε καλό σκορ στο τεστ αξιολόγησης.", "Βοήθεια");
        }
    }
}
