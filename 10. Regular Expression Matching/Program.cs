using System.Text.RegularExpressions;

bool IsMatch(string s, string p)
{
    return Regex.IsMatch(s, "^"+p+"$");
}

Console.WriteLine(IsMatch("aa", "a")); // false
Console.WriteLine(IsMatch("aa", "a*")); // true
Console.WriteLine(IsMatch("ab", ".*")); // true