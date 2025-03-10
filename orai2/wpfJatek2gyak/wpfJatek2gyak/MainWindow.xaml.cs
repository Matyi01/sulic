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
        int aknadb = 10;
        Button[,] gombok;
        int[,] aknahely;
        Random rnd = new Random();
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

            aknalerak();
            for (int i = 0; i < aknahely.GetLength(0); i++)
            {
                for (int j = 0; j < aknahely.GetLength(1); j++)
                {
                    if (aknahely[i, j] != 10)
                    {
                        aknahely[i, j] = aknaszamol(i, j);
                    }
                }
            }
            aknamutat();

        }
        void aknalerak()
        {
            aknahely = new int[sor, oszlop];
            for (int i = 0; i < aknadb; i++)
            {
                int rndsor = rnd.Next(sor);
                int rndoszlop = rnd.Next(oszlop);
                if (aknahely[rndsor, rndoszlop] == 10)
                {
                    i--;
                }
                else
                {
                    aknahely[rndsor, rndoszlop] = 10; //1db akna random helyre
                }
            }
        }
        void aknamutat()
        {
            for (int i = 0; i < aknahely.GetLength(0); i++)
            {
                for (int j = 0; j < aknahely.GetLength(1); j++)
                {
                    gombok[i, j].Content = aknahely[i, j];
                }
            }
        }
        int aknaszamol(int sor, int oszlop)
        {
            int db = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int newSor = sor + i;
                    int newOszlop = oszlop + j;
                    if (newSor >= 0 && newSor < aknahely.GetLength(0) && newOszlop >= 0 && newOszlop < aknahely.GetLength(1))
                    {
                        if (aknahely[newSor, newOszlop] == 10)
                        {
                            db++;
                        }
                    }
                }
            }
            return db;
        }
        public void kattintas(object sender, RoutedEventArgs e)
        {

        }
    }
}