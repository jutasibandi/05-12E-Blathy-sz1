using System.Windows;

namespace cukraszda
{
    public partial class Window1 : Window
    {

        private void btnRendel_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show("A számla elkészült!");
            }
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
