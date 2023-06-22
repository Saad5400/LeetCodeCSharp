int MaxArea(int[] height)
{
    var left = 0;
    var right = height.Length - 1;
    var answer = 0;

    while (left < right)
    {
        answer = Math.Max(answer, (right - left) * Math.Min(height[left], height[right]));
        if (height[left] > height[right])
            --right;
        else
            ++left;
    }

    return answer;
}
Console.WriteLine(MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7, 1 }));