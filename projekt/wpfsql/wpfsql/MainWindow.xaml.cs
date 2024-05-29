using System;
using System.Collections;
using System.Collections.Generic;
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

            string table = "CREATE TABLE varos\\\\r\\\\n(\\\\r\\\\nid int(10) NOT NULL,\\\\r\\\\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\niranyszam int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\\\\r\\\\n\\\\r\\\\nALTER TABLE 'varos'\\\\r\\\\n    ADD PRIMARY KEY('id')\\\\r\\\\nCOMMIT;\\\\r\\\\n\\\\r\\\\n\\\\r\\\\nCREATE TABLE fiok\\\\r\\\\n(\\\\r\\\\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nvarosid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nfelhnev varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nveznevid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\njeszo varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nkeresztnevid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nemail varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nszuldatum date() COLLATE utf8-utf8_hungarian_ci NOT NULL\\\\r\\\\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\\\\r\\\\n\\\\r\\\\nALTER TABLE fiok\\\\r\\\\n    ADD PRIMARY KEY('id')\\\\r\\\\nCOMMIT;\\\\r\\\\n\\\\r\\\\n\\\\r\\\\nCREATE TABLE keresztnev\\\\r\\\\n(\\\\r\\\\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL\\\\r\\\\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\\\\r\\\\n\\\\r\\\\nALTER TABLE keresztnev\\\\r\\\\n    ADD PRIMARY KEY('id')\\\\r\\\\nCOMMIT;\\\\r\\\\n\\\\r\\\\n\\\\r\\\\nCREATE TABLE vezeteknev\\\\r\\\\n(\\\\r\\\\nid int() COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\\\\r\\\\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\\\\r\\\\n\\\\r\\\\nALTER TABLE vezeteknev\\\\r\\\\n    ADD PRIMARY KEY('id')\\\\r\\\\nCOMMIT;";



            string connStr = "Server=localhost; User ID=root; Password=; Database=fiokok";

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

                    string query = "create database if not exists fiokok default charset utf8 collate utf8_hungarian_ci;";
                    var cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    List<string> queries = new List<string>();
                    queries.Add("use fiokok;");
                    queries.Add("CREATE TABLE fiok (id int(10) NOT NULL,varosid int(10),felhasznalonev varchar(50) NOT NULL,vezeteknevid int(10) NOT NULL,jelszo varchar(50),keresztnevid int(10),email varchar(50), szuldatom DATE);");
                    queries.Add("CREATE TABLE varos (id int(10) NOT NULL,neve varchar(50),iranyszam int(10))");
                    queries.Add("CREATE TABLE vezeteknev (id int(10) NOT NULL,neve varchar(50))");
                    queries.Add("CREATE TABLE keresztnev (id int(10) NOT NULL,neve varchar(50))");


                    for (int i = 0; i < queries.Count; i++)
                    {
                        cmd = new MySqlCommand(queries[i], cn);
                        cmd.ExecuteNonQuery();
                    }



                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string fnev = textBox.Text;
            string vnev = textBox1.Text;
            string knev = textBox2.Text;
            string jelszo = textBox3.Text;
            string email = textBox4.Text;

            string reg = "insert into fiok values (0, 0, \"matyi\", 0,\"pass\", 0, \"mail\", 2000-01-01);";

            string connStr = "Server=localhost; User ID=root; Password=; Database=fiokok";

            using var cn = new MySqlConnection(connStr);
            cn.Open();

            var cmd = new MySqlCommand(reg, cn);
            cmd.ExecuteNonQuery();

        }
    }
}