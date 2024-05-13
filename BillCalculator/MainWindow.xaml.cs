using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace BillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<MenuItem> billItems;
        private decimal subtotal, tax, total;

        public MainWindow()
        {
            InitializeComponent();
            InitializeMenuItems();
            billItems = new ObservableCollection<MenuItem>();
            dgBill.ItemsSource = billItems;
        }

        private void InitializeMenuItems()
        {
            cmbBeverage.ItemsSource = new MenuItem[]
            {
                new MenuItem("Soda", 1.95m),
                new MenuItem("Tea", 1.50m),
                new MenuItem("Coffee", 1.25m),
                new MenuItem("Mineral Water", 2.95m),
                new MenuItem("Juice", 2.50m),
                new MenuItem("Milk", 1.50m)
            };
            cmbAppetizer.ItemsSource = new MenuItem[]
            {
                new MenuItem("Buffalo Wings", 5.95m),
                new MenuItem("Buffalo Fingers", 6.95m),
                new MenuItem("Potato Skins", 8.95m),
                new MenuItem("Nachos", 8.95m),
                new MenuItem("Mushroom Caps", 10.95m),
                new MenuItem("Shrimp Cocktail", 12.95m),
                new MenuItem("Chips and Salsa", 6.95m)
            };
            cmbMainCourse.ItemsSource = new MenuItem[]
            {
                new MenuItem("Seafood Alfredo", 15.95m),
                new MenuItem("Chicken Alfredo", 13.95m),
                new MenuItem("Chicken Picatta", 13.95m),
                new MenuItem("Turkey Club", 11.95m),
                new MenuItem("Lobster Pie", 19.95m),
                new MenuItem("Prime Rib", 20.95m),
                new MenuItem("Shrimp Scampi", 18.95m),
                new MenuItem("Turkey Dinner", 13.95m),
                new MenuItem("Stuffed Chicken", 14.95m)
            };
            cmbDessert.ItemsSource = new MenuItem[]
            {
                new MenuItem("Apple Pie", 5.95m),
                new MenuItem("Sundae", 3.95m),
                new MenuItem("Carrot Cake", 5.95m),
                new MenuItem("Mud Pie", 4.95m),
                new MenuItem("Apple Crisp", 5.95m)
            };
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cmb = sender as ComboBox;
            var selectedItem = cmb.SelectedItem as MenuItem;

            if (selectedItem != null)
            {
                billItems.Add(selectedItem);
                UpdateBill(selectedItem.Price);

                cmb.SelectedIndex = -1; // Reset the ComboBox selection
            }
        }

        private void UpdateBill(decimal price)
        {
            subtotal += price;
            tax = subtotal * 0.13m;
            total = subtotal + tax;
            tbSubtotal.Text = subtotal.ToString("C");
            tbTax.Text = tax.ToString("C");
            tbTotal.Text = total.ToString("C");
        }

        private void btnClearBill_Click(object sender, RoutedEventArgs e)
        {
            billItems.Clear();
            subtotal = 0;
            tax = 0;
            total = 0;
            tbSubtotal.Text = "$0.00";
            tbTax.Text = "$0.00";
            tbTotal.Text = "$0.00";
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = ((Button)sender).DataContext as MenuItem;
            billItems.Remove(menuItem);
            UpdateBill(-menuItem.Price);
        }

        private void imgLogo_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.centennialcollege.ca/");
        }
    }

    public class MenuItem
    {
        public string Item { get; set; }
        public decimal Price { get; set; }

        public string NameAndPrice => $"{Item} ({Price:C})";

        public MenuItem(string item, decimal price)
        {
            Item = item;
            Price = price;
        }
    }
}
