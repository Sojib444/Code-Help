public class Program
{
    public static void Main()
    {
        try
        {
            string s = null;
            Console.WriteLine(s[0]);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An exception occurred: {ex.Message}");
        }
    }
}