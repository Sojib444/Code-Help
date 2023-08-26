

using System.Text;

string sen = "azxxzy";

//unique character
StringBuilder stringBuilder = new StringBuilder();

int[] arr = new int[27];

for(int i = 0; i < sen.Length; i++)
{
    int ascii = sen[i]-96;
    arr[ascii]++;
}

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 1)
    {
        int ascii = i + 96;

        char ch = (char)ascii;
        stringBuilder.Append(ch);
    }
}

Console.WriteLine(stringBuilder);

//Remove all adjacent duplicate 
StringBuilder removeDuplicate = new StringBuilder();

for(int i = 0;i < sen.Length - 1;)
{
    if (sen[i] == sen[i+1])
    {
        i = i + 2;
    }
    else
    {
        removeDuplicate.Append(sen[i]);
        i++;
    }
}

Console.WriteLine(removeDuplicate);


StringBuilder str = new();
str.Append(sen);


bool flag = true;

while (flag)
{
    bool change = false;

    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == str[i + 1])
        {
            str.Remove(i, 2);
            change = true;
        }
    }

    if (!change)
    {
        flag = false;
    }
}




Console.WriteLine(str);



//using stack and queue

string input = "azxxzy";

Stack<char> chars = new Stack<char>();

for(int i=0;i<input.Length;i++)
{
    if(chars.Count == 0)
    {
        chars.Push(input[i]);
    }
    else
    {
        char top_char = chars.Peek();

        if(top_char == input[i])
        {
            chars.Pop();
        }
        else
        {
            chars.Push(input[i]);
        }
    }
}

char[] char_arr = chars.ToArray();

StringBuilder builder = new StringBuilder();

for(int i = char_arr.Length-1; i >= 0; i--)
{
    builder.Append(char_arr[i]);
}

Console.WriteLine(builder.ToString());


