

//print fibbonacci series. N given length;

int nth = 5;

void factIth(int n)
{
    if (n == 0 || n == 1)
    {
        Console.WriteLine(n);
        return;
    }

    int d = fact(n - 1) + fact(n - 2);

    Console.WriteLine(d);
}

factIth(nth);



// ith term from a fibbonacci series.

int n = 5;

int fact(int n)
{
    if (n == 1) return 0;

    if (n == 2) return 1;

    int d= fact(n - 1) + fact(n - 2);

    return d;

}

int d = fact(n);

Console.WriteLine(d);