
int[] nums = { 2, 1, 4, 15, 3,0 };

int start = 0;
int end = nums.Length - 1;

void Merge(int[] arr, int start, int mid, int end)
{
    int l = mid - start + 1;
    int r = end - mid;

    int[] left = new int[l];
    int[] right = new int[r];

    int k = start;

    for (int i = 0; i < l; i++)
    {
        left[i] = arr[k];
        k++;
    }

    k = mid + 1;

    for (int j = 0; j < r; j++)
    {
        right[j] = arr[k];
        k++;
    }

    int a = 0;
    int b = 0;
    int arrIndedx = start;

    while (a < l && b < r)
    {
        if (left[a] < right[b])
        {
            arr[arrIndedx++] = left[a];
            a++;
        }
        else
        {
            arr[arrIndedx++] = right[b];
            b++;
        }
    }

    while (a < l)
    {
        arr[arrIndedx++] = left[a++];
    }

    while (b < r)
    {
        arr[arrIndedx++] = right[b++];
    }
}

void MergeSort(int[] arr, int start, int end)
{
    if(start == end)
    {
        return;
    }

    int mid = start + (end - start) / 2;

    //left Side part of this array
    MergeSort(arr, start, mid);

    //right side part of this array
    MergeSort(arr, mid + 1, end);

    Merge(arr,start,mid,end);
}

MergeSort(nums, start, end);

foreach (var item in nums)
{
    Console.Write(item + " ");
}

