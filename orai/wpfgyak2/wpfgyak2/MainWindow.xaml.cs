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

namespace wpfgyak2
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
            string nev = textbox.Text;
            string szulhely = textbox1.Text;
            string eletkor = textbox2.Text;

            if (nev == "" || szulhely == "" || eletkor == "")
            {
                MessageBox.Show("Töltsd ki mind!");
            }
            else
            {
                listbox.Items.Add(nev + ", " + szulhely + ", " + eletkor);

                textbox.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";
            }

        }
    }
}
