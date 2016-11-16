using System;

namespace RemoveЕlementsАrray
{
    class RemoveЕlementsАrray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
