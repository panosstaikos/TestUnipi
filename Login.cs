using System.Data.SQLite;

namespace MyCareerApp
{
    public partial class Login : Form
    {
        public static int current_user_id;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Set the current_user_id variable to the ID of the logged-in user
                        if (reader.Read())
                        {
                            current_user_id = reader.GetInt32(reader.GetOrdinal("ID"));
                        }

                        MessageBox.Show("Επιτυχής Σύνδεση!");
                        Menu menu = new Menu(current_user_id);
                        Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συνδεθείτε με τα στοιχεία που χρησιμοποιήσατε κατά την εγγραφή σας, ώστε να συνδεθείτε.", "Βοήθεια");
        }
    }
}