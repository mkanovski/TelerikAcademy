using System;


namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int check = 0;

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    check = check + 1;
                }
            }
            Console.WriteLine(check > 0 ? "Not equal" : "Equal");
        }
    }
}
