

void HasPassword(string password)
{
    byte[] input = System.Text.Encoding.UTF8.GetBytes(password);

    long key = 116421312659916;

    foreach (byte b in input)
    {
        key = (key << 2)+ b;
    }

    string hasingResult = key.ToString("X");

}

void RevertHash(string password)
{
    byte[] input = System.Text.Encoding.UTF8.GetBytes(password);

    long key = 116421312659916;

    foreach (byte b in input)
    {
        key = (key >> 2) - b;
    }

    Console.WriteLine(key.ToString());
}

HasPassword("sojib");