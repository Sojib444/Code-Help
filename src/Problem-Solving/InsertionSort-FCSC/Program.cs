

int[] nums = { 10, 1, 7, 6, 5,0,100};

for(int i=1;i<nums.Length;i++)
{
    int d_value = nums[i];
    int j = i;

    for( ; j>0; j--)
    {
        if (d_value < nums[j-1])
        {
            nums[j] = nums[j - 1];
        }
        else
        {           
            break;
        }
    }
                        //Here Best Case time complexity is O(n).Worst case time complexity id O(n^2);
    nums[j] = d_value;

}

foreach(var item in nums)
{
    Console.Write(item + " ");
}