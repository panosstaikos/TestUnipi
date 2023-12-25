using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCareerApp
{
    public partial class ShowTheory : Form
    {
        public static int new_current_course_id, new_current_user_id;
        public ShowTheory(int current_course_id, int current_user_id)
        {
            InitializeComponent();
            new_current_course_id = current_course_id;
            new_current_user_id = current_user_id;
        }


        private void ShowTheory_Load(object sender, EventArgs e)
        {
            switch (new_current_course_id)
            {
                
                case 1:
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\hlektronikoEpixeirin.txt");
                    string fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 2:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\eikonikiPragmatikotita.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 3:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\sdvd.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 4:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\logikosProgrammatismos.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 5:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\prohgmenhArxitektonikiYpologistwn.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 6:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\kinites_asirmatesEpikoinwnies.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 7:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\diktyaYpsilwnTaxythtwn.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 8:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\kryptografia.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;

                case 9:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\sya.txt");
                    fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                    speciality.Text = Theory.speciality;
                    break;
            }

        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σε αυτή τη φόρμα απλά μελετάτε τη θεωρία κάθε ειδικότητας για να δείτε αν σας ενδιαφέρει, και έπειτα να είστε ικανοί να απαντήσετε σωστά στα τεστ.", "Βοήθεια");
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Close();
            Theory theory = new Theory(new_current_user_id);
            theory.Show();
        }
    }
}
