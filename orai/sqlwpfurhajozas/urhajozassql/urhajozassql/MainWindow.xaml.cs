using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
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

namespace urhajozassql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            string connStr = "Server=localhost; User ID=root; Password=; Database=urhajozas";

            try
            {
                using var cn = new MySqlConnection(connStr);
                cn.Open();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unknown database"))
                {
                    MessageBox.Show("nincs adatbázis");

                    connStr = "Server=localhost; User ID=root; Password=; Database=";
                    using var cn = new MySqlConnection(connStr);
                    cn.Open();

                    string query = "create database if not exists urhajozas default charset utf8 collate utf8_hungarian_ci;";
                    var cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    List<string> queries = new List<string>();
                    queries.Add("use urhajozas;");
                    queries.Add("CREATE TABLE `kuldetes` (`id` int(11) NOT NULL,`megnevezes` varchar(100) ,`kezdet` date NOT NULL,`veg` date NOT NULL);");
                    queries.Add("CREATE TABLE `repules` (`urhajosid` int(11) NOT NULL,`kuldetesid` int(11) NOT NULL);");
                    queries.Add("CREATE TABLE `urhajos` (`id` int(11) NOT NULL,`nev` varchar(100) ,`orszag` varchar(100) ,`nem` varchar(100) ,`szulev` int(11) NOT NULL,`urido` varchar(100));");
                    queries.Add("ALTER TABLE `repules`ADD PRIMARY KEY(`urhajosid`,`kuldetesid`);");
                    queries.Add("ALTER TABLE `urhajos`ADD PRIMARY KEY(`id`);");

                    for (int i = 0; i < queries.Count; i++)
                    {
                        cmd = new MySqlCommand(queries[i], cn);
                        cmd.ExecuteNonQuery();
                    }

                    StreamReader olvas = new StreamReader(connStr);
                    string parancsok = olvas.ReadToEnd();
                    olvas.Close();

                    new MySqlCommand(parancsok, cn).ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            /*
            string query = "";
            using var cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            */
        }
    }
}
