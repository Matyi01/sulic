using System.Collections;
using System.ComponentModel.Design;

List<Tehen> happyCows = new List<Tehen>();

StreamReader olvas = new StreamReader("hozam.txt");
while (!olvas.EndOfStream)
{
    string adatSor = olvas.ReadLine();
    string id = adatSor.Split(";")[0];
    string nap = adatSor.Split(";")[1];
    string mennyiseg = adatSor.Split(";")[2];
    Tehen aktTehen = new Tehen(id);

    if (!happyCows.Contains(aktTehen))
    {
        happyCows.Add(aktTehen);
    }

    int index = happyCows.IndexOf(aktTehen);
    happyCows[index].EredmenytRogzit(nap, mennyiseg);
}
olvas.Close();

Console.WriteLine("3. feladat");
Console.WriteLine("Az állomány {0} tehén adatait tartalmazza.", happyCows.Count);

for (int i = 0; i < happyCows.Count; i++)
{
    Console.WriteLine(happyCows[i].hetiAtlag);
}




class Tehen : IEquatable<Tehen>
{

    public string Id { get; private set; }
    public int[] Mennyisegek { get; private set; }

    public bool Equals(Tehen masik)
    {
        return masik != null && masik.Id == this.Id;
    }

    public void EredmenytRogzit(string nap, string menyiseg)
    {
        Mennyisegek[int.Parse(nap)] = int.Parse(menyiseg);
    }

    public Tehen(string id)
    {
        Id = id;
        Mennyisegek = new int[7];
    }

    public int hetiTej
    {
        get
        {
            return Mennyisegek.Sum();
        }
    }
    /*
    public int hetiAtlag
    {
        get
        {
            //int result = intArray.Count(i => i != 0);
            int result = Mennyisegek.Count(i => i != 0);
            if (result < 5);
            {
                return hetiTej / 7;
            }
            else
            {
                return -1;
            }

        }
    }
    */
}