

string s = "aacc";

string t = "ccac";

List<char> chars = new();


for(int i=0; i<s.Length;i++)
{
    chars.Add(s[i]);
}

bool ans = true;

for(int i=0;i<t.Length;i++)
{
    if (chars.Contains(t[i]))
    {
        chars.Remove(t[i]);
    }
    else
    {
        ans = false;
        break;
    }
}

if (chars.Count == 0)
{
    ans = true;
}
else
    ans = false;

Console.WriteLine(ans);


//simple solution

int[] character_s = new int[27];
int[] character_t = new int[27];

for(int i=0; i<s.Length;i++)
{
    character_s[s[i] - 97]++;
    character_t[t[i] - 97]++;
}

bool ans_2 = true;

for(int i = 0; i<character_s.Length;i++)
{
    if (character_s[i] != character_t[i])
    {
        ans_2 = false;
        break;
    }
}

Console.WriteLine(ans_2);