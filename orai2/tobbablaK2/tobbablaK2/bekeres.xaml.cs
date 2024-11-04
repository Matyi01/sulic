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

namespace tobbablaK2
{
    /// <summary>
    /// Interaction logic for bekeres.xaml
    /// </summary>
    public partial class bekeres : Window
    {
        MainWindow szulo;
        public bekeres(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 2)
            {
                szulo.textBlock.Text = textBox.Text;
                this.Close();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Focus();
            textBox.Text = szulo.textBlock.Text;
        }
    }
}
