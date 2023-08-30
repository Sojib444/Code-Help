

//Approach bruit force approach

string name = "eemckxmckx";
string part = "emckx";

int partLength = part.Length;

while(name.IndexOf(part) > 0)
{
    name = name.Remove(name.IndexOf(part), partLength);
}


 Console.WriteLine(name);






