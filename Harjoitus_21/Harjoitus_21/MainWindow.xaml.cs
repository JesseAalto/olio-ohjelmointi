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

namespace Harjoitus_21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Metodi, joka suoritetaan, kun "Osta" -nappia painetaan
        private void OstaButton_Click(object sender, RoutedEventArgs e)
        {
            // Asetetaan CheckBox-kontrollit unchecked-tilaan ja tyhjennetään StockPanel
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;
            checkBox5.IsChecked = false;
            checkBox6.IsChecked = false;
            checkBox7.IsChecked = false;
            
            // Lisää tarvittaessa muita CheckBox-kontrolleja
            StockPanel.Children.Clear();
        }

        // Metodi, joka suoritetaan, kun CheckBox valitaan
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // Haetaan valittu CheckBox

            // Luodaan uusi TextBlock ja lisätään se StockPaneliin valitun tuotteen nimellä
            TextBlock newTextBlock = new TextBlock();
            newTextBlock.Text = checkBox.Content.ToString();
            StockPanel.Children.Add(newTextBlock);
        }

        // Metodi, joka suoritetaan, kun CheckBox poistetaan valinnasta
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // Haetaan poistettu CheckBox

            // Etsitään ja poistetaan vastaava tuote StockPanelista
            foreach (TextBlock item in StockPanel.Children)
            {
                if (item.Text == checkBox.Content.ToString())
                {
                    StockPanel.Children.Remove(item);
                    break;
                }
            }
        }
    }
}
