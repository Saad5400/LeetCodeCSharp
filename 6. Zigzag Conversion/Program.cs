string Convert(string s, int numRows)
{
        if (numRows == 1) return s;

        var arr = new List<string[]>();

        int i = 0, j = 0, k = 0;
        while (i < s.Length)
        {
            if (arr.Count <= j) arr.Add(new string[numRows]);
            if (k == 0)
            {
                for (int z = 0; z < numRows && i < s.Length; z++)
                {
                    arr[j][z] = s[i].ToString();
                    i++;
                }
                k = numRows - 2;
                j++;
            }
            else while (k != 0 && i < s.Length)
            {
                if (arr.Count <= j) arr.Add(new string[numRows]);
                arr[j][k] = s[i].ToString();
                j++;
                i++;
                k--;
            }
        }
        
        string result = string.Empty;

        for (int x = 0; x < numRows; x++)
        {
            for (int y = 0; y < arr.Count; y++)
            {
                result += arr[y][x] is null ? string.Empty : arr[y][x];
            }
        }
        
        return result;
}

Console.WriteLine(Convert("ABCDE", 4));