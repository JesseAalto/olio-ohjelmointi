using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Harjoitus_24
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Kun Tulosta nappia painetaan
        private void OnPrintClick(object sender, RoutedEventArgs e)
        {
            // Tyhjentää mahdolliset aiemmat tulokset
            ResultTextBlock.Text = "";

            // Otetaan käyttäjän antama rivilukumäärä
            if (int.TryParse(NumberOfLinesTextBox.Text, out int numberOfLines))
            {
                // Valitaan peli ComboBoxista
                string selectedGame = ((ComboBoxItem)GameSelectionComboBox.SelectedItem)?.Content.ToString();

                // Arvotaan ja tulostetaan rivit valitun pelin perusteella
                switch (selectedGame)
                {
                    // Lotto
                    case "Lotto":
                        for (int i = 0; i < numberOfLines; i++)
                        {
                            int[] lottoNumbers = GenerateNumbers(7, 1, 40);
                            PrintNumbers("Lotto", lottoNumbers);
                        }
                        break;

                    // Viking Lotto
                    case "Viking Lotto":
                        for (int i = 0; i < numberOfLines; i++)
                        {
                            int[] vikingLottoNumbers = GenerateNumbers(6, 1, 48);
                            PrintNumbers("Viking Lotto", vikingLottoNumbers);
                        }
                        break;

                    // Eurojackpot
                    case "Eurojackpot":
                        for (int i = 0; i < numberOfLines; i++)
                        {
                            int[] eurojackpotNumbers = GenerateNumbers(5, 1, 50);
                            int[] eurojackpotStars = GenerateNumbers(2, 1, 10);
                            PrintEurojackpotNumbers(eurojackpotNumbers, eurojackpotStars);
                        }
                        break;

                    default:
                        MessageBox.Show("Valitse peli ComboBoxista.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Anna kelvollinen rivilukumäärä.");
            }
        }

        // Kun Tyhjennä nappia painetaan
        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            // Tyhjentää tulostetun tekstin
            ResultTextBlock.Text = "";
        }

        // Funktio numeroiden generoimiseen
        private int[] GenerateNumbers(int count, int min, int max)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }

            return numbers;
        }

        // Funktio numeroiden tulostamiseen (Lotto ja Viking Lotto)
        private void PrintNumbers(string game, int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{game}: ");
            foreach (int number in numbers)
            {
                sb.Append($"{number} ");
            }
            sb.AppendLine();

            ResultTextBlock.Text += sb.ToString();
        }

        // Funktio numeroiden ja tähtien tulostamiseen (Eurojackpot)
        private void PrintEurojackpotNumbers(int[] numbers, int[] tähdet)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Eurojackpot Numbers: ");
            foreach (int number in numbers)
            {
                sb.Append($"{number} ");
            }
            sb.Append(" Stars: ");
            foreach (int tähti in tähdet)
            {
                sb.Append($"{tähti} ");
            }
            sb.AppendLine();

            ResultTextBlock.Text += sb.ToString();
        }
    }
}