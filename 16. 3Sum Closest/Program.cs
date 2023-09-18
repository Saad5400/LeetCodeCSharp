int ThreeSumClosest(int[] nums, int target)
{
    Array.Sort(nums);

    int start = 0,
        left,
        right,
        key,
        closest = nums[0] + nums[1] + nums[2];

    while (start < nums.Length - 2)
    {
        key = target - nums[start];
        left = start + 1;
        right = nums.Length - 1;

        while (left < right)
        {
            int result = nums[start] + nums[left] + nums[right];
            if (Math.Abs(target - result) < Math.Abs(target - closest))
                closest = result;
            if (nums[left] + nums[right] > key)
            {
                --right;
            }
            else if (nums[left] + nums[right] < key)
            {
                ++left;
            }
            else if (nums[left] + nums[right] == key)
            {
                return target;
            }
        }
        int currentStartNumber = nums[start];
        while (start < nums.Length - 2 && nums[start] == currentStartNumber)
            ++start;
    }

    return closest;
}

Console.WriteLine(ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));  // 2
Console.WriteLine(ThreeSumClosest(new int[] { 0, 0, 0 }, 1));       // 0
Console.WriteLine(ThreeSumClosest(new int[] { 1, 1, 1, 0 }, -100)); // 2
Console.WriteLine(ThreeSumClosest(new int[] { 1, 1, 1, 0 }, 100));  // 3
