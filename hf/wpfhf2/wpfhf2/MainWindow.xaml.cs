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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep1.Opacity = slider1.Value * slider4.Value;
            kep2.Opacity = slider1.Value * slider2.Value;
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep3.Opacity = slider3.Value * slider2.Value;
            kep4.Opacity = slider3.Value * slider4.Value;
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep3.Opacity = slider2.Value * slider3.Value;
            kep2.Opacity = slider2.Value * slider1.Value;
        }

        private void slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep1.Opacity = slider4.Value * slider1.Value;
            kep4.Opacity = slider4.Value * slider3.Value;
        }


    }
}
