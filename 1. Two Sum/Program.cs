int[] TwoSum(int[] nums, int target)
{

    if (nums.Length == 2)
    {
        return new int[] { 0, 1 };
    }

    var dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        var diff = target - nums[i];

        if (dict.ContainsKey(diff))
        {
            return new int[2] { i, dict[diff] };
        }

        if (!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i], i);
        }
    }

    return new int[2];
}

Console.WriteLine(string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9))); // 0, 1