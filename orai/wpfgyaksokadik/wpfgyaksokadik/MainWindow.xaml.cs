using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace wpfgyaksokadik
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
            MessageBox.Show("ügyes vagy");
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private void button_enter(object sender, MouseEventArgs e)
        {
            //random helyre dobja az egeret
            Random rnd = new Random();

            int x = rnd.Next(1, 801);
            int y = rnd.Next(1, 451);

            int x1 = rnd.Next(1, 801);
            int y1 = rnd.Next(1, 451);

            SetCursorPos(x, y);

            button.Margin = new Thickness(x1, y1, 0, 0);
        }
    }
}
