

int dividient = -21;
int divisor = 4;

int start = 0;
int end = Math.Abs(dividient);

decimal ans = 0;

while (start <= end)
{
    int mid = start + (end - start) / 2;

    if(Math.Abs(divisor * mid) == Math.Abs(dividient))
    {
        ans = mid;
    }

    if(Math.Abs(divisor * mid) > Math.Abs(dividient))
    {
        end = mid - 1;
    }
    else
    {
        ans = mid;
        start = mid + 1;
    }
}

decimal precision = 0.1m;
int precitionDigit = 5;

while (precitionDigit > 0)
{
    while (Math.Abs(dividient) % (ans) > 0)
    {
        ans += precision;
    }
    ans /= 10;
    precision /= 10;
    precitionDigit--;
}




if (dividient < 0 && divisor < 0 || dividient > 0 && divisor > 0)
    Console.WriteLine(ans);
else
    Console.WriteLine(-ans);


decimal f = 3.0m + 0.1m + 0.1m + 0.1m;
Console.WriteLine(f);