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

namespace wpfJatek2gyak
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
        int sor = 9;
        int oszlop = 9;
        Button[,] gombok;
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            gombok = new Button[sor, oszlop];
            for (int j = 0; j < sor; j++)
            {
                for (int i = 0; i < oszlop; i++)
                {
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Width = 35;
                    g.Height = 35;
                    g.Click += kattintas;
                    g.Margin = new Thickness(i * 35, j * 35, 0, 0);
                    Grid.Children.Add(g);
                    gombok[j, i] = g;
                }
            }
            this.SizeToContent = SizeToContent.WidthAndHeight;
            this.ResizeMode = ResizeMode.NoResize;
        }
        void aknalerak()
        {

        }
        public void kattintas(object sender, RoutedEventArgs e)
        {

        }
    }
}