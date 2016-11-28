using System;
using System.Linq;

namespace MethodNumberAsArray
{
    class MethodNumberAsArray
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] num1 = new int[sizes[0] >= sizes[1] ? sizes[0] : sizes[1]];
            int[] num2 = new int[sizes[0] >= sizes[1] ? sizes[0] : sizes[1]];

            num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = AddStrings(num1, num2);

            Console.WriteLine(String.Join(" ", result));

        }

        static int[] AddStrings(int[] num1, int[] num2)
        {
            int[] result = new int[num1.Length];
            int leftover = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                result[i] = num1[i] + num2[i] + leftover;

                if (result[i] >= 10)
                {
                    leftover = (result[i] / 10);
                    result[i] = result[i] - (result[i] / 10) * 10;
                    
                }
                else if(result[i] < 10)
                {
                    leftover = 0;
                }

            }
            return result;           


        }
    }
}
