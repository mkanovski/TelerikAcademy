using System;
using System.Text;

namespace StringSubStringText
{
    class StringSubStringText
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < text.Length;)
            {
                if(text.IndexOf(pattern, i, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    count++;
                    i = (text.IndexOf(pattern, i, StringComparison.CurrentCultureIgnoreCase) + 1);
                }
                else
                {
                    i = text.Length;
                }
            }

            Console.WriteLine(count);
        }
    }
}
