using System;
using System.Numerics;

namespace WorkshopBitShiftMatrix
{
    class WorkshopBitShiftMatrix
    {
        static void Main()
        {

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] codes = TurnToIntArray(Console.ReadLine(), ' ');

            BigInteger[,] matrix = new BigInteger[r, c];

            BigInteger result = 0;

            BigInteger startPow = 1;
            BigInteger currentPow = 1;

            for (int i = matrix.GetLength(0) - 1 ; i >= 0 ; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = currentPow;
                    currentPow = currentPow * 2;

                    
                }

                startPow = startPow * 2;
                currentPow = startPow;
            }

            int coeff = Math.Max(r, c);
            int rowStart = matrix.GetLength(0) - 1;
            int colStart = 0;

            for (int i = 0; i < n; i++)
            {
                int row = codes[i] / coeff;
                int col = codes[i] % coeff;

                for (int j = colStart; j != col;)
                {
                    result = result + matrix[rowStart, j];
                    matrix[rowStart, j] = 0;

                    if(colStart < col)
                    {
                        j++;
                    }
                    else if (colStart > col)
                    {
                        j--;
                    }
                }

                colStart = col;

                for (int k = rowStart; k != row;)
                {
                    result = result + matrix[k, colStart];
                    matrix[k, colStart] = 0;

                    if (rowStart < row)
                    {
                        k++;
                    }
                    else if (rowStart > row)
                    {
                        k--;
                    }
                }

                rowStart = row;

            }

            int rowFin = codes[n-1] / coeff;
            int colFin = codes[n-1] % coeff;

            result = result + matrix[rowFin, colFin];

            Console.WriteLine(result);

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
