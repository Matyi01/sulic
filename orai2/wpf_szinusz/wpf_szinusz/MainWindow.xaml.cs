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
using System.Windows.Threading;

namespace wpf_szinusz
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
        int r = 45;
        int origoy = 0;
        int origox = 0;
        int x = 0;
        bool no = true;
        private void vaszon_Loaded(object sender, RoutedEventArgs e)
        {
            origoy = (int)Height / 2;
            origox = (int)(r * 1.1);
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzol;
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();

        }
        void rajzol(object sender, EventArgs e)
        {
            vaszon.Children.Clear();

            koordinataRajzol();
            kor(x);
            sugar(x);
            magassag(x);
            pont(x);
            koriv(x);
            korivkicsi(x);
            hullam(x);
            if (no)
            {
                x++;
            }
            else
            {
                x--;
            }
            if (x == 360)
            {
                no = false;
            }
            if (x == 0)
            {
                no = true;
            }
        }
        void koordinataRajzol()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoy;
            xTengely.X2 = Width;
            xTengely.Y2 = origoy;
            vaszon.Children.Add(xTengely);

            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = origox;
            yTengely.Y1 = 0;
            yTengely.X2 = origox;
            yTengely.Y2 = Height;
            vaszon.Children.Add(yTengely);

            for (int i = 1; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = origox + i * 90;
                vonalka.Y1 = origoy - 5;
                vonalka.X2 = origox + i * 90;
                vonalka.Y2 = origoy + 5;
                vaszon.Children.Add(vonalka);
            }

            for (int i = -2; i < 3; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = origox - 5;
                vonalka.Y1 = origoy + i * (r / 2);
                vonalka.X2 = origox + 5;
                vonalka.Y2 = origoy + i * (r / 2);
                vaszon.Children.Add(vonalka);
            }
        }
        void kor(int x)
        {
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Black;
            kor.Width = 2 * r;
            kor.Height = 2 * r;
            kor.Margin = new Thickness(origox + x - (Math.Cos(Math.PI / 180.0 * x) * r) - r, origoy - r, 0, 0);
            vaszon.Children.Add(kor);
        }
        void sugar(int x)
        {
            Line sugar = new Line();
            sugar.Stroke = Brushes.Black;
            sugar.StrokeThickness = 3;
            sugar.X1 = origox + x - Math.Cos(Math.PI / 180.0 * x) * r;
            sugar.Y1 = origoy;
            sugar.X2 = origox + x;
            sugar.Y2 = origoy - Math.Sin(Math.PI / 180.0 * x) * r;
            vaszon.Children.Add(sugar);
        }
        void pont(int x)
        {
            Ellipse pont = new Ellipse();
            pont.Stroke = Brushes.Black;
            pont.Width = r * 0.08;
            pont.Height = r * 0.08;
            pont.Margin = new Thickness(origox + x - r * 0.08 / 2, origoy - r * 0.08 / 2, 0, 0);
            pont.Fill = Brushes.Black;
            vaszon.Children.Add(pont);
        }
        void magassag(int x)
        {
            Line m = new Line();
            m.Stroke = Brushes.Red;
            m.StrokeThickness = 3;
            m.X1 = origox + x;
            m.Y1 = origoy;
            m.X2 = origox + x;
            m.Y2 = origoy - Math.Sin(Math.PI / 180.0 * x) * r;
            vaszon.Children.Add(m);
        }
        void koriv(int x)
        {
            Path iv = new Path();
            iv.Stroke = Brushes.Blue;
            iv.StrokeThickness = 3;
            PathGeometry pg = new PathGeometry();
            PathFigure pf = new PathFigure();
            pf.StartPoint = new Point(origox + x, origoy - Math.Sin(Math.PI / 180.0 * x) * r);
            ArcSegment arc = new ArcSegment();
            arc.Point = new Point(origox + x - Math.Cos(Math.PI / 180.0 * x) * r + r, origoy);
            arc.Size = new Size(r, r);
            arc.SweepDirection = SweepDirection.Clockwise;
            if (x < 180)
            {
                arc.IsLargeArc = false;
            }
            else
            {
                arc.IsLargeArc = true;
            }
            pf.Segments.Add(arc);
            pg.Figures.Add(pf);
            iv.Data = pg;
            vaszon.Children.Add(iv);
        }
        void korivkicsi(int x)
        {
            Path iv = new Path();
            iv.Stroke = Brushes.Blue;
            iv.StrokeThickness = 1;
            PathGeometry pg = new PathGeometry();
            PathFigure pf = new PathFigure();
            pf.StartPoint = new Point(origox + x - Math.Cos(Math.PI / 180.0 * x) * r + r * 0.2, origoy);
            ArcSegment arc = new ArcSegment();
            arc.Point = new Point(origox + x - (origox + x - (origox + x - Math.Cos(Math.PI / 180.0 * x) * r)) * 0.8, origoy - Math.Sin(Math.PI / 180.0 * x) * r - ((origoy - Math.Sin(Math.PI / 180.0 * x) * r) - origoy) * 0.8);
            arc.Size = new Size(r * 0.2, r * 0.2);
            arc.SweepDirection = SweepDirection.Counterclockwise;
            if (x < 180)
            {
                arc.IsLargeArc = false;
            }
            else
            {
                arc.IsLargeArc = true;
            }
            pf.Segments.Add(arc);
            pg.Figures.Add(pf);
            iv.Data = pg;
            vaszon.Children.Add(iv);
        }
        PointCollection pontok = new PointCollection();
        void hullam(int x)
        {
            Polyline vonal = new Polyline();
            vonal.Stroke = Brushes.Red;
            vonal.StrokeThickness = 2;
            if (no)
            {
                pontok.Add(new Point(origox + x, origoy - Math.Sin(Math.PI / 180.0 * x) * r));
            }
            else
            {
                pontok.RemoveAt(pontok.Count - 1);
            }
            vonal.Points = pontok;


            vaszon.Children.Add(vonal);
        }
    }
}