using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCol = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndCol[0];
            int col = rowsAndCol[1];
            int[,] myMatrix = new int[rows, col];

            for (int row = 0; row < rows; row++)
            {
                int[] matrix = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < col; column++)
                {
                    myMatrix[row, column] = matrix[column];
                }
            }
            List<int> columnSums = new List<int>();

            for (int column = 0; column < col; column++)
            {
                int curValue = 0;
                for (int row = 0; row < rows; row++)
                {
                    curValue += myMatrix[row, column];
                }
                columnSums.Add(curValue);
            }

            Console.WriteLine(string.Join(Environment.NewLine ,columnSums)) ;
        }
    }
}
