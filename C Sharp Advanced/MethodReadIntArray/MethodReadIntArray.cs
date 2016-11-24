using System;
using System.Linq;

namespace MethodReadIntArray
{
    class MethodReadIntArray
    {
        static void Main()
        {
                       
        }

        // Едноредово решение
        // using System.Linq;
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        static int[] TurnToIntArray(string line, char separator)
        {
            string[] lineNumbers = line.Split(separator);
            int[] numbers = new int[lineNumbers.Length];

            for (int i = 0; i < lineNumbers.Length ; i++)
            {
                numbers[i] = int.Parse(lineNumbers[i]);
            }

            return numbers;
        }
    }
}
