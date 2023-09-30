
string s = "abc";
int i = 0;
void include(string s,int i,string output)
{
    if(i >= s.Length)
    {
        Console.WriteLine(output);
        return;
    }

    //exclude
    include(s, i+1, output);

    //include
    output = output + s[i];
    include(s, i+1, output);
}

include(s, i, "");