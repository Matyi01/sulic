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

namespace tobbablak
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 nevablak = new Window1();
            nevablak.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window2 korablak = new Window2();
            korablak.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window3 varosablak = new Window3();
            varosablak.Show();
        }
    }
}