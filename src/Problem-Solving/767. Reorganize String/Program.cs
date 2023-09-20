string s = "aabbb";

Dictionary<char, int> hashCode = new();

for (int i = 0; i < s.Length; i++)
{
    if (!hashCode.ContainsKey(s[i]))
    {
        hashCode.Add(s[i], 1);
    }
    else
        hashCode[s[i]]++;
}

char mostFrequent = 'o';
int max = int.MinValue;

foreach(var item in hashCode)
{
    if(max < item.Value)
    {
        max = item.Value;
        mostFrequent = item.Key;
    }
}

char[] charr = new char[s.Length];
int index = 0;

while(max > 0 && index < charr.Length)
{
    charr[index] = mostFrequent;
    index += 2;
    max--;
}

if(max > 0)
{
    Console.WriteLine(false);
}

var dictionaryArray = hashCode.ToArray();

for (int i = 1; i < dictionaryArray.Length; i++)
{
    int d = dictionaryArray[i].Value;

    while (d != 0)
    {
        index = index < charr.Length ? index : 1;
        charr[index] = dictionaryArray[i].Key;
        index += 2;
        d--;
    }
}

Console.WriteLine(new String(charr));
