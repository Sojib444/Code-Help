string name = "ab";

int i = 0;
int j = name.Length - 1;

bool IspalinDrom(string name,int i,int j)
{
    while(i <= j)
    {
        if (name[i] != name[j])
        {
            return false;
        }

        i++;
        j--;
    }
    return true;
}

bool Check()
{

    while (i <= j)
    {
        if (name[i] != name[j])
        {
            return IspalinDrom(name, i + 1, j) || IspalinDrom(name, i, j - 1);
        }

        i++;
        j--;
    }
    return true;
}

Console.WriteLine(Check());