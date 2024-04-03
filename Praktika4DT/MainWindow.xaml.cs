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

namespace Praktika4DT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 customers = new Window1();
            customers.Show();
            Close();
        }

        private void DirectorsButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 directors = new Window2();
            directors.Show();
            Close();
        }

        private void PurchasesButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 purchases = new Window3();
            purchases.Show();
            Close();
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 store = new Window4();
            store.Show();
            Close();
        }
    }
}
