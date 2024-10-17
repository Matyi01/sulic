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

namespace wpfgayak12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = textBox.Text;
            if (szoveg != "")
            {
                lista.Add(szoveg);
                textBlock.Text = String.Join(", ", lista.ToArray());

                listBox.Items.Add(szoveg);
                textBox.Text = "";
            }
        }
        private void textBox_KeyDown_1(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string szoveg = textBox.Text;
                if (szoveg != "")
                {
                    lista.Add(szoveg);
                    textBlock.Text = String.Join(", ", lista.ToArray());

                    listBox.Items.Add(szoveg);
                    textBox.Text = "";
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (lista.Count > 0)
            {
                lista.RemoveAt(lista.Count - 1);
                textBlock.Text = String.Join(", ", lista.ToArray());
                listBox.Items.RemoveAt(listBox.Items.Count - 1);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Focus();
        }
    }
}