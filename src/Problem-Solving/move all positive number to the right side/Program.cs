
int[] nums = { 2, -5, 7, 3 - 6 - 7, 2, 87, -3, -7, 2 ,-4,-8,-2,-6,-3};

void swap(int[] arr,int a ,int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

int low = 0, high = nums.Length - 1;

while (low < high)
{
    if (nums[low] > 0)
    {
        swap(nums, low, high--);
    }
    else
    {
        low++;
    }
}

foreach(var item in nums)
{
    Console.WriteLine(item);
}