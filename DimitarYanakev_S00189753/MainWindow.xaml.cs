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

namespace DimitarYanakev_S00189753
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Phone> phones = new List<Phone>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Phone p1 = new Phone() { "Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg" };
            Phone p2 = new Phone() { "iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg" };

        }
    }
}
