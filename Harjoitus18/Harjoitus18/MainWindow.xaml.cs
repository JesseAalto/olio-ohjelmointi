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

namespace Harjoitus18
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSumma_Click(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Summa);
        }

        private void BtnErotus_Click(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Erotus);
        }

        private void BtnKertolasku_Click(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Kertolasku);
        }

        private void BtnJakolasku_Click(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Jakolasku);
        }

        private void LaskeJaNaytaTulos(Func<double, double, double> operaatio)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                double tulos = operaatio(num1, num2);
                txtTulos.Text = $"Tulos: {tulos}";
            }
            else
            {
                txtTulos.Text = "Virheellinen syöte. Syötä kelvolliset numerot.";
            }
        }
        public static class Laskin
        {
            public static double Summa(double a, double b)
            {
                return a + b;
            }

            public static double Erotus(double a, double b)
            {
                return a - b;
            }

            public static double Kertolasku(double a, double b)
            {
                return a * b;
            }

            public static double Jakolasku(double a, double b)
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    throw new DivideByZeroException("Nollalla ei voi jakaa.");
                }
            }
        }
    }
}

