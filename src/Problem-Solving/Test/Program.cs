﻿

int n = 5;

int factorial( int n)
{
    if(n==1) return 1;

    return n * factorial(n-1);
}

Console.WriteLine(factorial(n));