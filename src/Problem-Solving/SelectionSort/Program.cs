

int[] arr = { 4, 2, 1, 0, 3, 5 };

for(int i=0;i<arr.Length;i++)
{
    for(int j=0;j<arr.Length-1;j++)
    {
        if (arr[j] > arr[j+1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}

foreach (var item in arr)
{
    Console.Write(item + " ");
}
