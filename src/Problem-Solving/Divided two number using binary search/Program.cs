

int dividient = -20;
int divisor = -5;

int start = 0;
int end = Math.Abs(dividient);

int ans = 0;

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

if (dividient < 0 && divisor < 0 || dividient > 0 && divisor > 0)
    Console.WriteLine(ans);
else
    Console.WriteLine(-ans);

