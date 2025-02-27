using System.Runtime.InteropServices;
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
                label.Content = button.Name[1];
                ttt[Convert.ToInt32(button.Name[1].ToString())] = "X";
            }
            else if (button.Content == "" && !xo)
            {
                button.Content = "O";
                label.Content = button.Name[1];
                ttt[Convert.ToInt32(button.Name[1].ToString())] = "O";
            }
            if(
                (ttt[0] != "" && ttt[0] == ttt[1] && ttt[1] == ttt[2]) ||
                (ttt[3] != "" && ttt[3] == ttt[4] && ttt[4] == ttt[5]) ||
                (ttt[6] != "" && ttt[6] == ttt[7] && ttt[7] == ttt[8]) ||
                (ttt[0] != "" && ttt[0] == ttt[3] && ttt[3] == ttt[6]) ||
                (ttt[1] != "" && ttt[1] == ttt[4] && ttt[4] == ttt[7]) ||
                (ttt[2] != "" && ttt[2] == ttt[5] && ttt[5] == ttt[8]) ||
                (ttt[0] != "" && ttt[0] == ttt[4] && ttt[4] == ttt[8]) ||
                (ttt[6] != "" && ttt[6] == ttt[4] && ttt[4] == ttt[2])
            )
            {
                label.Content = "game over";
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
    }
}