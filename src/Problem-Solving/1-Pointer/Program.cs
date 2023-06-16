

int[] nums = new int[] { 2,3,5,1,-3,-5,-6,2};

void swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

int low = 0, high = nums.Length-1;

for (int i = 0;i < nums.Length; i++)
{
    if (nums[i] < 0)
    {
        swap(nums,i,high--);
        low++;
    }

}

foreach(var item in nums)
{
    Console.WriteLine(item);
}