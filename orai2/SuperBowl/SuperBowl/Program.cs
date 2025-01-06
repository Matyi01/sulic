using SuperBowl;

var text = File.ReadAllLines("SuperBowl.txt");

List<Eredmeny> eredmenyek = new List<Eredmeny>();

foreach (string line in text.Skip(1))
{

    eredmenyek.Add(Eredmeny(line.Split(";")));
}