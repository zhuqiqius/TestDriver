using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Matrices
{
    // Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.
    public static class SetZeroToMatrix
    {
        public static int[,] SetZeroToRowAndColumn(int[,] matrix)
        {
            // Print matrix before setting
            PrintMatrix(matrix);

            int m = matrix.GetUpperBound(0) + 1; // size = m + n;
            int n = matrix.GetUpperBound(1) + 1;

            if (m <= 1 && n <= 1)
            {
                return matrix;
            }
            else
            {
                List<int> list = new List<int>();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            list.Add(i);
                            list.Add(j);
                        }
                    }
                }

                int k = 0;
                while (k < list.Count)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[list[k], j] = 0;
                    }

                    for (int i = 0; i < m; i++)
                    {
                        matrix[i, list[k + 1]] = 0;
                    }

                    k = k + 2;
                }
            }

            // Print matrix after setting
            PrintMatrix(matrix);
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int m = matrix.GetUpperBound(0) + 1; // size = m + n;
            int n = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
