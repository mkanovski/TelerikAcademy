using System;

namespace MethodMinMaxAvgSumProduct
{
    class MethodMinMaxAvgSumProduct
    {
        static void Main()
        {
            int[] line = TurnToIntArray(Console.ReadLine(), ' ');

            decimal[] result = Maths(line);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine("{0:0.00}", result[2]);
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
        }

        static decimal[] Maths(params int[] arr)
        {
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal avg = 0;
            decimal sum = 0;
            decimal pro = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                pro = pro * arr[i];
            }

            avg = sum / arr.Length;
            
            decimal[] result = { min, max, avg, sum, pro };

            return result;
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
