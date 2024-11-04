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
using System.Windows.Shapes;

namespace lotto
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow szulo;
        public Window1(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }
        Random rand = new Random();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            int szam = 0;
            if (szulo.textBlock.Text.Split(" ").Length < 6)
            {
                szam = rand.Next(1, 91);
                while (szulo.textBlock.Text.Contains(Convert.ToChar(szam)))
                {
                    szam = rand.Next(1, 91);
                }
                szulo.textBlock.Text += szam.ToString() + " ";
            }
            else if (szulo.textBlock1.Text.Split(" ").Length < 7)
            {
                szam = rand.Next(1, 46);
                while (szulo.textBlock1.Text.Contains(Convert.ToChar(szam)))
                {
                    szam = rand.Next(1, 46);
                }
                szulo.textBlock1.Text += szam.ToString() + " ";
            }
            else if (szulo.textBlock2.Text.Split(" ").Length < 8)
            {
                szam = rand.Next(1, 36);
                while (szulo.textBlock2.Text.Contains(Convert.ToChar(szam)))
                {
                    szam = rand.Next(1, 36);
                }
                szulo.textBlock2.Text += szam.ToString() + " ";
            }
            this.Close();
        }
    }
}
