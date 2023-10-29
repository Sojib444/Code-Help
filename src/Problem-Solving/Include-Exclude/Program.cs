


string s = "xy";

int i = 0;
string sub = "";

void SubSequence( string s, int i, string sub)
{
    if (i >= s.Length)
    {
        Console.WriteLine(sub);
        return;
    }

    SubSequence( s, i+1,  sub);

    sub += s[i];
    SubSequence( s, i+1,  sub);
}

SubSequence(s,  i,  sub);