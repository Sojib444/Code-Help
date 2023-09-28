

int[] arr = { 1, 10, 3, 4, 5, 6 };
int i = 0;

bool Sort(int[] arr, int i)
{
    if(i >= arr.Length)
    {
        return true;
    }

    if (i < arr.Length-1 && arr[i] > arr[i+1])
    {
        return false;
    }

    bool ans = Sort(arr, ++i);

    return ans;
}

bool d = Sort(arr, i);

Console.WriteLine(d);