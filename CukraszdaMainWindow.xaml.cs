using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace cukraszda
{
    public partial class MainWindow : Window
    {
        string[] sutik;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Megnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == true)
            {
                sutik = File.ReadAllLines(ofd.FileName);

                miSutemenyek.IsEnabled = true;

                MessageBox.Show("A fájl betöltve!");
            }
        }

        private void Sutemenyek_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }
        private void Nevjegy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "A program készítői:\n\nJutasi András\nTóth Martin",
                "Névjegy",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}