int MyAtoi(string s)
{
    s = s.Trim();
    if (string.IsNullOrEmpty(s)) return 0;

    bool isNegative = s[0] == '-';
    if (isNegative || s[0] == '+')
    {
        s = s.Substring(1);
        if (string.IsNullOrEmpty(s)) return 0;
    }
    if (!char.IsDigit(s[0]))
    {
        return 0;
    }

    char lastChar = s.Where(c => !char.IsDigit(c)).FirstOrDefault('-');
    int index = lastChar == '-' ? s.Length - 1 : s.IndexOf(lastChar);
    s = s.Substring(0, index + 1);
    if (string.IsNullOrEmpty(s)) return 0;
    try
    {
        try
        {
            return isNegative ? -int.Parse(s) : int.Parse(s);
        }
        catch (FormatException)
        {
            string result = string.Empty;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    result += c;
                else
                    break;
            }
            return isNegative ? -int.Parse(result) : int.Parse(result);
        }
    }
    catch (OverflowException)
    {
        return isNegative ? -(int)Math.Pow(2, 31) : (int)(Math.Pow(2, 31) - 1);
    }
}

Console.WriteLine(MyAtoi("  -0012a42"));