using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] myMatrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] curMatrix = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < matrixSize; column++)
                {
                    myMatrix[row, column] = curMatrix[column];
                }
            }

            int sum = 0;
            int columnCounter = 0;
            for (int rows = 0; rows < matrixSize; rows++)
            {
                for (int column = columnCounter; column < matrixSize; column++)
                {
                    sum += myMatrix[rows, column];
                    columnCounter++;
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
