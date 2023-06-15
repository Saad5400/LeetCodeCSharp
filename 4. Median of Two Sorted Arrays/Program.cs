double FindMedianSortedArrays(int[] left, int[] right)
{
    int[] arr = new int[left.Length + right.Length];

    int i = 0,
        j = 0,
        k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] < right[j])
            arr[k++] = left[i++];
        else
            arr[k++] = right[j++];
    }
    while (i < left.Length)
    {
        arr[k++] = left[i++];
    }
    while (j < right.Length)
    {
        arr[k++] = right[j++];
    }

    return arr.Length % 2 == 0 ? (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2.0 : arr[arr.Length / 2];
}


Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));