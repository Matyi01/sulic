using System;
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

namespace tanciskolawpf
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

        List<Par> tancok = new List<Par>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("tancrend.txt");
            while (!olvas.EndOfStream)
            {
                string[] sorok = new string[3];
                for (int i = 0; i < sorok.Length; i++)
                {
                    sorok[i] = olvas.ReadLine();
                }
                tancok.Add(new Par(sorok[0], sorok[1], sorok[2]));
            }

            olvas.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Első tánc: " + tancok[0].tanc + ", utolsó tánc: " + tancok.Last().tanc + ".";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private int tancszamol(string nev)
        {
            int db = 0;
            for (int i = 0; i < tancok.Count; i++)
            {
                if (tancok[i].tanc == nev)
                    db++;
            }
            return db;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<string> lanyok = new List<string>();
            List<string> fiuk = new List<string>();

            for (int i = 0; i < tancok.Count; i++)
            {
                if (!lanyok.Contains(tancok[i].lany))
                {
                    lanyok.Add(tancok[i].lany);
                }
                if (!fiuk.Contains(tancok[i].fiu))
                {
                    fiuk.Add(tancok[i].fiu);
                }
            }

            StreamWriter ir = new StreamWriter("szereplok.txt");
            ir.WriteLine("lanyok: {0}", String.Join(", ", lanyok));
            ir.WriteLine("Fiúk: {0}", String.Join(", ", fiuk));
            ir.Close();

            ir = new StreamWriter("szereplok.xml");
            ir.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            ir.WriteLine("<tancosok>");
            ir.WriteLine("\t<fiuk>");
            ir.WriteLine("\t\t<nev>{0}</nev>", String.Join("</nev>\r\n\t\t<nev>", fiuk));
            ir.WriteLine("\t</fiuk>");
            ir.WriteLine("\t<lanyok>");
            ir.WriteLine("\t\t<nev>{0}</nev>", String.Join("</nev>\r\n\t\t<nev>", lanyok));
            ir.WriteLine("\t</lanyok>");
            ir.WriteLine("</tancosok>");
            ir.Close();

            //xml-ben kiiras file-ba
            /*
            <?xml version="1.0" encoding="UTF-8"?>

            <tancosok>
                <fiuk>
                    <nev>...</nev>
                    <nev>...</nev>
                    <nev>...</nev>
                </fiuk>
            </tancosok>
             */
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> statfiuk = new Dictionary<string, int>();
            Dictionary<string, int> statlanyok = new Dictionary<string, int>();

            for (int i = 0; i < tancok.Count; i++)
            {
                if (!statfiuk.ContainsKey(tancok[i].fiu))
                {
                    statfiuk.Add(tancok[i].fiu, 1);
                }
                else
                {
                    statfiuk[tancok[i].fiu] += 1;
                }
                if (!statlanyok.ContainsKey(tancok[i].lany))
                {
                    statlanyok.Add(tancok[i].lany, 1);
                }
                else
                {
                    statlanyok[tancok[i].lany] += 1;
                }
            }

            int fiukmax = statfiuk.Values.Max();

            //textBlock3.Text = 
        }
    }
}
