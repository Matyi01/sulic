using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfjatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        Random rnd = new Random();
        bool xo = false;
        string[] ttt = ["", "", "", "", "", "", "", "", ""];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            button.Margin = new Thickness(rnd.Next(1, (int)this.Width - 75), rnd.Next(1, (int)this.Height - 75), 0, 0);
        }
        private void button_MouseEnter1(object sender, MouseEventArgs e)
        {
            SetCursorPos(rnd.Next(1, (int)this.Width), rnd.Next(1, (int)this.Height));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            TicTacToe(button);
        }

        public void TicTacToe(Button button)
        {
            if (button.Content == "" && xo)
            {
                button.Content = "X";
                ttt[Convert.ToInt32(button.Name[1].ToString())] = "X";
            }
            else if (button.Content == "" && !xo)
            {
                button.Content = "O";
                ttt[Convert.ToInt32(button.Name[1].ToString())] = "O";
            }
            if (
                (ttt[0] == "X" && ttt[0] == ttt[1] && ttt[1] == ttt[2]) ||
                (ttt[3] == "X" && ttt[3] == ttt[4] && ttt[4] == ttt[5]) ||
                (ttt[6] == "X" && ttt[6] == ttt[7] && ttt[7] == ttt[8]) ||
                (ttt[0] == "X" && ttt[0] == ttt[3] && ttt[3] == ttt[6]) ||
                (ttt[1] == "X" && ttt[1] == ttt[4] && ttt[4] == ttt[7]) ||
                (ttt[2] == "X" && ttt[2] == ttt[5] && ttt[5] == ttt[8]) ||
                (ttt[0] == "X" && ttt[0] == ttt[4] && ttt[4] == ttt[8]) ||
                (ttt[6] == "X" && ttt[6] == ttt[4] && ttt[4] == ttt[2])
            )
            {
                label.Content = "game over - X won";
                b0.IsEnabled = false;
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
            }
            if (
                (ttt[0] == "O" && ttt[0] == ttt[1] && ttt[1] == ttt[2]) ||
                (ttt[3] == "O" && ttt[3] == ttt[4] && ttt[4] == ttt[5]) ||
                (ttt[6] == "O" && ttt[6] == ttt[7] && ttt[7] == ttt[8]) ||
                (ttt[0] == "O" && ttt[0] == ttt[3] && ttt[3] == ttt[6]) ||
                (ttt[1] == "O" && ttt[1] == ttt[4] && ttt[4] == ttt[7]) ||
                (ttt[2] == "O" && ttt[2] == ttt[5] && ttt[5] == ttt[8]) ||
                (ttt[0] == "O" && ttt[0] == ttt[4] && ttt[4] == ttt[8]) ||
                (ttt[6] == "O" && ttt[6] == ttt[4] && ttt[4] == ttt[2])
)
            {
                label.Content = "game over - O won";
                b0.IsEnabled = false;
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
            }
            if (
                ttt[0] != "" &&
                ttt[1] != "" &&
                ttt[2] != "" &&
                ttt[3] != "" &&
                ttt[4] != "" &&
                ttt[5] != "" &&
                ttt[6] != "" &&
                ttt[7] != "" &&
                ttt[8] != ""
            )
            {
                label.Content = "game over - draw";
                b0.IsEnabled = false;
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
            }

            xo = !xo;
        }
        public void AknaKereso(object sender, RoutedEventArgs e)
        {
            int sor = 9;
            int oszlop = 9;
            for (int y = 0; y < sor; y++)
            {
                for (int x = 0; x < oszlop; x++)
                {
                    Button gomb = new Button();

                    gomb.Content = y.ToString() + " " + x.ToString();
                    gomb.Name = "Button" + y.ToString();

                    gomb.Height = 30;
                    gomb.Width = 30;
                    gomb.Margin = new Thickness(gomb.Width * 2 * y - Width / 1.5, gomb.Height * 2 * x - Height / 1.5, 0, 0);

                    akna.Children.Add(gomb);
                }
            }
        }
    }
}