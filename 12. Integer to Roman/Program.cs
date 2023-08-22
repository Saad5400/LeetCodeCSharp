string IntToRoman(int num)
{
    var result = string.Empty;

    var roman = new Dictionary<int, string>
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" },
        { 9, "IX" },
        { 10, "X" },
        { 40, "XL" },
        { 50, "L" },
        { 90, "XC" },
        { 100, "C" },
        { 400, "CD" },
        { 500, "D" },
        { 900, "CM" },
        { 1000, "M" }
    };
    var keys = roman.Keys.ToArray();

    var tracker = keys.Length - 1;
    while (num > 0)
    {
        var key = keys[tracker];
        if (num >= key)
        {
            var value = roman[key];
            result += value;
            num -= key;
        }
        else
        {
            tracker--;
        }
    }

    return result;
}

Console.WriteLine(IntToRoman(3));
Console.WriteLine(IntToRoman(4));
Console.WriteLine(IntToRoman(58));
Console.WriteLine(IntToRoman(1994));
