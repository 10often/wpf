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
        Pages.Quotation2 quotation2 = new Pages.Quotation2();
        Pages.Quotation3 quotation3 = new Pages.Quotation3();
        Pages.Quotation4 quotation4 = new Pages.Quotation4();
        Pages.Quotation5 quotation5 = new Pages.Quotation5();
        Color focus_color = (Color)ColorConverter.ConvertFromString("#5a6baf");
        Color reg_color = (Color)ColorConverter.ConvertFromString("#3d4b89");

        //create change for buttons

        public MainWindow()
        {
            InitializeComponent();
        }

        private void page_home_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = home;
            home_text.Foreground = new SolidColorBrush(focus_color);
            page_1_text.Foreground = new SolidColorBrush(reg_color);
            page_2_text.Foreground = new SolidColorBrush(reg_color);
            page_3_text.Foreground = new SolidColorBrush(reg_color);
            page_4_text.Foreground = new SolidColorBrush(reg_color);
            page_5_text.Foreground = new SolidColorBrush(reg_color);
        }

        private void page_qu_1_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation1;
            home_text.Foreground = new SolidColorBrush(reg_color);
            page_1_text.Foreground = new SolidColorBrush(focus_color);
            page_2_text.Foreground = new SolidColorBrush(reg_color);
            page_3_text.Foreground = new SolidColorBrush(reg_color);
            page_4_text.Foreground = new SolidColorBrush(reg_color);
            page_5_text.Foreground = new SolidColorBrush(reg_color);

        }

        private void page_qu_2_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation2;
            home_text.Foreground = new SolidColorBrush(reg_color);
            page_1_text.Foreground = new SolidColorBrush(reg_color);
            page_2_text.Foreground = new SolidColorBrush(focus_color);
            page_3_text.Foreground = new SolidColorBrush(reg_color);
            page_4_text.Foreground = new SolidColorBrush(reg_color);
            page_5_text.Foreground = new SolidColorBrush(reg_color);

        }

        private void page_qu_3_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation3;
            home_text.Foreground = new SolidColorBrush(reg_color);
            page_1_text.Foreground = new SolidColorBrush(reg_color);
            page_2_text.Foreground = new SolidColorBrush(reg_color);
            page_3_text.Foreground = new SolidColorBrush(focus_color);
            page_4_text.Foreground = new SolidColorBrush(reg_color);
            page_5_text.Foreground = new SolidColorBrush(reg_color);

        }

        private void page_qu_4_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation4;
            home_text.Foreground = new SolidColorBrush(reg_color);
            page_1_text.Foreground = new SolidColorBrush(reg_color);
            page_2_text.Foreground = new SolidColorBrush(reg_color);
            page_3_text.Foreground = new SolidColorBrush(reg_color);
            page_4_text.Foreground = new SolidColorBrush(focus_color);
            page_5_text.Foreground = new SolidColorBrush(reg_color);

        }

        private void page_qu_5_btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = quotation5;
            home_text.Foreground = new SolidColorBrush(reg_color);
            page_1_text.Foreground = new SolidColorBrush(reg_color);
            page_2_text.Foreground = new SolidColorBrush(reg_color);
            page_3_text.Foreground = new SolidColorBrush(reg_color);
            page_4_text.Foreground = new SolidColorBrush(reg_color);
            page_5_text.Foreground = new SolidColorBrush(focus_color);

        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
