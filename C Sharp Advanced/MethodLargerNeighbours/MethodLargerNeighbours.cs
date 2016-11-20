using System;

namespace MethodLargerNeighbours
{
    class MethodLargerNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = TurnToIntArray(Console.ReadLine(), ' ');

            int largerElements = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(IsElementLarger(numbers, i) == true)
                {
                    largerElements++;
                }
            }

            Console.WriteLine(largerElements);
        }

        static bool IsElementLarger(int[] numbers, int position)
        {
            if(position > (numbers.Length - 2) || position < 1)
            {
                return false;
            } 
            else if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
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
