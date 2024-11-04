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

namespace lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // 1-90: 5
    // 1-45: 6
    // 1-35: 7
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 ablak = new Window1(this);
            ablak.Show();
        }
    }
}