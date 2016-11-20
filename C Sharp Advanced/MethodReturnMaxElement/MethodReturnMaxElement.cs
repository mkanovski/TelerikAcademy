using System;

namespace MethodReturnMaxElement
{
    class MethodReturnMaxElement
    {
        static void Main()
        {
            int[] arr = { 34, 1, 2, 5, 27, 8 };

            Console.WriteLine(string.Join(" ", SortArrayAsc(arr)));
            
        }

        static int[] SortArrayAsc(int[] arr)
        {
            

            return arr;
        }

        static int[] SortArrayDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int elementPosition = i;
                int exchange = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == MaxElement(arr, 0))
                    {
                        elementPosition = j;
                    }
                }

                exchange = arr[i];
                arr[i] = MaxElement(arr, i);
                arr[elementPosition] = exchange;
            }

            return arr;
        }

        static int MaxElement(int[] arr, int startPosition)
        {
                int maxElement = arr[startPosition];
                for (int i = startPosition + 1; i < arr.Length; i++)
                {
                    if(arr[i] > maxElement)
                    {
                    maxElement = arr[i];
                    }
                }
            return maxElement;
        }
    }
}
