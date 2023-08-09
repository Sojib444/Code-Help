
int[] nums = { 9,10,0,2,3,4 };
int target = 10;


int Search(int[] nums)
{
    int start = 0;
    int end = nums.Length - 1;

    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }

        if (nums[start] > target)
        {
            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        else
        {
            if(nums[mid] > nums[start])
            {
                end = mid -1;
            }
            else
            {
                start = mid + 1;
            }
        }
    }

    return -1;
}

Console.WriteLine(Search(nums));
