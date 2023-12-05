//Given two array A[0….N-1] and B[0….M - 1] of size N and M respectively, 
//representing two numbers such that every element of arrays represent a digit.
//For example, A[] = { 1, 2, 3 } and B[] = { 2, 1, 4 }
//represent 123 and 214 respectively. The task is to find the sum of both the numbers.


int[] arr = { 2, 1, 4 };

int sum = 0;
int i = 0;

while(i < arr.Length)
{
    int d = arr[i];

    while (d > 0)
    {
        int digit = d % 10;
        sum = sum * 10 + digit ;
        d /= 10;
    }
    
    i++;
}

Console.WriteLine(sum);