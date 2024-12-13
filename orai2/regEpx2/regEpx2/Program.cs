using System.Linq.Expressions;
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");

Regex minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

var talalat = minta.Matches(text);
//Console.WriteLine(talalat.Count);
foreach (Match elem in talalat)
{
    //Console.WriteLine(elem);
}

Dictionary<string, int> stats = new Dictionary<string, int>();
foreach (Match elem in talalat)
{
    if (stats.ContainsKey(elem.Value))
    {
        stats[elem.Value]++;
    }
    else
    {
        stats.Add(elem.Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats)
{
    if (elem.Value != 1)
    {
        Console.WriteLine(elem);
    }
}

Regex minta2 = new Regex(@"GET (/\S*)");

var talalat2 = minta2.Matches(text);
//Console.WriteLine(talalat2.Count);
foreach (Match elem in talalat2)
{
    //Console.WriteLine(elem.Groups[1].Value);
}

Dictionary<string, int> stats2 = new Dictionary<string, int>();
foreach (Match elem in talalat2)
{
    if (stats2.ContainsKey(elem.Value))
    {
        stats2[elem.Value]++;
    }
    else
    {
        stats2.Add(elem.Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats2)
{
    if (elem.Value != 1)
    {
        Console.WriteLine(elem);
    }
}


Regex minta3 = new Regex(@"\S{3} (\d|\d{2}) \d{4}");

var talalat3 = minta3.Matches(text);
//Console.WriteLine(talalat3.Count);
foreach (Match elem in talalat3)
{
    //Console.WriteLine(elem);
}

Dictionary<string, int> stats3 = new Dictionary<string, int>();
foreach (Match elem in talalat3)
{
    if (stats3.ContainsKey(elem.Value))
    {
        stats3[elem.Value]++;
    }
    else
    {
        stats3.Add(elem.Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats3)
{
    Console.WriteLine(elem);
}