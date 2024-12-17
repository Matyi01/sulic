using System.Linq.Expressions;
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");

//IP

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

//GET

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

//dátumok

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

//referer

Regex minta4 = new Regex(@"https://www\.(\S+\.\S+)");

var talalat4 = minta4.Matches(text);

Dictionary<string, int> stats4 = new Dictionary<string, int>();
foreach (Match elem in talalat4)
{
    if (stats4.ContainsKey(elem.Groups[1].Value))
    {
        stats4[elem.Groups[1].Value]++;
    }
    else
    {
        stats4.Add(elem.Groups[1].Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats4)
{
    Console.WriteLine(elem);
}

//user agent, browser

Regex minta5 = new Regex(@"[A-Z][a-z]+/\S+""");

var talalat5 = minta5.Matches(text);

Dictionary<string, int> stats5 = new Dictionary<string, int>();
foreach (Match elem in talalat5)
{
    if (stats5.ContainsKey(elem.Value))
    {
        stats5[elem.Value]++;
    }
    else
    {
        stats5.Add(elem.Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats5)
{
    Console.WriteLine(elem);
}

//user agent, device

Regex minta6 = new Regex(@"\([^)]+\)");

var talalat6 = minta6.Matches(text);

Dictionary<string, int> stats6 = new Dictionary<string, int>();
foreach (Match elem in talalat6)
{
    if (stats6.ContainsKey(elem.Value))
    {
        stats6[elem.Value]++;
    }
    else
    {
        stats6.Add(elem.Value, 1);
    }
}
foreach (KeyValuePair<string, int> elem in stats6)
{
    Console.WriteLine(elem);
}