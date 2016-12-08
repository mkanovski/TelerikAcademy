using System;
using System.Linq;

namespace ExamProblem3Sneaky
{
    class ExamProblem3Sneaky
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split('x').Select(int.Parse).ToArray();

            char[,] den = ReadMatrix(size[0], size[1]);

            string[] moves = Console.ReadLine().Split(',');

            char[] firstRow = new char[den.GetLength(0)];

            for (int i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = den[0, i];
            }

            int entrance = Array.IndexOf(firstRow, 'e');
                 
            int sneakyLenght = 3;
            int startRow = 0;
            int startCol = entrance;
            int curRow = 0;
            int curCol = entrance;
            int hungry = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                //s - down, w - up, a - left, d - right
                if (moves[i] == "s") { curRow++; }
                else if (moves[i] == "w") { curRow--; }
                else if (moves[i] == "a") { curCol--; }
                else if (moves[i] == "d") { curCol++; }
                hungry++;
                if (hungry == 5)
                {
                    sneakyLenght--;
                    hungry = 0;
                }

                if (curCol == den.GetLength(1))
                {
                    curCol = 0;
                }
                if (curCol < 0)
                {
                    curCol = den.GetLength(1) - 1;
                }

                if (sneakyLenght <= 0)
                {
                    Console.WriteLine("Sneaky is going to starve at [{0},{1}]", curRow, curCol);
                    break;
                }

                if (curRow >= den.GetLength(0))
                {
                    Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", sneakyLenght);
                    break;
                }

                if (curRow == startRow && curCol == startCol)
                {
                    Console.WriteLine("Sneaky is going to get out with length {0}", sneakyLenght);
                    break;
                }

                if (den[curRow, curCol] == '@')
                {
                    sneakyLenght++;
                    den[curRow, curCol] = '-';
                }

                if (den[curRow, curCol] == '%')
                {
                    Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", curRow, curCol);
                    break;
                }

                if(i == moves.Length - 1)
                {
                    Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", curRow, curCol);
                    break;
                }
            }
            
            
        }

        static char[,] ReadMatrix(int row, int col)
        {
            char[,] result = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                string rowsyms = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = rowsyms[j];
                }
            }

            return result;
        }
    }
}
