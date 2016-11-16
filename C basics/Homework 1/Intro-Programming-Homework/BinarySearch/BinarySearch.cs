using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            Array.Sort(array);

            if ( x > array[n-1] || array[0] > x)
            {
                Console.WriteLine(-1);
            }
            else if (x < array[n/2])
            {
                for (int i = 0; i < n / 2; i++)
                {
                    if (x == array[i])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else if (x >= array[n/2])
            {
                for (int i = n / 2; i < n; i++)
                {
                    if (x == array[i])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
           
        }
    }
}
