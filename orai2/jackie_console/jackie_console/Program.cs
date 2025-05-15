using jackie_console;

List<VersenyEv> versenyEvek = new List<VersenyEv>();

string[] sorok = File.ReadAllLines("jackie.txt");

foreach (string s in sorok.Skip(1))
{
    string[] vag = s.Split("\t");
    versenyEvek.Add(new VersenyEv(
        int.Parse(vag[0]),
        int.Parse(vag[1]),
        int.Parse(vag[2]),
        int.Parse(vag[3]),
        int.Parse(vag[4]),
        int.Parse(vag[5])
        ));
}

int maxindex = 0;
for (int i = 0; i < versenyEvek.Count; i++)
{
    if (versenyEvek[i].versenydb > versenyEvek[maxindex].versenydb)
    {
        maxindex = i;
    }
}

Console.WriteLine("3. feladat: {0}", versenyEvek.Count);

Console.WriteLine("4.feladat: {0}", versenyEvek[maxindex].ev);

Dictionary<int, int> evtizedek = new Dictionary<int, int>();
for (int i = 0; i < versenyEvek.Count; ++i)
{
    if (evtizedek.ContainsKey(versenyEvek[i].evtized))
    {
        evtizedek[versenyEvek[i].evtized] += versenyEvek[i].nyert;
    }
    else
    {
        evtizedek.Add(versenyEvek[i].evtized, versenyEvek[i].nyert);
    }
}

Console.WriteLine("5. feladat:");
foreach (KeyValuePair<int,int> e in evtizedek)
{
    Console.WriteLine("\t{0}-es évek: {1} megnyert verseny",e.Key, e.Value);
}

string html = "<!doctype html>" +
"<html>" +
"<head></head>" +
"<style>td { border: 1px solid black;}</style>" +
"<body>" +
"<h1> Jackie Stewart </h1>" +
"<table>";
for (int i = 0;i < versenyEvek.Count; i++)
{
    html += "<tr>";
    html += "<td>";
    html += versenyEvek[i].ev;
    html += "</td>";
    html += "<td>";
    html += versenyEvek[i].versenydb;
    html += "</td>";
    html += "<td>";
    html += versenyEvek[i].nyert;
    html += "</td>";
    html += "</tr>";
}
html += "</table>" +
"</body>" +
"</html>";

File.WriteAllText("jackie.html", html);

/*
<!doctype html>
<html>
<head></head>
<style>td { border: 1px solid black;}</style>
<body>
<h1>Jackie Stewart</h1>
<table>
    
</table>
</body>
</html>
 */