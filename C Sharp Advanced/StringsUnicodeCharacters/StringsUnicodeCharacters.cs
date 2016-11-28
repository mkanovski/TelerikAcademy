using System;
using System.Text;


namespace StringsUnicodeCharacters
{
    class StringsUnicodeCharacters
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char[] convert = text.ToCharArray();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < convert.Length; i++)
            {
                result.Append(GetEscapeSequence(convert[i]));
            }

            Console.WriteLine(result.ToString());
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
