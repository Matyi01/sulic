using link1;

string[] text = File.ReadAllLines("felajanlas.txt");

List<Adatok> viragok = new List<Adatok>();

foreach (string line in text.Skip(1))
{
    viragok.Add(new Adatok(line));
}

int agyasdb = int.Parse(text[0]);