using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int tempTotal = 0;
            int count = 0;
            int tempCount = 0;
            int total = -1;
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                tempTotal = array[i];
                tempCount = 1;
                for (int j = i+1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        tempTotal += array[j];
                        tempCount++;                     
                    }
                }
                if (tempTotal > total)
                {
                    total = tempTotal;
                    count = tempCount;
                    element = array[i];
                }

            }
            if (element == 0)
            {
                Console.WriteLine("{0} ({1} times)", element, count);
            }
            else
            {
                Console.WriteLine("{0} ({1} times)", element, count);
            }
        }
    }
}
