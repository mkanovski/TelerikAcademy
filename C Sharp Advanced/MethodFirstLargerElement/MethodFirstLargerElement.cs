using System;

namespace MethodFirstLargerElement
{
    class MethodFirstLargerElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = TurnToIntArray(Console.ReadLine(), ' ');

            int result = FirstLargerElement(numbers);

            Console.WriteLine(result);
        }

        static int FirstLargerElement(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if(numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
                {
                    return i;
                }
            }
            int fail = -1;
            return fail;
        }

        static int[] TurnToIntArray(string line, char separator)
        {
            string[] lineNumbers = line.Split(separator);
            int[] numbers = new int[lineNumbers.Length];

            for (int i = 0; i < lineNumbers.Length; i++)
            {
                numbers[i] = int.Parse(lineNumbers[i]);
            }

            return numbers;
        }
    }
}
