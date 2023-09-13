
string c = "Test1ng-Leet=code-Q!";

char[] s = c.ToCharArray();

int i = 0;
int j = s.Length - 1;

bool isCharacter(char c)
{
    if((c >= 'a' && c <='z') || (c >= 'A' && c <='Z'))
    {
        return true;
    }

    return false;
}

while (i <= j)
{
    if (isCharacter(s[i]) && isCharacter(s[j]))
    {
        char temp = s[i];
        s[i] = s[j];
        s[j] = temp;
        i++;
        j--;
    }

    if (!isCharacter(s[i]))
    {
        i++;
    }

    if (!isCharacter(s[j]))
    {
        j--;
    }
}

Console.WriteLine(new String(s));