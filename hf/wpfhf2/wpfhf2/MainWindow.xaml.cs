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

namespace wpfhf2
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
        double[] ertekek = new double[4] {1, 1, 1, 1 };
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[0] = ((Slider)sender).Value;

            kep1.Opacity = ertekek[0] * (1-ertekek[3]);
            kep2.Opacity = ertekek[0] * (1-ertekek[1]);
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[1] = ((Slider)sender).Value;

            kep3.Opacity = ertekek[2] * (1-ertekek[1]);
            kep4.Opacity = ertekek[2] * (1-ertekek[3]);
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[2] = ((Slider)sender).Value;

            kep3.Opacity = ertekek[1] * (1-ertekek[2]);
            kep2.Opacity = ertekek[1] * (1-ertekek[0]);
        }

        private void slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[3] = ((Slider)sender).Value;

            kep1.Opacity = ertekek[3] * (1-ertekek[0]);
            kep4.Opacity = ertekek[3] * (1-ertekek[2]);
        }


    }
}
