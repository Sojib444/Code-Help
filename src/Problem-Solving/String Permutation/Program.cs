


string s = "abc";

void Swap(ref string s,int i,int j)
{
    char[] chars = s.ToCharArray();

    char temp = chars[i];
    chars[i] = chars[j];
    chars[j] = temp;

    s = new string(chars);
}
void Permutation( string s,int i)
{
    if(i >= s.Length)
    {
        Console.WriteLine(s);
        return;
    }

    for (int j = i; j < s.Length; j++)
    {
        Swap(ref s,i,j);
        Permutation(s,i+1);
    }
}

int i = 0;

Permutation( s,i);