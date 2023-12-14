
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Omasovellus
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> inventory;

        public MainWindow()
        {
            InitializeComponent();
            inventory = new ObservableCollection<Product>();
            lstInventory.ItemsSource = inventory;

            // Lue varastotiedot tiedostosta
            ReadInventoryFromFile();
        }

        private void AddToInventory_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;
            if (!string.IsNullOrWhiteSpace(productName))
            {
                if (int.TryParse(txtProductQuantity.Text, out int quantity))
                {
                    if (quantity > 0)
                    {
                        Product existingProduct = FindProduct(productName);
                        if (existingProduct != null)
                        {
                            existingProduct.Quantity += quantity;
                        }
                        else
                        {
                            Product newProduct = new Product { Name = productName, Quantity = quantity };
                            inventory.Add(newProduct);
                        }

                        // Tallenna varastotiedot tiedostoon
                        SaveInventoryToFile();
                    }
                    else
                    {
                        MessageBox.Show("Määrän täytyy olla positiivinen luku.");
                    }
                }
                else
                {
                    MessageBox.Show("Syötä kelvollinen määrä.");
                }
            }
            else
            {
                MessageBox.Show("Syötä tuotteen nimi.");
            }
        }

        private Product FindProduct(string productName)
        {
            foreach (Product product in inventory)
            {
                if (product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        private void SaveInventoryToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("inventory.txt"))
                {
                    foreach (Product product in inventory)
                    {
                        writer.WriteLine($"{product.Name},{product.Quantity}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Tallennuksessa tapahtui virhe: " + ex.Message);
            }
        }

        private void ReadInventoryFromFile()
        {
            try
            {
                if (File.Exists("inventory.txt"))
                {
                    string[] lines = File.ReadAllLines("inventory.txt");
                    inventory.Clear();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string productName = parts[0];
                            int productQuantity = int.Parse(parts[1]);
                            Product loadedProduct = new Product { Name = productName, Quantity = productQuantity };
                            inventory.Add(loadedProduct);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Virhe tiedoston lukemisessa: " + ex.Message);
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}