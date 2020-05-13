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
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from t in db.Phones
                        select t.Name;

            lbxPhones.ItemsSource = query.ToList();

        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phones selectPhone = lbxSelect.SelectedItem as Phones;

            //Check for null
            if (selectPhone != null)
            {
                //Display Band Info
                string Text = $"{selectPhone.Name}";
                txtbxPhones.Text = Text;

                //Display Band Image
                Image.Source = new BitmapImage(new Uri($"/images/{selectCharacter.Phone_Image}", UriKind.Relative));


                //Punishers Section
                var phones = from b in db.Phones
                             where b.PhoneID == selectCharacter.PhoneID
                             select b.Name;

                lbxPhones.ItemsSource = phones.ToList();
            }
        }
    }
}
