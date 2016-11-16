using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] inputs = text.Split(' ');

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            string[,] matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] lineOfInts = new string[m];
                lineOfInts = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = lineOfInts[j];
                }
            }

            int sequenceMax = int.MinValue;
            int sequence = 1;
            // Намираме дължина на поредица по хоризонталите
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i , j] == matrix[i , j + 1])
                    {
                        sequence++;
                        if (sequence > sequenceMax)
                        {
                            sequenceMax = sequence;
                        }
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
            }
            sequence = 1;
            // Намираме дължина на поредица по вертикалите
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, j] == matrix[i + 1, j])
                    {
                        sequence++;
                        if (sequence > sequenceMax)
                        {
                            sequenceMax = sequence;
                        }
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
            }
            sequence = 1;
            // Намираме дължина на поредица по диагоналите от горе-ляво към долу-дясно
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                int j = i;
                if (j <= (matrix.GetLength(1) - 2))
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        sequence++;
                        if (sequence > sequenceMax)
                        {
                            sequenceMax = sequence;
                        }
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
            }
            sequence = 1;
            // Намираме дължина на поредица по диагоналите от горе-дясно към долу-ляво
            for (int j = matrix.GetLength(1) - 1; j >= 1; j--)
            {
                int i = (matrix.GetLength(1) - 1) - j;
                if (i <= (matrix.GetLength(0) - 2))
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        sequence++;
                        if (sequence > sequenceMax)
                        {
                            sequenceMax = sequence;
                        }
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
            }
            Console.WriteLine(sequenceMax);
        }
    }
}
