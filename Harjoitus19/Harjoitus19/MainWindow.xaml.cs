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

namespace Harjoitus19
{
    public partial class MainWindow : Window
    {
        private int currentFloor = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedFloor;
            if (int.TryParse(floorInput.Text, out selectedFloor))
            {
                if (selectedFloor >= 1 && selectedFloor <= 6)
                {
                    MoveElevator(selectedFloor);
                }
                else
                {
                    resultText.Text = "Invalid floor. Choose a floor between 1 and 6.";
                }
            }
            else
            {
                resultText.Text = "Please enter a valid floor number.";
            }
        }

        private void MoveElevator(int destinationFloor)
        {
            resultText.Text = $"Moving from floor {currentFloor} to floor {destinationFloor}.";
            currentFloor = destinationFloor;
        }
    }
    public class Hissi
    {
        private int currentFloor = 1;

        public int CurrentFloor
        {
            get { return currentFloor; }
            set { currentFloor = value; }
        }
    }
}