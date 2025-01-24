static string fordit(string s)
{
    if (s.Length == 0)
    {
        return s;
    }

    return fordit(s.Substring(1)) + s[0];
}

string text = "abcd, efgh";

Console.WriteLine(fordit(text));