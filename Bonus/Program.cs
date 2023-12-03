int PossibleBracesCombinations(int duoCount)
{
    var result = 0;
    var count = duoCount * 2;
    var possibilities = Math.Pow(2, duoCount);
    var list = new bool[duoCount];
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = true;
    }
    var startIndex = 0;
    var currentIndex = 1;

    for (int i = 0; i < possibilities; i++)
    {
        var combination = string.Empty;
        for (int j = 0; j < duoCount; j++)
        {
            if (list[j])
            {
                combination += "(";
            }
            else
            {
                combination += ")";
            }
            if (currentIndex > startIndex && currentIndex == j)
            {
                list[j] = !list[j];
                currentIndex++;
            }
        }
        currentIndex = startIndex++;
        var temp = combination;
        for (int j = duoCount - 1; j >= 0; j--)
        {
            if (temp[j] == '(')
            {
                combination += ")";
            }
            else
            {
                combination += "(";
            }
        }
        Console.WriteLine(combination);
    }

    return result;
}

Console.WriteLine(PossibleBracesCombinations(3));