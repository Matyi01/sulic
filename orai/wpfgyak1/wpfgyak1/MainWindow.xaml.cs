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

namespace wpfgyak1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int osszeg = Convert.ToInt32(textBox.Text) + Convert.ToInt32(textBox1.Text);
            textBlock.Text = Convert.ToString(osszeg);
            textBlock1.Text = textBox.Text + " + " + textBox1.Text + " = " + osszeg.ToString() + "\n" + textBlock1.Text;
            textBox.Text = "";
            textBox1.Text = "";
        }
    }
}
