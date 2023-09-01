IList<IList<int>> ThreeSum(int[] nums)
{
    IList<IList<int>> result = new List<IList<int>>();

    if (nums.Length == 3)
    {
        if (nums.Sum() != 0)
        {
            return result;
        }
        else
        {
            result.Add(nums.ToList());
            return result;
        }
    }

    nums = nums.OrderBy(x => x).ToArray();

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
            break;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] > 0)
                break;
            for (int k = j + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[j] + nums[k] > 0)
                    break;
                if (nums[i] + nums[j] + nums[k] == 0)
                    result.Add(new List<int>
                    {
                        nums[i],
                        nums[j],
                        nums[k],
                    });
            }
        }
    }

    // distinct
    result = result.DistinctBy(x => string.Join(",", x.OrderBy(x => x))).ToList();

    return result;
}

IList<IList<int>> result1 = ThreeSum(new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 });
// [[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]

Console.WriteLine("result1:");
foreach (var list in result1)
{
    Console.WriteLine($"[{string.Join(",", list)}]");
}
