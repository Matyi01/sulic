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

namespace wpfsql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connStr = "Server = localhost;User ID=root;Password=;Database=";
            using var cn = new MySqlConnection(connStr);
            cn.Open();
            string create = "create database if not exists fiokok default charset=utf8 collate=utf8_hungarian_ci;";
            string use = "use fiokok;";
            string table = "CREATE TABLE varos\r\n(\r\nid int(10) NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\niranyszam int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE 'varos'\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE fiok\r\n(\r\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nvarosid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nfelhnev varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nveznevid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\njeszo varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nkeresztnevid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nemail varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nszuldatum date() COLLATE utf8-utf8_hungarian_ci NOT NULL\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE fiok\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE keresztnev\r\n(\r\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE keresztnev\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE vezeteknev\r\n(\r\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE vezeteknev\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;";
            using var cmd = new MySqlCommand(create, cn);
            using var cmd1 = new MySqlCommand(use, cn);
            using var cmd2 = new MySqlCommand(table, cn);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
        }
    }
}
