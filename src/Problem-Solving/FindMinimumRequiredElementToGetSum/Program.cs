
int[] arr = { 1, 2 };
int target = 2;


int FindMinimumRequireElement(int[] arr,int target)
{
    if(target == 0)
    {
        return 0;
    }

    if(target < 0)
    {
        return int.MaxValue;
    }

    int min = int.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
        int ans = FindMinimumRequireElement(arr, target - arr[i]);

        if(ans < min)
        {
            min = ans+1;
        }
    }

    return min;
}

int d = FindMinimumRequireElement(arr, target);

Console.WriteLine(d);