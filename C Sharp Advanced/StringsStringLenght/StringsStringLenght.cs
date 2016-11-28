using System;
using System.Text;

namespace StringsStringLenght
{
    class StringsStringLenght
    {
        static void Main()
        {
            string text = Console.ReadLine();

            text = text.PadRight(20, '*');

            Console.WriteLine(text);

        }
    }
}
