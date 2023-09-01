using System.Text;

namespace Implement_String_charater_Remove_Method
{
    public static class StringExtension
    {
        public static string Removechar(this string name, int index)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0;i < index; i++)
            {
                stringBuilder.Append(name[i]);
            }

            return stringBuilder.ToString();
        }

    }
}
