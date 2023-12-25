using System.Data.SqlClient;
using System.Data.SQLite;

namespace MyCareerApp
{
    public partial class Theory : Form
    {
        public static string speciality;
        public static string speciality_id;
        public static int new_current_user_id;
        public Theory(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
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

        private void tles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TlesCoursesListForm tlesCoursesListForm = new TlesCoursesListForm(new_current_user_id);
            Close();
            tlesCoursesListForm.Show();
        }

        private void dys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DysCourseList2 dysCoursesListForm = new DysCourseList2(new_current_user_id);
            Close();
            dysCoursesListForm.Show();
        }

        private void psy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PsyCoursesListForm psyCoursesListForm = new PsyCoursesListForm(new_current_user_id);
            Close();
            psyCoursesListForm.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατήστε πάνω στην κατεύθυνση την οποία θέλετε να μελετήσετε πατώντας κλικ πάνω της.", "Βοήθεια");
        }
    }
}
