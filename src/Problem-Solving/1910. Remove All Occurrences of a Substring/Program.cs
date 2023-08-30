

//Approach bruit force approach

string name = "abbbabcaabcghabc";
string part = "abc";

int partLength = part.Length;
char partFirstCharacter = part[0];

bool flag = true;

while (flag)
{
    for (int i = 0; i < name.Length; i++)
    {
        if (name[i] == partFirstCharacter)
        {
            string subStringFromName = name.Substring(i, partLength);

            if (subStringFromName == part)
            {
                name.Remove(i, partLength);
            }
        }
    }
}





