using System.Linq.Expressions;
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-16T09_53_52.397Z.txt");


Regex minta1 = new Regex(@"POST /\S* \S* \S* (\S*)");
var talalat1 = minta1.Matches(text);
int osszPOST = 0;
foreach (Match elem in talalat1)
{
    osszPOST += Convert.ToInt32(elem.Groups[1].Value);
}
Console.WriteLine("Mennyi volt az összes POST-ra érkezett adatmennyiség? " + osszPOST);


Regex minta2 = new Regex(@"DELETE");
var talalat2 = minta2.Matches(text);
Console.WriteLine("Mennyi törlés történt? " + talalat2.Count);


Regex minta3 = new Regex(@"(GET|POST|PUT|DELETE) (/\S*)");
var talalat3 = minta3.Matches(text);
Dictionary<string, int> stats3 = new Dictionary<string, int>();
foreach (Match elem in talalat3)
{
    if (stats3.ContainsKey(elem.Groups[2].Value))
    {
        stats3[elem.Groups[2].Value]++;
    }
    else
    {
        stats3.Add(elem.Groups[2].Value, 1);
    }
}
Console.Write("Melyik volt a leglátogatottabb oldal? ");
foreach (KeyValuePair<string, int> elem in stats3)
{
    if (elem.Value == stats3.Values.Max())
    {
        Console.WriteLine(elem.Key);
    }
}


Regex minta4 = new Regex(@"(GET|POST|PUT|DELETE) (\S+) \S+ (\S+) \S+ ""-""");
var talalat4 = minta4.Matches(text);
StreamWriter ir = new StreamWriter("noreferer.log");
foreach (Match elem in talalat4)
{
    ir.WriteLine(elem.Groups[2].Value + "\t" + elem.Groups[1].Value + ", " + elem.Groups[3].Value);
}
ir.Close();


Regex minta5 = new Regex(@" ([A-Z][a-z]+/\S+ [A-Z][a-z]+/\S+)""");
var talalat5 = minta5.Matches(text);
Dictionary<string, int> stats5 = new Dictionary<string, int>();
foreach (Match elem in talalat5)
{
    if (stats5.ContainsKey(elem.Groups[1].Value))
    {
        stats5[elem.Groups[1].Value]++;
    }
    else
    {
        stats5.Add(elem.Groups[1].Value, 1);
    }
}
Console.WriteLine("Böngésző statisztika:");
foreach (KeyValuePair <string, int> elem in stats5)
{
    Console.WriteLine(elem);
}