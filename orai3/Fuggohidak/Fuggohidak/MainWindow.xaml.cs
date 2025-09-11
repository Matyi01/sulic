using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fuggohidak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Fuggohid> fuggohidak = new List<Fuggohid>();
            string[] olvas = File.ReadAllLines("fuggohidak.csv");
            foreach (string e in olvas)
            {
                fuggohidak.Add(new Fuggohid(e));
            }
            foreach (Fuggohid e in fuggohidak)
            {
                listBox.Items.Add(e.hely);
            }




        }
    }
}