using System;

namespace MethodStringJoin
{
    class Program
    {

        static string Join(int[] numbers, string separator)
        {
            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];

                if(i != numbers.Length - 1)
                {
                    result += separator;
                }
            }

            return result;
        }


        static void Main()
        {
        }
    }
}
