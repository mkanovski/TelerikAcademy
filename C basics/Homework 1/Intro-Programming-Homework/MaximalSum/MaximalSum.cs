using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int sum = 0;
            int sumMax = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++)
            {
                if ( sum + array[i] > 0 )
                {
                    sum += array[i];
                    if (sum + array[i] > sumMax)
                    {
                        sumMax = sum;
                    }
                }
                else
                {
                    sum = 0;
                }
            }
            Console.WriteLine(sumMax);
        }
    }
}
