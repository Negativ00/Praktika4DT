using Praktika4DT.Praktika4DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Praktika4DT
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        PurchasesTableAdapter purchases = new PurchasesTableAdapter();
        StoreTableAdapter store = new StoreTableAdapter();
        public Window3()
        {
            InitializeComponent();
            TableWindow.ItemsSource = purchases.GetData();

            StoreNameComboBox.ItemsSource = store.GetData();
            StoreNameComboBox.DisplayMemberPath = "StoreName";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void StoreNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(StoreNameComboBox.SelectedItem != null)
            {
                var id = (int)(StoreNameComboBox.SelectedItem as DataRowView).Row[0];
                TableWindow.ItemsSource = purchases.FilterByStoreID(id);
            }
        }
    }
}
