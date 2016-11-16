using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int temp = int.MaxValue;
            int tempFinal = int.MaxValue;
            int tempElement = 0;
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[j];

                        if (temp < tempFinal)
                        {
                            tempFinal = temp;
                            element = j;
                        }
                    }
                }
                if ( tempFinal < array[i])
                {
                    tempElement = array[i];
                    array[i] = tempFinal;
                    array[element] = tempElement;
                }
                temp = int.MaxValue;
                tempFinal = int.MaxValue;
            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
