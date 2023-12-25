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
    public partial class chooseTest : Form
    {
        public static int speciality_id;
        public static int new_current_user_id;

        public chooseTest(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new(new_current_user_id);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 9;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void dataAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Πρεπει να το φτιαξω
            speciality_id = 0;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void computerSystemAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 3;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void videoGameDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 2;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void userExperienceDesign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 4;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void informationSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 1;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void networkEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 8;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void machineLearning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 5;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void webDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 6;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }
        private void webDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality_id = 7;
            Test test = new Test(speciality_id, new_current_user_id);
            Close();
            test.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατήστε κλικ πάνω στην ειδικότητα που θέλετε να κάνετε τεστ αξιόλογησης πάνω σε αυτήν. Έπειτα θα ανακατευθυνθείτε στο τεστ.", "Βοήθεια");
        }

        private void chooseTest_Load(object sender, EventArgs e)
        {

        }
    }
}
