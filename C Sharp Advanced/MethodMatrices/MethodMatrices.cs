using System;

namespace MethodMatrices
{
    class MethodMatrices
    {

        // Метод за принтиране на матрици Int

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        // Метод за прочитане на Матриц и принтирането й

        static int[,] ReadMatrix(int row, int col)
        {
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return result;

        }

        //========================================================================

        static void Main()
        {
            int[,] gosho =
            {
                {1, 2, 3, 4, 5 },
                {-10, 15, 23, 34, 1 },
                {1, 1, 1, 2, 2 },
                { -5, -6, -7, -8, 7 }
            };

            int[,] table =
            {
                {1, 1, 1, 1, 1 },
                {2, 2, 2, 2, 2 },
                {3, 3, 3, 3, 3 },
                {4, 4, 4, 4, 4 }
            };

            int[,] probnaMatrix = ReadMatrix(3, 4);

            PrintMatrix(probnaMatrix);


        }


    }
}
