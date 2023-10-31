
int[] arr = { 100,99,2, 4, 1, 3 };

int s = 0, e = arr.Length - 1;

void QuickSort(int[] arr, int s, int e)
{
    if(s >= e)
    {
        return;
    }
    int pivotIndex = PivotIndex(arr,s,e);

    //left side 
    QuickSort(arr, s, pivotIndex - 1);

    //right side
    QuickSort(arr, pivotIndex + 1, e);
}

void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;

}

int PivotIndex(int[] arr, int s, int e)
{

    int count = 0;

    for(int i = s+1; i <= e; i++)
    {
        if (arr[i] < arr[s])
        {
            count++;
        }
    }

    int rightIndex = s + count;

    Swap(arr, s, rightIndex);

    int a = s;
    int b = e;

    while(a < rightIndex && b > rightIndex)
    {
        while (arr[a] < arr[rightIndex])
        {
            a++;
        }

        while (arr[b] > arr[rightIndex])
        {
            b--;
        }

        if(a < rightIndex && b > rightIndex)
        {
            Swap(arr, a, b);
        }
    }

    return rightIndex;
}

QuickSort(arr, s, e);

foreach(var item in arr)
{
    Console.Write(item + " ");
}

//time complexity in avarage case O(nlog) // in "merge sort" avarage and worst case time complexity is O(nlogn) 
//time complexity in worst case O(n^2) //
//space complexity O(n)