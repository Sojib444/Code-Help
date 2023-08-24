
int[] arr = { 1, 3};

Array.Sort(arr);

HashSet<int> hash = new();

int k = 2;

for(int i = 0; i < arr.Length-1; i++)
{
    for(int j = i+1; j < arr.Length; j++)
    {
        if (arr[j] - arr[i] == k)
        {
            hash.Add(arr[j]);
            break;
        }

        if (arr[j] - arr[i] > k)
            break;
    }
}

Console.WriteLine(hash.Count);
