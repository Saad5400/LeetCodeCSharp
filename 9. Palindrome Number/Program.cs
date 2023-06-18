bool IsPalindrome(int x)
{
    string s = x.ToString();
    return s.Equals(string.Join("",  s.Reverse()));
}

Console.WriteLine(IsPalindrome(121)); // true