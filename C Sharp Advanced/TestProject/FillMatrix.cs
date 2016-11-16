using System;

namespace TestProject
{
    class FillMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            // Variant a

            if (order == 'a')
            {
                int digit = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = digit;
                        digit++;
                    }
                }
            }

            // Variant b

            else if (order == 'b')
            {
                int digit = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            matrix[i, j] = digit;
                            digit++;
                        }
                    }
                    else
                    {
                        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                        {
                            matrix[i, j] = digit;
                            digit++;
                        }
                    }
                }
            }

            // Variant c

            else if (order == 'c')
            {
                int j = 0;
                int i = matrix.GetLength(0) - 1;
                int nextRow = matrix.GetLength(0) - 1;
                int nextCol = 0;
                int digit = 1;

                while (j <= matrix.GetLength(1) - 1 && i >= 0)
                {
                    matrix[i, j] = digit;
                    digit++;
                    if (i == matrix.GetLength(0) - 1 && j != matrix.GetLength(1) - 1)
                    {
                        nextRow--;
                        i = nextRow;
                        j = 0;

                    }
                    else if (j == matrix.GetLength(1) - 1)
                    {
                        nextCol++;
                        j = nextCol;
                        i = 0;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }

            // Variant d

            else if (order == 'd')
            {
                int offset = 0;
                int i = 0;
                int j = 0;
                int digit = 1;

                while (digit <= n * n)
                {
                    for (i = offset; i < n - offset; i++)
                    {
                        j = offset;
                        matrix[i, j] = digit;
                        digit++;
                    }
                    for (j = 1 + offset; j < n - offset; j++)
                    {
                        i = n - 1 - offset;
                        matrix[i, j] = digit;
                        digit++;
                    }
                    for (i = n - 2 - offset; i >= offset; i--)
                    {
                        j = n - 1 - offset;
                        matrix[i, j] = digit;
                        digit++;
                    }
                    for (j = n - 2 - offset; j >= offset + 1; j--)
                    {
                        i = offset;
                        matrix[i, j] = digit;
                        digit++;
                    }
                    offset++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
