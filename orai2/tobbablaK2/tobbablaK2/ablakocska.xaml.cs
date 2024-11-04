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
    /// Interaction logic for ablakocska.xaml
    /// </summary>
    public partial class ablakocska : Window
    {
        MainWindow szulo;
        public ablakocska(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            szulo.button.Content = "Oké";
            this.Close();
        }
    }
}
