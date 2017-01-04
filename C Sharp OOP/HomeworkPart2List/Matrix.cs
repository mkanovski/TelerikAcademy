using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2List
{
    class Matrix<T> where T:IComparable
    {
        T[,] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new T[rows, columns];
        }

        //Indexer of the Matrix class
        public T this [int row, int col]
        {
            get
            {
                if (row >= 0 && row <= matrix.GetLength(0) - 1 && col >= 0 && col <= matrix.GetLength(1) - 1)
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (row >= 0 && row <= matrix.GetLength(0) - 1 && col >= 0 && col <= matrix.GetLength(1) - 1)
                {
                    matrix[row,col] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //Overloading operators
        public static Matrix<T> operator+(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            Matrix<T> result = new Matrix<T>(matrixA.matrix.GetLength(0), matrixA.matrix.GetLength(1));

            if(matrixA.matrix.GetLength(0) == matrixB.matrix.GetLength(0) &&
                matrixA.matrix.GetLength(1) == matrixB.matrix.GetLength(1))
            {
                for (int i = 0; i < matrixA.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.matrix.GetLength(1); j++)
                    {
                        dynamic num1 = matrixA.matrix[i, j];
                        dynamic num2 = matrixB.matrix[i, j];
                        result.matrix[i, j] = num1 + num2;
                    }
                }
            }
            else
            {
                throw new Exception("The two matrices are not the same size.");
            }

            return result;
        }

        public static Matrix<T> operator-(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            Matrix<T> result = new Matrix<T>(matrixA.matrix.GetLength(0), matrixA.matrix.GetLength(1));

            if (matrixA.matrix.GetLength(0) == matrixB.matrix.GetLength(0) &&
                matrixA.matrix.GetLength(1) == matrixB.matrix.GetLength(1))
            {
                for (int i = 0; i < matrixA.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.matrix.GetLength(1); j++)
                    {
                        dynamic num1 = matrixA.matrix[i, j];
                        dynamic num2 = matrixB.matrix[i, j];
                        result.matrix[i, j] = num1 - num2;
                    }
                }
            }
            else
            {
                throw new Exception("The two matrices are not the same size.");
            }

            return result;
        }

        public static Matrix<T> operator*(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            Matrix<T> result = new Matrix<T>(matrixA.matrix.GetLength(0), matrixA.matrix.GetLength(1));

            if (matrixA.matrix.GetLength(0) == matrixB.matrix.GetLength(0) &&
                matrixA.matrix.GetLength(1) == matrixB.matrix.GetLength(1))
            {
                for (int i = 0; i < matrixA.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.matrix.GetLength(1); j++)
                    {
                        dynamic num1 = matrixA.matrix[i, j];
                        dynamic num2 = matrixB.matrix[i, j];
                        result.matrix[i, j] = num1 * num2;
                    }
                }
            }
            else
            {
                throw new Exception("The two matrices are not the same size.");
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (Equals(matrix.matrix[i,j], 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (Equals(matrix.matrix[i, j], 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
