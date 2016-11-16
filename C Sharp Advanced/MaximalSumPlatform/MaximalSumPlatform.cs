using System;

namespace MaximalSumPlatform
{
    class MaximalSumPlatform
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] inputs = text.Split(' ');

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] lineOfInts = new string[m];
                lineOfInts = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(lineOfInts[j]);
                }
            }

            int sumMax = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                              matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                              matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum >= sumMax)
                    {
                        sumMax = sum;
                    }
                }
            }

            Console.WriteLine(sumMax);
        }
    }
}
