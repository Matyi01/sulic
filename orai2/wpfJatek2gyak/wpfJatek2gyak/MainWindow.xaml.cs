using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
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
        Brush[] szinek = [Brushes.White, Brushes.Blue, Brushes.Green, Brushes.Red, Brushes.Purple];
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
                    g.MouseRightButtonDown += jobbkattintas;
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
            //aknamutat();

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
                    if (aknahely[i, j] == 0)
                    {
                        gombok[i, j].Content = "";
                        gombok[i, j].Background = Brushes.White;
                    }
                    else if (aknahely[i, j] == 10)
                    {
                        gombok[i, j].Content = "💣";
                    }
                    else
                    {
                        if (aknahely[i, j] > 0 && aknahely[i, j] < 10)
                        {
                            gombok[i, j].Foreground = szinek[aknahely[i, j]];
                        }
                        gombok[i, j].Content = aknahely[i, j];

                    }
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
                    if (sor + i >= 0 && sor + i < aknahely.GetLength(0) && oszlop + j >= 0 && oszlop + j < aknahely.GetLength(1))
                    {
                        if (aknahely[sor + i, oszlop + j] == 10)
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
            Button button = sender as Button;

            for (int i = 0; i < aknahely.GetLength(0); i++)
            {
                for (int j = 0; j < aknahely.GetLength(1); j++)
                {
                    if (gombok[i, j] == button)
                    {
                        helyellenoriz(i, j);
                        i = gombok.GetLength(0);
                        j = gombok.GetLength(1);
                    }
                }
            }
        }
        public void jobbkattintas(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < aknahely.GetLength(0); i++)
            {
                for (int j = 0; j < aknahely.GetLength(1); j++)
                {
                    if (gombok[i, j] == button)
                    {
                        if (gombok[i, j].Content == null)
                        {
                            gombok[i, j].Content = "🚩";
                        }
                        else if (gombok[i, j].Content == "🚩")
                        {
                            gombok[i, j].Content = "";
                        }
                        i = gombok.GetLength(0);
                        j = gombok.GetLength(1);
                    }
                }
            }
        }
        public void helyellenoriz(int i, int j)
        {
            if (i < 0 || i >= aknahely.GetLength(0) || j < 0 || j >= aknahely.GetLength(1))
            {
                return;
            }
            if (gombok[i, j].Content != null)
            {
                return;
            }
            if (aknahely[i, j] == 10)
            {
                aknamutat();
                MessageBox.Show("Vesztettél!");
                Close();
                return;
            }
            if (aknahely[i, j] != 0)
            {
                gombok[i, j].Content = aknahely[i, j];
                gombok[i, j].Foreground = szinek[aknahely[i, j]];
                gombok[i, j].Background = Brushes.White;
                return;
            }
            if (aknahely[i, j] == 0)
            {
                gombok[i, j].Content = "";
                gombok[i ,j].Background = Brushes.White;
                helyellenoriz(i - 1, j);
                helyellenoriz(i + 1, j);
                helyellenoriz(i, j - 1);
                helyellenoriz(i, j + 1);
            }
        }
    }
}