using System;

namespace MethodSortingArray
{
    class MethodSortingArray
    {
        static void Main()
        {
            

        }

        static int[] SortArray(int[] arr, int positionToStart)
        {
            
            for (int i = positionToStart; i < arr.Length; i++)
            {
                int xchange = 0;
                int element = i;
                int stepMin = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < stepMin)
                    {
                        stepMin = arr[j];
                        element = j;
                    }
                }

                if (stepMin < arr[i])
                {
                    xchange = arr[i];
                    arr[i] = stepMin;
                    arr[element] = xchange;

                }
            }

            return arr;
        }
    }
}
