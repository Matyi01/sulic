using System.Runtime.InteropServices;
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

namespace wpfjatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            button.Margin = new Thickness(rnd.Next(1, (int)this.Width - 75), rnd.Next(1, (int)this.Height - 75), 0, 0);
        }
        private void button_MouseEnter1(object sender, MouseEventArgs e)
        {
            SetCursorPos(rnd.Next(1, (int)this.Width), rnd.Next(1, (int)this.Height));
        }
    }
}