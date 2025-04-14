using Nyelvvizsga;
using System.Collections.Generic;

static List<NyelvAdat> fajlbetolt(string filename)
{
    List<NyelvAdat> adatok = new List<NyelvAdat>();

    StreamReader olvas = new StreamReader(filename + ".csv");

    int[] evek = olvas.ReadLine().Split(";").Skip(1).Select(int.Parse).ToArray();

    while (!olvas.EndOfStream)
    {
        string sor = olvas.ReadLine();
        adatok.Add(new NyelvAdat(sor, evek));
    }

    olvas.Close();

    return adatok;
}

List<NyelvAdat> sikeres = fajlbetolt("sikeres");
List<NyelvAdat> sikertelen = fajlbetolt("sikertelen");


