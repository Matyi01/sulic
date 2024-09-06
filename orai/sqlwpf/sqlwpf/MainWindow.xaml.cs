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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySqlConnector;

namespace sqlwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connStr = "Server=localhost; User ID=root; Password=; Database=";
            using var cn = new MySqlConnection(connStr);
            cn.Open();
            string query = "create database (if not exist) gyorsposta default charset utf8 collate utf8_hungarian_ci;";
            using var cmd = new MySqlCommand(query, cn);
            /*
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBlock.Text += reader["tables_in_nyiltnap"];
            }
            */
        }
    }
}
