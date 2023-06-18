int Reverse(int x)
{
    string s;

    s = x.ToString();

    try
    {
        if (x >= 0)
            return int.Parse(s.Aggregate("", (acc, x) => x + acc));
        else
            return int.Parse("-" + s.Substring(1).Aggregate("", (acc, x) => x + acc));
    }
    catch (OverflowException)
    {
        return 0;
    }
}

Console.WriteLine(Reverse(0));