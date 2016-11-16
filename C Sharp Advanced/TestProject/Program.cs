using System;

namespace TestProject
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            if (order == 'a')
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        int input = int.Parse(Console.ReadLine());
                    }
                }
            }
            else if (order == 'b')
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0 || j == 0)
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            int input = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                        {
                            int input = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            else if (order == 'c')
            {
                int j = 0;
                int i = matrix.GetLength(0) - 1;
                int nextRow = matrix.GetLength(0) - 1;

                while (j <= matrix.GetLength(1) - 1 && i >= 0)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                    if (i == matrix.GetLength(0) - 1)
                    {
                        nextRow--;
                        i = nextRow;
                        j = 0;

                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }
            else if (order == 'd')
            {

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
