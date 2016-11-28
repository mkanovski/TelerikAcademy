using System;
using System.Text;

namespace StringReverseString
{
    class StringReverseString
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            string result = new string(arr);

            Console.WriteLine(result);
        }
    }
}
