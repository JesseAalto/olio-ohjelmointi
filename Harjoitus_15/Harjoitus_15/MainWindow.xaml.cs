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

namespace Harjoitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int HenkilöAutot = 0;
        private int KuormaAutot = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            tbHenkilöauto1.Text = HenkilöAutot.ToString();
            tbKuormaauto1.Text = KuormaAutot.ToString();
        }
        private void BtnHenkilöAuto_Click(object sender, RoutedEventArgs e)
        {
             HenkilöAutot++;
            tbHenkilöauto1.Text = HenkilöAutot.ToString();
        }

        private void BtnKuormaAuto_Click_1(object sender, RoutedEventArgs e)
        {
             KuormaAutot++;
            tbKuormaauto1.Text = KuormaAutot.ToString();
        }
    }
}
