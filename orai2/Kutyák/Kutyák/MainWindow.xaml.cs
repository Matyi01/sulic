using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Kutyák
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<KutyaNev> nevek = new List<KutyaNev>();
            List<string> sorok = File.ReadAllLines("KutyaNevek.csv").ToList();
            foreach (string e in sorok.Skip(1))
            {
                nevek.Add(new KutyaNev(e));
            }
            textBlock.Text = "3. feladat: nevek száma: " + nevek.Count;

            List<KutyaFajta> fajtak = new List<KutyaFajta>();
            List<string> sorok2 = File.ReadAllLines("KutyaFajtak.csv").ToList();
            foreach (string e in sorok2.Skip(1))
            {
                fajtak.Add(new KutyaFajta(e));
            }

            List<Kutya> kutyak = new List<Kutya>();
            List<string> sorok3 = File.ReadAllLines("Kutyak.csv").ToList();
            foreach (string e in sorok3.Skip(1))
            {
                kutyak.Add(new Kutya(e));
            }

            List<int> eletkorok = new List<int>();
            foreach (Kutya e in kutyak)
            {
                eletkorok.Add(e.kor);
            }
            textBlock1.Text = "6. feladat: átlag életkor: " + Math.Round(Convert.ToDecimal(eletkorok.Sum()) / eletkorok.Count(), 2);

            Kutya legidosebb = kutyak[0];
            foreach (Kutya e in kutyak)
            {
                if (eletkorok.Max() == e.kor)
                {
                    legidosebb = e;
                }
            }
            textBlock2.Text = "7. feladat: legidősebb: " + nevek.Where(e => e.id == legidosebb.nevid).ToArray()[0].nev + ", " + fajtak.Where(e => e.id == legidosebb.fajid).ToArray()[0].nev;

            Dictionary<string, int> rendelo = new Dictionary<string, int>();
            foreach (Kutya e in kutyak)
            {
                if (e.datum.Year == 2018 && e.datum.Month == 01 && e.datum.Day == 10)
                {
                    if (!rendelo.ContainsKey(fajtak.Where(f => f.id == e.fajid).ToArray()[0].nev))
                    {
                        rendelo.Add(fajtak.Where(f => f.id == e.fajid).ToArray()[0].nev, 1);
                    }
                    else
                    {
                        rendelo[fajtak.Where(f => f.id == e.fajid).ToArray()[0].nev]++;
                    }
                }
            }
            textBlock3.Text = "8. feladat: január 10-én vizsgált fajták:";
            foreach (var e in rendelo)
            {
                ListBoxItem elem = new ListBoxItem();
                elem.Content = e.Key + ": " + e.Value;
                listBox.Items.Add(elem);
            }

            Dictionary<DateOnly, int> rendelo2 = new Dictionary<DateOnly, int>();
            foreach (Kutya e in kutyak)
            {
                if (!rendelo2.ContainsKey(e.datum))
                {
                    rendelo2.Add(e.datum, 1);
                }
                else
                {
                    rendelo2[e.datum]++;
                }
            }
            KeyValuePair<DateOnly, int> legterheltebb = new KeyValuePair<DateOnly, int>();
            foreach (var e in rendelo2)
            {
                if (e.Value == rendelo2.Values.Max())
                {
                    legterheltebb = new KeyValuePair<DateOnly, int>(e.Key, e.Value);
                }
            }
            textBlock4.Text = "9. feldaat: legjobban leterhelt nap: " + legterheltebb.Key + ": " + legterheltebb.Value;

            Dictionary<string, int> nevlista = new Dictionary<string, int>();
            foreach (Kutya e in kutyak)
            {
                if (!nevlista.ContainsKey(nevek.Where(f => f.id == e.nevid).ToArray()[0].nev))
                {
                    nevlista.Add(nevek.Where(f => f.id == e.nevid).ToArray()[0].nev, 1);
                }
                else
                {
                    nevlista[nevek.Where(f => f.id == e.nevid).ToArray()[0].nev]++;
                }
            }
            List<KeyValuePair<string, int>> nevlista2 = nevlista.ToList();
            nevlista2.Sort((egyik, masik) => egyik.Value.CompareTo(masik.Value));
            StreamWriter ir = new StreamWriter("Névstatisztika.txt");
            nevlista2.Reverse();
            foreach (var e in nevlista2)
            {
                ir.WriteLine(e.Key + ";" + e.Value);
            }
            ir.Close();
        }
    }
}