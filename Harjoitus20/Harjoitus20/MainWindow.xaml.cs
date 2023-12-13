using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus20
{
    public partial class MainWindow : Window
    {
        // Lista opiskelija-olioille
        private List<Opiskelija> students = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Metodi opiskelija-olion luomiseksi
        private void CreateStudentButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan tekstikenttien sisällöt
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string studentID = studentIDTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            // Tarkistetaan et kaikki kentät ovat täytettyjä
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(studentID) && !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(phone))
            {
                // Luodaan uusi opiskelija olio
                Opiskelija student = new Opiskelija(firstName, lastName, studentID, email, phone);

                // Tarkistetaan onks opiskelija jo listassa samoilla ID:llä tai sähköpostilla
                bool exists = students.Exists(s => s.OpiskelijaID == student.OpiskelijaID || s.Email == student.Email);
                if (!exists)
                {
                    // Lisätään opiskelija listaan ja ListBoxiin
                    students.Add(student);
                    studentsListBox.Items.Add(student.ToString());
                }
                else
                {
                    MessageBox.Show("Student ID or Email already exists. Please provide unique values.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        // Metodi opiskelijatietojen tallentamiseksi tiedostoon
        private void SaveToFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Tallennetaan opiskelijalista tiedostoon serialisoinnin avulla
                using (FileStream fs = new FileStream("students.dat", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, students);
                    MessageBox.Show("Students' information saved to file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to file: " + ex.Message);
            }
        }

        // Metodi opiskelijatietojen lataamiseksi tiedostosta
        private void LoadFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Yritetään ladata opiskelijatiedot tiedostosta
                using (FileStream fs = new FileStream("students.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    students = (List<Opiskelija>)formatter.Deserialize(fs);
                    studentsListBox.Items.Clear();

                    // Näytetään opiskelijatiedot ListBoxissa
                    foreach (Opiskelija student in students)
                    {
                        studentsListBox.Items.Add(student.ToString());
                    }
                    MessageBox.Show("Students' information loaded from file.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No saved data found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from file: " + ex.Message);
            }
        }
    }

    // Opiskelija-luokka
    [Serializable]
    public class Opiskelija
    {
        // Opiskelija-olion ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpiskelijaID { get; set; }
        public string Email { get; set; }
        public string Puhelinnumero { get; set; }

        // Konstruktori opiskelija-olion luomiseksi
        public Opiskelija(string etunimi, string sukunimi, string opiskelijaID, string email, string puhelinnumero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            OpiskelijaID = opiskelijaID;
            Email = email;
            Puhelinnumero = puhelinnumero;
        }

        // Metodi opiskelija-olion esittämiseksi merkkijonona
        public override string ToString()
        {
            return $"{Etunimi} {Sukunimi} (ID: {OpiskelijaID})";
        }
    }
}