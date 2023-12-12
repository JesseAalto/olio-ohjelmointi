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

namespace HouseControlApp
{
    public partial class MainWindow : Window
    {
        float temperature;
        bool kitchenLightsOn;
        bool livingRoomLightsOn;
        bool doorLocked;

        public MainWindow()
        {
            InitializeComponent();

            // Alustetaan muuttujat
            temperature = 20.0f;
            kitchenLightsOn = false;
            livingRoomLightsOn = false;
            doorLocked = false;

            UpdateUI();
        }

        private void KitchenLights_Click(object sender, RoutedEventArgs e)
        {
            kitchenLightsOn = !kitchenLightsOn;
            UpdateUI();
        }

        private void LivingRoomLights_Click(object sender, RoutedEventArgs e)
        {
            livingRoomLightsOn = !livingRoomLightsOn;
            UpdateUI();
        }

        private void TemperatureSlider_ValueChanged(object sender, RoutedEventArgs e)
        {
            temperature = (float)temperatureSlider.Value;
            UpdateUI();
        }

        private void LockUnlockButton_Click(object sender, RoutedEventArgs e)
        {
            doorLocked = !doorLocked;
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Päivitä UI-elementit vastaamaan muuttujien tilaa
            if (kitchenLightsOn)
                doorStatusText.Text = "Kitchen Lights: On";
            else
                doorStatusText.Text = "Kitchen Lights: Off";

            if (livingRoomLightsOn)
                doorStatusText.Text += "\nLiving Room Lights: On";
            else
                doorStatusText.Text += "\nLiving Room Lights: Off";

            temperatureText.Text = temperature.ToString("0.0") + "°C";

            if (doorLocked)
                lockUnlockButton.Content = "Unlock Door";
            else
                lockUnlockButton.Content = "Lock Door";
        }
    }
}