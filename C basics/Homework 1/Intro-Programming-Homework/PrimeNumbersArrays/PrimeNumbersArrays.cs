using System;


namespace PrimeNumbersArrays
{
    class PrimeNumbersArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int temp = 1;

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 0; i < n; i++)
            {
                if ((array[i] % 2 == 0 || array[i] % 3 == 0 || array[i] % 5 == 0 || array[i] % 7 == 0) && array[i] > 7)
                {
                    array[i] = 0;                   
                }
                if (array[i] > temp)
                {
                    temp = array[i];
                }
            }
            Console.WriteLine(temp);
        }
    }
}
