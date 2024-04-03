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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        StoreTableAdapter store = new StoreTableAdapter();
        public Window4()
        {
            InitializeComponent();
            TableWindow.ItemsSource = store.GetData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void SearchStoreNameButton_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = store.SearchByStoreName(SearchTextStoreName.Text);
        }

        private void SearchStoreCityPlace_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = store.SearchByStoreCityPlace(SearchTextStoreCityPlace.Text);
        }
    }
}
