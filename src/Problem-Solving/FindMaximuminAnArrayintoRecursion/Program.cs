
int[] arr = { 1, 300, 4 ,10};

int max = int.MinValue;
int i = 0;

void findMax(int[] arr, int i,ref int max)
{
    if(i == arr.Length)
    {
        return ;
    }

    if (arr[i] > max)
    {
        max = arr[i];
    }

    findMax(arr, ++i,ref max);
}
 
findMax(arr, i, ref max);

Console.WriteLine(max);