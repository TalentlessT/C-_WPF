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

namespace EvidenceBěhání
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabazeBehani db = new DatabazeBehani();
        public MainWindow()
        {
            InitializeComponent();
            DataDisplay.ItemsSource = db.behani_db;
        }

        private void Button_Click_Vlozit(object sender, RoutedEventArgs e)
        {
            db.Vlozit(new BehVykon(Nazev.Text, double.Parse(Delka.Text), DateTime.Parse(Datum.Text).Date, TimeSpan.Parse(Cas.Text)));
        }

        private void Button_Click_Smazat(object sender, RoutedEventArgs e)
        {
            db.Smazat((BehVykon)DataDisplay.SelectedItem);
        }

        private void Button_Click_Souhrn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ubehl jsi: " + db.Souhrn().ToString() + " Km");
        }

        private void Button_Click_Export(object sender, RoutedEventArgs e)
        {
            db.Export();
            MessageBox.Show("Export do C:\\export.txt");
        }
    }
}
