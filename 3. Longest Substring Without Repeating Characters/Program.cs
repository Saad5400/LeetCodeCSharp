public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<int> cl = new List<int>();
        int maximum = 0;

        foreach (char c in s)
        {
            if (cl.Contains(c))
            {
                maximum = cl.Count > maximum ? cl.Count : maximum;
                cl.RemoveRange(0, cl.IndexOf(c) + 1);
            }
            cl.Add(c);
        }
        maximum = cl.Count > maximum ? cl.Count : maximum;


        return maximum;
    }
}