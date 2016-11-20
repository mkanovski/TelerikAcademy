using System;

namespace MethodGetMax
{
    class GetMax
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] stringNumbers = line.Split(' ');
            int[] numbers = new int[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = int.Parse(stringNumbers[i]);
            }

            int firstCheck = 0;

            firstCheck = GetMax(numbers[0], numbers[1]);

            Console.WriteLine(GetMax(firstCheck, numbers[2]));

        }

        static int GetMax(int a, int b)
        {
            int result = 0;

            if(a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            return result;
        }
    }
}
