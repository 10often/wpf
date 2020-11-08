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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pages.Home home = new Pages.Home();
        Pages.Quotation1 quotation1 = new Pages.Quotation1();

        //create change for buttons

        public MainWindow()
        {
            InitializeComponent();
        }

        private void page_home_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = home;
        }

        private void page_qu_1_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation1;
        }
    }
}
