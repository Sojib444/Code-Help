
int[] nums = { 1};
int target = 0;
int pivotIndex(int[] nums)
{
    int start = 0, end = nums.Length - 1;

    while (start < end)
    {
        int mid = start + (end - start) / 2;

        if (mid + 1 <= nums.Length - 1 && nums[mid] > nums[mid + 1])
        {
            return mid;
        }

        if (mid - 1 >= 0 && nums[mid] < nums[mid - 1])
        {
            return mid - 1;
        }

        if (nums[start] > nums[mid])
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }

    return start;
}

int index = pivotIndex(nums);
int start = 0, end = nums.Length - 1;

if (nums[start] <= target)
{
    end = index;
}
else
{
    start = index + 1;
}


int targetIndex(int[] nums)
{
    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }

        if (nums[mid] < target)
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }
    return -1;
}


Console.WriteLine(targetIndex(nums));