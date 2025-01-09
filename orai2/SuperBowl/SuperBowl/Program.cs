//https://dload-oktatas.educatio.hu/erettsegi/feladatok_2022tavasz_kozep/k_infoism_22maj_fl.pdf
using SuperBowl;

var text = File.ReadAllLines("SuperBowl.txt");

List<Eredmeny> eredmenyek = new List<Eredmeny>();

foreach (string line in text.Skip(1))
{
    Eredmeny e = new(line.Split(";"));
    eredmenyek.Add(e);
}

Console.WriteLine("4. feladat: Döntők száma: {0}", eredmenyek.Count);
