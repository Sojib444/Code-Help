

int[] d = { 1, 2, 3, 4, 5, 6 };

int s = 0;
int e = d.Length - 1;
int target = 20;

bool isPresent(ref int[]  arr, int s, int e, int target)
{
    if(s > e)
    {
        return false;
    }

    int mid = s + (e - s) / 2;

    if (arr[mid] == target)
    {
        return true;
    }
    if (arr[mid] > target)
    {
        return isPresent(ref arr, s, mid - 1,target);
    }
    else
        return isPresent(ref arr, mid + 1, e,target);
}

Console.WriteLine(isPresent(ref d, s, e, target));