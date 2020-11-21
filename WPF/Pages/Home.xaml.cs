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

namespace WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            Purchases Apple = new Purchases();

            Apple.Instrument = "Apple Inc";
            Apple.Deal = "113.9$";
            Apple.Volume = "110 456";
            Apple.Market_entry = "22.10.20 13:30";

            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
            Purchases_table.Items.Add(Apple);
        }

        public class Purchases
        {
            public string Instrument { get; set; }
            public string Deal { get; set; }
            public string Volume { get; set; }
            public string Market_entry { get; set; }
        }
    }
}
