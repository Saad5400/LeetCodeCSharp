int RomanToInt(string s)
{
    var result = 0;

    var romanDict = new Dictionary<string, int>
    {
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 }
    };

    var odd = new char[]
    {
        'I',
        'X',
        'C'
    };

    for (int i = 0; i < s.Length; i++)
    {
        var roman = s[i];
        if (odd.Contains(roman) && i + 1 < s.Length && romanDict[s[i + 1].ToString()] > romanDict[s[i].ToString()])
        {
            result += romanDict[roman.ToString() + s[i + 1]];
            i++;
            continue;
        }
        result += romanDict[roman.ToString()];
    }

    return result;
}

Console.WriteLine(RomanToInt("III"));       // 3
Console.WriteLine(RomanToInt("IV"));        // 4
Console.WriteLine(RomanToInt("IX"));        // 9
Console.WriteLine(RomanToInt("LVIII"));     // 58
Console.WriteLine(RomanToInt("MCMXCIV"));   // 1994
Console.WriteLine(RomanToInt("DCXXI"));     // 621
Console.WriteLine(RomanToInt("MCDLXXVI"));  // 1476
