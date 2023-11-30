using System;


int[] arr = [2, 4, 5, 8, 3];

int max = int.MinValue;
int min = int.MaxValue;

foreach(var item in arr)
{
    if(item  > max)
    {
        max = item;
    }

    if(item < min)
    {
        min = item;
    }
}

Console.WriteLine(max);
Console.WriteLine(min);

//Space complexity O(1);
//Time complexity O(n);

/* we can use Sort algorithm which takes O(nlogn) time complexity*/