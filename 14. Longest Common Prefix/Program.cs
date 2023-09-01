string LongestCommonPrefix(string[] strs)
{
    var prefix = strs[0];

    foreach (var str in strs.Skip(1))
    {
        for (int i = 0; i < prefix.Length; i++)
        {
            if (i >= str.Length || prefix[i] != str[i])
            {
                prefix = prefix[..i];
                break;
            }
        }
        if (string.IsNullOrEmpty(prefix))
        {
            break;
        }
    }

    return prefix;
}

Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" })); // fl
Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" })); // ""
Console.WriteLine(LongestCommonPrefix(new string[] { "ab", "a" })); // a
Console.WriteLine(LongestCommonPrefix(new string[] { "a" })); // a