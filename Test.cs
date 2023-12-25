using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Test : Form
    {
        private int speciality_id;
        private int score;
        public int new_current_user_id;
        public Test(int speciality, int current_user_id)

        {
            InitializeComponent();
            new_current_user_id = current_user_id;
            this.speciality_id = speciality;
            score = 0;

            // Retrieve the specialty name from the database
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Specialities WHERE ID = @specialityId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@specialityId", speciality_id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string specialtyName = reader.GetString(0);

                            // Set the label text to the specialty name
                            label1.Text = specialtyName;
                        }
                    }
                }
            }



            // Check the value of speciality and add specific options accordingly
            if (speciality_id == 3)
            {
                // Question 1
                question1.Text = "Ποια είναι η έννοια και ο ρόλος των συστημάτων διαχείρισης βάσεων δεδομένων (ΣΔΒΔ) στο πλαίσιο της πληροφορικής?";
                radioButton1.Text = "Διαχειρίζονται τον αποθηκευτικό χώρο των δεδομένων";
                radioButton2.Text = "Δημιουργούν γραφικά περιβάλλοντα χρήστη";
                radioButton3.Text = "Αναλύουν την κίνηση του δικτύου";
                radioButton4.Text = "Διασφαλίζουν την ασφάλεια των δεδομένων";
                // Correct answer: radioButton1

                // Question 2
                question2.Text = "Ποιο από τα παρακάτω αναφέρεται σε μοντέλα δεδομένων?";
                radioButton5.Text = "Ιεραρχικό μοντέλο, δίκτυο μοντέλο, σχεσιακό μοντέλο, αντικειμενοστραφές μοντέλο";
                radioButton6.Text = "Ανάλυση, σχεδιασμός, υλοποίηση, διαχείριση";
                radioButton7.Text = "Επιλογή, εισαγωγή, ενημέρωση, διαγραφή";
                radioButton8.Text = "Δομημένος, ακαθάρτων, ασταθής, εκχώρηση";
                // Correct answer: radioButton5

                // Question 3
                question3.Text = "Ποια γλώσσα χρησιμοποιείται για τη διαχείριση και ανάκτηση δεδομένων από μια βάση δεδομένων?";
                radioButton9.Text = "SQL (Structured Query Language)";
                radioButton10.Text = "C#";
                radioButton11.Text = "Python";
                radioButton12.Text = "JavaScript";
                // Correct answer: radioButton9


            }
            else if (speciality_id == 4)
            {
                // Question 1
                question1.Text = "Ποια είναι η έννοια του λογικού προγραμματισμού και η διαφορά του από τον προστακτικό προγραμματισμό;";
                radioButton1.Text = "Αναλύει την κίνηση του δικτύου";
                radioButton2.Text = "Χρησιμοποιεί λογικούς κανόνες για την αυτόματη εκτέλεση προγραμμάτων";
                radioButton3.Text = "Δημιουργεί γραφικά περιβάλλοντα χρήστη";
                radioButton4.Text = "Διαχειρίζεται τον αποθηκευτικό χώρο των δεδομένων";
                // Correct answer: radioButton2

                // Question 2
                question2.Text = "Πώς προσεγγίζεται η επίλυση προβλημάτων και η αυτόματη εκτέλεση προγραμμάτων βάσει λογικών κανόνων;";
                radioButton5.Text = "Ανάλυση, σχεδιασμός, υλοποίηση, διαχείριση";
                radioButton6.Text = "Διαχειρίζονται τον αποθηκευτικό χώρο των δεδομένων";
                radioButton7.Text = "Δημιουργούν γραφικά περιβάλλοντα χρήστη";
                radioButton8.Text = "Χρησιμοποιούν λογικούς κανόνες για την επίλυση προβλημάτων";
                // Correct answer: radioButton8

                // Question 3
                question3.Text = "Ποιες είναι οι γλώσσες λογικού προγραμματισμού που χρησιμοποιούνται, όπως το Prolog και το Datalog;";
                radioButton9.Text = "C++, Java, Python";
                radioButton10.Text = "HTML, CSS, JavaScript";
                radioButton11.Text = "SQL, MongoDB, PostgreSQL";
                radioButton12.Text = "Prolog, Datalog";
                // Correct answer: radioButton12

            }

            else if (speciality_id == 2)
            {
                question1.Text = "Τι είναι η Εικονική Πραγματικότητα;";
                radioButton1.Text = "Μια τεχνολογία που επιτρέπει την αλληλεπίδραση με εικονικά αντικείμενα και περιβάλλοντα.";
                radioButton2.Text = "Μια τεχνολογία που επιτρέπει την απεικόνιση πραγματικών αντικειμένων και περιβαλλόντων.";
                radioButton3.Text = "Μια τεχνολογία που επιτρέπει την εξομοίωση πραγματικών καταστάσεων και γεγονότων.";
                radioButton4.Text = "Μια τεχνολογία που επιτρέπει την αποθήκευση και ανάκτηση εικόνων και βίντεο.";
                // Σωστή απάντηση: radioButton1

                question2.Text = "Ποιος τομέας εφαρμογής δεν συνδέεται με την Εικονική Πραγματικότητα;";
                radioButton5.Text = "Ψυχαγωγία και βιομηχανία των video games.";
                radioButton6.Text = "Αρχιτεκτονική και σχεδίαση.";
                radioButton7.Text = "Εκπαίδευση.";
                radioButton8.Text = "Ιατρική και αποκατάσταση.";
                // Σωστή απάντηση: radioButton8

                question3.Text = "Ποια συσκευή χρησιμοποιείται για την παρουσίαση της Εικονικής Πραγματικότητας;";
                radioButton9.Text = "Γυαλιά Εικονικής Πραγματικότητας (VR)";
                radioButton10.Text = "Κινητά τηλέφωνα";
                radioButton11.Text = "Φορητοί υπολογιστές";
                radioButton12.Text = "Σταθεροί υπολογιστές";
                // Σωστή απάντηση: radioButton9

            }

            else if (speciality_id == 1)
            {
                question1.Text = "Τι είναι το ηλεκτρονικό επιχειρείν;";
                radioButton1.Text = "Ο διαδικτυακός τρόπος διεξαγωγής επιχειρηματικών δραστηριοτήτων.";
                radioButton2.Text = "Η χρήση ηλεκτρονικών συστημάτων για την αυτοματοποίηση των επιχειρηματικών διαδικασιών.";
                radioButton3.Text = "Η εισαγωγή νέων τεχνολογιών στις επιχειρήσεις.";
                radioButton4.Text = "Η ανάπτυξη ψηφιακών εφαρμογών για την προώθηση των προϊόντων και των υπηρεσιών.";
                // Σωστή απάντηση: radioButton1

                question2.Text = "Ποιο είναι ένα πλεονέκτημα του ηλεκτρονικού επιχειρείν;";
                radioButton5.Text = "Περιορισμός της αγοράς σε τοπικό επίπεδο.";
                radioButton6.Text = "Μεγαλύτερη ανεξαρτησία από τους ανταγωνιστές.";
                radioButton7.Text = "Μείωση των δαπανών για την επιχείρηση.";
                radioButton8.Text = "Αποκλειστική πρόσβαση σε νέες τεχνολογίες.";
                // Σωστή απάντηση: radioButton7

                question3.Text = "Ποιο είναι ένα παράδειγμα εφαρμογής του ηλεκτρονικού επιχειρείν;";
                radioButton9.Text = "Ένα ηλεκτρονικό κατάστημα που πωλεί προϊόντα online.";
                radioButton10.Text = "Ένα κομμωτήριο με ηλεκτρονικό σύστημα κρατήσεων.";
                radioButton11.Text = "Μια εταιρεία που παρέχει υπηρεσίες ηλεκτρονικού μάρκετινγκ.";
                radioButton12.Text = "Ένα κατάστημα με παραδοσιακή διάθεση προϊόντων.";
                // Σωστή απάντηση: radioButton9

            }

            else if (speciality_id == 9)
            {
                question1.Text = "Τι είναι τα Συστήματα Υποστήριξης Αποφάσεων (ΣΥΑ);";
                radioButton1.Text = "Τα συστήματα που χρησιμοποιούνται για την αυτοματοποίηση των επιχειρηματικών διαδικασιών.";
                radioButton2.Text = "Τα συστήματα που παρέχουν τεχνική υποστήριξη για τη λήψη αποφάσεων σε οργανισμούς και επιχειρήσεις.";
                radioButton3.Text = "Τα συστήματα που αναλαμβάνουν την ανάλυση και την πρόβλεψη των αγορών και των τάσεων.";
                radioButton4.Text = "Τα συστήματα που εφαρμόζουν αλγορίθμους μηχανικής μάθησης για την βελτιστοποίηση των διαδικασιών λήψης αποφάσεων.";
                // Σωστή απάντηση: radioButton2

                question2.Text = "Ποιο είναι ένα στάδιο της διαδικασίας λήψης αποφάσεων;";
                radioButton5.Text = "Καθορισμός του στόχου και της πρόβλεψης.";
                radioButton6.Text = "Ανάλυση των εναλλακτικών λύσεων.";
                radioButton7.Text = "Εφαρμογή της επιλεγμένης λύσης.";
                radioButton8.Text = "Όλα τα παραπάνω.";
                // Σωστή απάντηση: radioButton8

                question3.Text = "Ποια είναι μία εφαρμογή των Συστημάτων Υποστήριξης Αποφάσεων (ΣΥΑ);";
                radioButton9.Text = "Διαχείριση πόρων.";
                radioButton10.Text = "Προγραμματισμένη συντήρηση.";
                radioButton11.Text = "Χρηματοοικονομικές αποφάσεις.";
                radioButton12.Text = "Όλες οι παραπάνω εφαρμογές.";
                // Σωστή απάντηση: radioButton12

            }

            else if (speciality_id == 8)
            {
                question1.Text = "Ποιος είναι ένας από τους στόχους της κρυπτογραφίας;";
                radioButton1.Text = "Αύξηση της ταχύτητας της επικοινωνίας.";
                radioButton2.Text = "Εξασφάλιση της απορρήτουτητας των πληροφοριών.";
                radioButton3.Text = "Μείωση του μεγέθους των δεδομένων.";
                radioButton4.Text = "Αποθήκευση των πληροφοριών σε ασφαλή τοποθεσία.";
                // Σωστή απάντηση: radioButton2

                question2.Text = "Ποιος τύπος κρυπτογραφίας χρησιμοποιεί το ίδιο κλειδί για την κρυπτογράφηση και την αποκρυπτογράφηση των δεδομένων;";
                radioButton5.Text = "Συμμετρική κρυπτογραφία.";
                radioButton6.Text = "Ασύμμετρη κρυπτογραφία.";
                radioButton7.Text = "Κρυπτογραφικές συναρτήσεις κατακερματισμού.";
                radioButton8.Text = "Κρυπτογραφική κλειδολόγηση.";
                // Σωστή απάντηση: radioButton5

                question3.Text = "Ποιο είναι ένα παράδειγμα κρυπτογραφικού πρωτοκόλλου που χρησιμοποιείται για την ασφάλεια των επικοινωνιών;";
                radioButton9.Text = "SSL/TLS.";
                radioButton10.Text = "HTTP.";
                radioButton11.Text = "DNS.";
                radioButton12.Text = "FTP.";
                // Σωστή απάντηση: radioButton9

            }

            else if (speciality_id == 5)
            {
                question1.Text = "Ποιος είναι ένας από τους τύπους προηγμένων αρχιτεκτονικών επεξεργαστών;";
                radioButton1.Text = "Επεξεργαστές με κυκλώματα FPGA.";
                radioButton2.Text = "Επεξεργαστές με πολυπύρηνες μονάδες επεξεργασίας.";
                radioButton3.Text = "Επεξεργαστές με ασύγχρονες μονάδες επεξεργασίας.";
                radioButton4.Text = "Επεξεργαστές με αυτόματη επεξεργασία δεδομένων.";
                // Σωστή απάντηση: radioButton2

                question2.Text = "Ποιος τύπος μνήμης αποτελεί μια μη αποδοτική μορφή αποθηκευτικού μέσου;";
                radioButton5.Text = "Μνήμη RAM.";
                radioButton6.Text = "Μνήμη ROM.";
                radioButton7.Text = "Μνήμη Cache.";
                radioButton8.Text = "Μνήμη SSD.";
                // Σωστή απάντηση: radioButton8

                question3.Text = "Ποια είναι μία από τις προκλήσεις του παράλληλου υπολογισμού;";
                radioButton9.Text = "Διαχείριση συγχρονισμού.";
                radioButton10.Text = "Διαχείριση επεξεργαστικής ισχύος.";
                radioButton11.Text = "Διαχείριση προγραμματιστικών γλωσσών.";
                radioButton12.Text = "Διαχείριση εξόδου οθονών.";
                // Σωστή απάντηση: radioButton9

            }

            else if (speciality_id == 6)
            {
                question1.Text = "Ποιο από τα παρακάτω αναφέρεται σε ασύρματες τεχνολογίες επικοινωνίας;";
                radioButton1.Text = "Ενσύρματα δίκτυα Εthernet.";
                radioButton2.Text = "Αναλογικά τηλεφωνικά δίκτυα.";
                radioButton3.Text = "Τηλεοπτικά δίκτυα με καλώδιο.";
                radioButton4.Text = "Κινητά δίκτυα τηλεφωνίας.";
                // Σωστή απάντηση: radioButton4

                question2.Text = "Ποια από τις παρακάτω τεχνολογίες ανήκει στις ασύρματες τεχνολογίες δικτύων;";
                radioButton5.Text = "Bluetooth.";
                radioButton6.Text = "Ethernet.";
                radioButton7.Text = "Fiber optics.";
                radioButton8.Text = "DSL.";
                // Σωστή απάντηση: radioButton5

                question3.Text = "Ποια είναι μια από τις κινητές εφαρμογές που χρησιμοποιούνται συχνά;";
                radioButton9.Text = "Εφαρμογές γραφείου.";
                radioButton10.Text = "Εφαρμογές βάσεων δεδομένων.";
                radioButton11.Text = "Εφαρμογές διαχείρισης αποθηκευτικού χώρου.";
                radioButton12.Text = "Εφαρμογές κοινωνικής δικτύωσης.";
                // Σωστή απάντηση: radioButton12

            }

            else if (speciality_id == 7)
            {
                question1.Text = "Ποια είναι μια από τις αρχές των δικτύων υψηλών ταχυτήτων;";
                radioButton1.Text = "Αρχιτεκτονικές δικτύων.";
                radioButton2.Text = "Αρχιτεκτονική Von Neumann.";
                radioButton3.Text = "Συμβατικές γραμμές μετάδοσης.";
                radioButton4.Text = "Αρχιτεκτονική τεχνητής νοημοσύνης.";
                // Σωστή απάντηση: radioButton1

                question2.Text = "Ποια τεχνολογία χρησιμοποιείται για τη μετάδοση σε δίκτυα υψηλών ταχυτήτων;";
                radioButton5.Text = "Ηλεκτρονικά μηνύματα.";
                radioButton6.Text = "Οπτικές ίνες.";
                radioButton7.Text = "Ασύρματες τεχνολογίες.";
                radioButton8.Text = "Δορυφορικές συνδέσεις.";
                // Σωστή απάντηση: radioButton6

                question3.Text = "Ποια είναι μια από τις εφαρμογές των δικτύων υψηλών ταχυτήτων;";
                radioButton9.Text = "Δημιουργία και επεξεργασία εγγράφων.";
                radioButton10.Text = "Περιήγηση στο Διαδίκτυο.";
                radioButton11.Text = "Συμμετοχή σε κοινωνικά δίκτυα.";
                radioButton12.Text = "Ασύρματη φόρτιση συσκευών.";
                // Σωστή απάντηση: radioButton10

            }
            else if (speciality_id == 0)
            {
                // Ερώτηση 1
                question1.Text = "Ποια είναι η βασική αρχή του Αλγορίθμου Αναζήτησης σε Πλάτος (BFS) στον γράφο;";
                radioButton1.Text = "Χρήση στοίβας (stack) για την αναζήτηση.";
                radioButton2.Text = "Εξερεύνηση των γειτονικών κόμβων πριν την επέκταση σε επόμενο επίπεδο.";
                radioButton3.Text = "Ταξινόμηση των κόμβων σύμφωνα με το βάθος.";
                radioButton4.Text = "Εξερεύνηση των κόμβων σε τυχαία σειρά.";
                // Σωστή απάντηση: radioButton2

                // Ερώτηση 2
                question2.Text = "Ποια είναι η βασική έννοια που συνδέεται με την αρχιτεκτονική REST (Representational State Transfer);";
                radioButton5.Text = "Χρήση κρυπτογραφίας για την ασφάλεια των επικοινωνιών.";
                radioButton6.Text = "Χρήση δομής στοίβας για την οργάνωση των δεδομένων.";
                radioButton7.Text = "Περιγραφή των πόρων με βάση την URL.";
                radioButton8.Text = "Διαμοιρασμός επεξεργασιών μεταξύ πολλαπλών εξυπηρετητών.";
                // Σωστή απάντηση: radioButton7

                // Ερώτηση 3
                question3.Text = "Ποια τεχνολογία χρησιμοποιείται για την ανάπτυξη δυναμικών ιστοσελίδων;";
                radioButton9.Text = "HTML";
                radioButton10.Text = "CSS";
                radioButton11.Text = "JavaScript";
                radioButton12.Text = "SQL";
                // Σωστή απάντηση: radioButton11

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            chooseTest chooseTest = new chooseTest(new_current_user_id);
            Hide();
            chooseTest.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εδώ είναι η φόρμα του τεστ. Απαντήστε στις 3 ερωτήσεις πατώντας κλικ πάνω στην σωστή απάντηση", "Βοήθεια");
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //label1.Text = speciality;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            score = 0;

            if (speciality_id == 3)
            {
                // Question 1
                if (radioButton1.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton5.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton9.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 4)
            {
                // Question 1
                if (radioButton2.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton8.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton12.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 2)
            {
                // Question 1
                if (radioButton1.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton8.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton9.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 1)
            {
                // Question 1
                if (radioButton1.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton7.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton9.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 8)
            {
                // Question 1
                if (radioButton2.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton5.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton9.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 5)
            {
                // Question 1
                if (radioButton2.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton8.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton9.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 6)
            {
                // Question 1
                if (radioButton4.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton5.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton12.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 7)
            {
                // Question 1
                if (radioButton1.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton6.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton10.Checked)
                {
                    score++;
                }
            }
            else if (speciality_id == 0)
            {
                // Question 1
                if (radioButton2.Checked)
                {
                    score++;
                }

                // Question 2
                if (radioButton7.Checked)
                {
                    score++;
                }

                // Question 3
                if (radioButton11.Checked)
                {
                    score++;
                }
            }


            // Display the score or perform further actions
            MessageBox.Show("Your score: " + score);


            // Establish connection to the SQLite database
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Check if a score already exists for the user ID and speciality ID
                string query = "SELECT COUNT(*) FROM Score_tracking WHERE User_ID = @userId AND Speciality_ID = @specialityId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Set parameter values for the query
                    command.Parameters.AddWithValue("@userId", new_current_user_id);  // Replace with the actual user ID
                    command.Parameters.AddWithValue("@specialityId", speciality_id);  // Replace with the actual speciality ID

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Update the existing score
                        query = "UPDATE Score_tracking SET Score = @score WHERE User_ID = @userId AND Speciality_ID = @specialityId";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(query, connection))
                        {
                            // Set parameter values for the update query
                            updateCommand.Parameters.AddWithValue("@score", score);
                            updateCommand.Parameters.AddWithValue("@userId", new_current_user_id);  // Replace with the actual user ID
                            updateCommand.Parameters.AddWithValue("@specialityId", speciality_id);  // Replace with the actual speciality ID

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Insert a new score
                        query = "INSERT INTO Score_tracking (User_ID, Speciality_ID, Score) VALUES (@userId, @specialityId, @score)";
                        using (SQLiteCommand insertCommand = new SQLiteCommand(query, connection))
                        {
                            // Set parameter values for the insert query
                            insertCommand.Parameters.AddWithValue("@userId", new_current_user_id);  // Replace with the actual user ID
                            insertCommand.Parameters.AddWithValue("@specialityId", speciality_id);  // Replace with the actual speciality ID
                            insertCommand.Parameters.AddWithValue("@score", score);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}