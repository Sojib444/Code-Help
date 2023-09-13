
using System.Text;

string[] names = { "dog", "racecar", "car" };

StringBuilder stringBuilder = new();

int i = 0; 
while(true)
{
    char curr_char = '0';

    foreach(var item in names)
    {
        if(i >= item.Length)
        {
            curr_char = '0';
            break;
        }
        if(curr_char == '0')
        {
            curr_char = item[i];
        }
        else if(curr_char != item[i])
        {
            curr_char = '0';
            break;
        }
    }

    if(curr_char == '0')
    {
        break;
    }

    stringBuilder.Append(curr_char);
    i++;
}

Console.WriteLine(stringBuilder);