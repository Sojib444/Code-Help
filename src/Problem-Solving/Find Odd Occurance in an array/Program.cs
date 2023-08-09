
int[] nums = { 2,51, 1, 2, 2, 3, 3, 4, 4, 2, 2 };

int start = 0;
int end = nums.Length - 1;

int answer = 0;
while(start < end)
{
    int mid = start + (end - start)/2;

    if(start == end)
    {
        answer = nums[start];
    }

    if(mid%2 == 0)
    {
        if (nums[mid] == nums[mid+1])
        {
            start = mid + 2;
        }
        else
        {
            end = mid;
        }
    }
    else
    {
        if (nums[mid] == nums[mid-1])
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }
}

Console.WriteLine(nums[start]);


