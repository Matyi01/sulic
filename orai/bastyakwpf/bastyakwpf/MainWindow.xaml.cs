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

namespace bastyakwpf
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
            mezo(0, 0, "Martin");
            mezo(0, 1, "Martin");
            mezo(0, 2, "Martin");
            mezo(0, 3, "Martin");
            mezo(0, 4, "Martin");

        }
        private void mezo(int sor, int  oszlop, string tartalom)
        {
            Label cimke = new Label();
            cimke.Content = tartalom;
            cimke.BorderBrush = Brushes.SlateBlue;
            cimke.BorderThickness = new Thickness(1);
            cimke.Background = Brushes.AliceBlue;
            cimke.Foreground = Brushes.White;
            cimke.Height = tabla.Height / 8;
            cimke.Width = tabla.Width / 8;
            cimke.Margin = new Thickness(cimke.Width * oszlop, cimke.Height * sor, 0, 0);
            cimke.HorizontalAlignment = HorizontalAlignment.Left;
            cimke.VerticalAlignment = VerticalAlignment.Top;

            tabla.Children.Add(cimke);
        }
    }
}
