

int n = 2;
int p = 3;

int Pow(int n, int p)
{
    if (p == 0) return 1;

    return n * Pow(n, p - 1);
}

int d = Pow(n, p);

Console.WriteLine(d);