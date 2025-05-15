using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kreta1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fooldal.Width = Width / 5 - 4;
            orarend.Width = Width / 5 - 4;
            ertesitesek.Width = Width / 5 - 4;
            mulasztas.Width = Width / 5 - 4;
            egyeb.Width = Width / 5 - 4;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            fooldal.Width = Width / 5 - 4;
            orarend.Width = Width / 5 - 4;
            ertesitesek.Width = Width / 5 - 4;
            mulasztas.Width = Width / 5 - 4;
            egyeb.Width = Width / 5 - 4;
        }
        public void sqlkapcsolat()
        {

        }
    }
}