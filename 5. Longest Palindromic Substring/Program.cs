using System.Diagnostics;

string LongestPalindrome(string s)
{
    string longestSub = string.Empty;

    for (int i = 0; i < s.Length; i++)
    {
        int l1 = i, l2 = i, r1 = i, r2 = i + 1;
        while (true)
        {
            bool b1 = l1 >= 0 && r1 < s.Length && s[l1] == s[r1];
            bool b2 = l2 >= 0 && r2 < s.Length && s[l2] == s[r2];
            if (b1 is false && b2 is false) break;
            if (b1)
            {
                string sub = s.Substring(l1, r1 - l1 + 1);
                if (sub.Length > longestSub.Length)
                    longestSub = sub;
                r1++;
                l1--;
            }
            if (b2)
            {
                string sub = s.Substring(l2, r2 - l2 + 1);
                if (sub.Length > longestSub.Length)
                    longestSub = sub;
                r2++;
                l2--;
            }
        }
    }
    return longestSub;
}

// Test

Console.WriteLine(LongestPalindrome("aacabdkacaa"));