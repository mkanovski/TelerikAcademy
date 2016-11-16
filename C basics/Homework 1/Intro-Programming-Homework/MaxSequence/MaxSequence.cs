using System;

namespace MaxSequence
{
    class MaxSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int maxCount = 1;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i+1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
