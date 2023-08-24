

int[] arr = { 1, 2, 3, 4, 5 };

int low = 0, high = arr.Length - 1;

int k = 4, x = 5; 

while(high - low >= k)
{
    if(Math.Abs(arr[low] - x) > Math.Abs(arr[high] - x))
    {
        low++;
    }
    else
    {
        high--;
    }
}

Console.WriteLine($"Low bound is {low} and high boud is {high}");