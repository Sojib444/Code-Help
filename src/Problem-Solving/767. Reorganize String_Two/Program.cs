

string s = "zrhmhyevkojpsegvwolkpystdnkyhcjrdvqtyhucxdcwm";

int[] arr = new int[26];


for(int i=0;i<s.Length;i++)
{
     arr[s[i] - 'a']++;
}

char mostFrequent = 'o';
int max = int.MinValue;

for(int i = 0; i < arr.Length;i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        mostFrequent = (char)(i+'a');
    }
}

char[] rearr = new char[s.Length];

int index = 0;

while(max > 0 && index < rearr.Length)
{
    rearr[index] = mostFrequent;
    index += 2;
    max--;
}

if(max != 0)
{
    Console.WriteLine(false);
}

arr[mostFrequent - 'a'] = 0;

for(int i=0; i<arr.Length;i++)
{

    while (arr[i] > 0)
    {
        index = index < rearr.Length ? index : 1;
        rearr[index] = (char)(i + 'a');
        index += 2;
        arr[i]--;
    }
}


Console.WriteLine(rearr);