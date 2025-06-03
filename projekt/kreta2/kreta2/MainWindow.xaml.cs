
// MainWindow.xaml.cs
using System.Windows;

namespace KretaClone
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Navigate(new Views.OrarendPage());
        }

        private void Orarend_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Views.OrarendPage());
        }

        private void Jegyek_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Views.JegyekPage());
        }

        private void Hianyzasok_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Views.HianyzasokPage());
        }
    }
}

