using System;
using System.Text;

namespace StringsSeriesLetters
{
    class StringsSeriesLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            do
            {
                builder.Append(text[0]);
                text = text.TrimStart(text[0]);
            } while (text.Length != 0);

            Console.WriteLine(builder.ToString());

        }
    }
}
