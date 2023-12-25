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
    public partial class Menu : Form
    {
        public static int new_current_user_id;
        public Menu(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
            nameLabel.Text = current_user_id.ToString();
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            Close();
            Theory theoryForm= new Theory(new_current_user_id);
            theoryForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Close();
            chooseTest chooseTest = new(new_current_user_id);
            chooseTest.Show();
        }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            Close();
            Recommendation recommendation = new(new_current_user_id);
            recommendation.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Βρίσκεστε στο κεντρικό μενού. Επιλέξτε που θέλετε να ανακετευθυνθείτε πατώντας πάνω στο αντίστοιχο κουμπί.", "Βοήθεια");
        }
    }
}
