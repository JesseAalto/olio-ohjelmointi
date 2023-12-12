using System;
using System.Windows;

namespace KmMilesConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKilometers.Text))
            {
                if (double.TryParse(txtKilometers.Text, out double km))
                {
                    // Convert kilometers to miles
                    double miles = km * 0.621371;
                    txtMiles.Text = miles.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Kilometers.");
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtMiles.Text))
            {
                if (double.TryParse(txtMiles.Text, out double miles))
                {
                    // Convert miles to kilometers
                    double km = miles / 0.621371;
                    txtKilometers.Text = km.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Miles.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value to convert.");
            }
        }
    }
}
