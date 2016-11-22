using System;

namespace MethodReturnMaxElement
{
    class MethodReturnMaxElement
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr = TurnToIntArray(Console.ReadLine(), ' ');

            Console.WriteLine(String.Join(" ", SortArrayAsc(arr))); 
            
        }

        static int[] SortArrayAsc(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            int lastElement = sortedArr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
                sortedArr[lastElement] = MaxElement(arr, 0);
                arr[Array.IndexOf(arr, sortedArr[lastElement])] = int.MinValue;
                lastElement--;
            }

            return sortedArr;
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
