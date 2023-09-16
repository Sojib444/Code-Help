

string s = "foo";
string t = "arr";
Dictionary<char,char> chars = new();
Dictionary<char,char> chars1 = new();

bool IsIsomorphic(string s, string t)
{
    Dictionary<char, char> characters = new Dictionary<char, char>();
    int length = s.Length;

    for (int i = 0; i < length; i++)
    {
        if (characters.ContainsKey(s[i]))
        {
            if (characters[s[i]] != t[i]) return false;
            continue;
        }
        else if (characters.ContainsValue(t[i])) return false;

        characters[s[i]] = t[i];
    }

    return true;
}

Console.WriteLine(IsIsomorphic(s, t));