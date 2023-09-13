

string s = "abc";

int count = 0;

int ExpandString(string s,int i,int j)
{
    int count = 0;

    while (i >= 0 && j < s.Length && s[i] == s[j])
    {
        count++;
        i--;
        j++;
    }

    return count;
}

for(int i = 0; i < s.Length; i++)
{
    //odd
    int odd = ExpandString(s, i, i);
    count += odd;

    //even
    int even = ExpandString(s, i, i + 1); ;
    count += even;

}

Console.WriteLine(count);
