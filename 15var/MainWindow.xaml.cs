using _15var.View;
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


namespace _15var
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
        private void Category_OnClick(object sender, RoutedEventArgs
e)
        {
            WindowCategory wCategory = new WindowCategory();
            wCategory.Show();
        }
        private void Order_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOrder wOrder = new WindowOrder();
            wOrder.Show();

        }
        private void OrderDetail_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOrderDetail wOrderDetail = new WindowOrderDetail();
            wOrderDetail.Show();

        }
        private void Product_OnClick(object sender, RoutedEventArgs e)
        {
            WindowProduct wProduct = new WindowProduct();
            wProduct.Show();

        }
    }
}