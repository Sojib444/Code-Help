

int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

int k = Convert.ToInt32(Console.ReadLine());

int low = 0, high = nums.Length - 1;
for(int i=0;i<k;i++)
{
    Swap(nums, low, high);
}

foreach(var item in nums)
{
    Console.WriteLine(item);
}
