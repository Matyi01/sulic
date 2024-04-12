using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace tort
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
        /*
        Függvény lnko(a, b : egész számok) : egész szám
            ha a=b akkor lnko := a
            ha a<b akkor lnko := lnko(a, b-a)
            ha a>b akkor lnko := lnko(a-b, b)
        Függvény vége
        */
        private int lnko(int a, int b)
        {
            if (a == b) return a;
            else if (a < b) return lnko(a, b - a);
            else if (a > b) return lnko(a - b, b);
            return 0;
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(textBox.Text);
            }
            catch { }

            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(textBox1.Text);
            }
            catch { }

            if (nevezo != 0 && szamlalo % nevezo == 0)
            {
                textBlock4.Text = (szamlalo / nevezo).ToString();
            }
            else if (nevezo != 0 && szamlalo % nevezo != 0)
            {
                textBlock4.Text = "nem egész";
            }
            else
            {
                textBlock4.Text = "Nullával való osztás";
            }

            textBlock.Text = szamlalo.ToString();
            textBlock1.Text = nevezo.ToString();

            if (nevezo != 0 && szamlalo != 0)
            {
                int oszto = lnko(szamlalo, nevezo);
                textBlock2.Text = (szamlalo / oszto).ToString();
                textBlock3.Text = (nevezo / oszto).ToString();

                tab4.IsEnabled = true;
            }
            else
            {
                tab4.IsEnabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(textBox2.Text);
            }
            catch { }

            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(textBox3.Text);
            }
            catch { }

            textBlock_Copy1.Text = szamlalo.ToString();
            textBlock1_Copy1.Text = nevezo.ToString();
        }

        private void tab4_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
