using System;

namespace MatrixOfNumbers
{
    class MatricOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int length = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
