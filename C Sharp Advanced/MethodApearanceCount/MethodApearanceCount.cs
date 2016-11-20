using System;

namespace MethodApearanceCount
{
    class MethodApearanceCount
    {
        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            string line = Console.ReadLine();
            string[] lineNumbers = line.Split(' ');

            for (int i = 0; i < lineNumbers.Length; i++)
            {
                numbers[i] = int.Parse(lineNumbers[i]);
            }

            int x = int.Parse(Console.ReadLine());

            int appearanceCount = NumberAppearanceCount(numbers, x);

            Console.WriteLine(appearanceCount);
        }

        static int NumberAppearanceCount(int[] numbers, int x)
        {
            int result = 0;

            foreach (int item in numbers)
            {
                if(item == x)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
