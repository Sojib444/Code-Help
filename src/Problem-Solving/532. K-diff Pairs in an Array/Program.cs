
int[] arr = { 3, 1, 4, 1, 5 };

Array.Sort(arr);

int k = 2;

for(int i = 0; i < arr.Length-1; i++)
{
    if (arr[i] != arr[i+1])
    {
        int d = Math.Abs(arr[i] - arr[i + 1]);

        if(d==k)
        {

        }
    }
}

